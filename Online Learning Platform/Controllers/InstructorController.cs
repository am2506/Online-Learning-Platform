﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.Controllers
{
	public class InstructorController : Controller
	{
		IInstructorRepository _instructorRepository;
        public InstructorController(IInstructorRepository instructorRepository)
        {
            _instructorRepository= instructorRepository;
        }

        public async Task<IActionResult> GetInstructorInfo(int id)
		{
			var InstructorInfo = await _instructorRepository.GetById(id);
			return View(InstructorInfo);
		}
	}
}
