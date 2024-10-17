using Microsoft.CodeAnalysis;

namespace Online_Learning_Platform.Helpers
{
	public class DocumentSettings
	{
		public static string UploadFile(IFormFile file, string folder)
		{
			//^^^ 1. Get Located Folder Path

			//string folderPath = "E:\\DEPI \\GraduationProject\\Online Learning Platform\\Online Learning Platform\\wwwroot\\UserData\\Images\\";
			//string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\UserData\\" + folder + "\\";
			string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot",folder);

			//^^^ 2. Get File Name and Make it  UNIQUE
			string fileName = $"{Guid.NewGuid()}{file.FileName}";

			//^^^ 3. Get File Path
			string filePath = Path.Combine(folderPath, fileName);

			//^^^ 4. Save file as Stream 
			var fileStream = new FileStream(filePath, FileMode.Create);

			file.CopyTo(fileStream);
			return fileName;
		}
		public static int DeleteFile(string folder, string fileName)
		{
			//^^^ 1. Get Located Folder Path
			string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot",folder);

			//^^^ 2. Get File Path
			string filePath = Path.Combine(folderPath, fileName);

			//^^^ 3. Check if file exists
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
				return 0;
			}
			return 1;
		}
	}
}
