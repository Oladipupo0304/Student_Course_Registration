using StudentCourseRegistration.Context;
using StudentCourseRegistration.Models.Authorize;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Student_Course_Registration.Data;


namespace StudentCourseRegistration.Controllers;


public class StudentController(
    UserManager<IdentityUser> userManager,
    SignInManager<IdentityUser> signInManager,
    INotyfService notyf,
    StudentCourseRegistrationDbContext arsContext,
    IHttpContextAccessor httpContextAccessor) : Controller
{
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly SignInManager<IdentityUser> _signInManager = signInManager;
    private readonly INotyfService _notyfService = notyf;
    private readonly StudentCourseRegistrationDbContext _arsContext = arsContext;
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return RedirectToAction("RegisteredCourses");
            }
        }
        return View(model);
    }





    [HttpPost]
    public async Task<IActionResult> Register(Student student)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser { UserName = student.Email, Email = student.Email };
            var result = await _userManager.CreateAsync(user,student.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
        }
        return View(student);
    }


}

