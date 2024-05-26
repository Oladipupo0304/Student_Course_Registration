using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StudentCourseRegistration.Models.Authorize;

public class LoginViewModel
{
    [Required(ErrorMessage = "Username is required!")]
    public string Username { get; set; } = default!;

    [Required(ErrorMessage = "Password is required!")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = default!;

    [Required(ErrorMessage = "Email is required!")]
    public string Email { get; internal set; } = default!;
}

