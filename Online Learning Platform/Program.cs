using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Models;
using Online_Learning_Platform.Models.Data;
using Online_Learning_Platform.Repository.Interfaces;
using Online_Learning_Platform.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// Add DbContext Connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Repositories
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//builder.Services.AddScoped(typeof(IGenericRepository<Instructor>), typeof(GenericRepository<Instructor>));
builder.Services.AddScoped(typeof(IGenericRepository<Course>), typeof(GenericRepository<Course>));
//builder.Services.AddScoped(typeof(IGenericRepository<Category>), typeof(GenericRepository<Category>));
//builder.Services.AddScoped(typeof(IGenericRepository<Student>), typeof(GenericRepository<Student>));
//builder.Services.AddScoped(typeof(IGenericRepository<Lesson>), typeof(GenericRepository<Lesson>));


// Configure
builder.Services.AddIdentity<UserBase, IdentityRole<int>>()
	.AddEntityFrameworkStores<ApplicationDbContext>()
	.AddDefaultTokenProviders();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
