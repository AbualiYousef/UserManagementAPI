﻿using System.ComponentModel.DataAnnotations;

namespace User.Management.Service.Models.Authentication.SignUp;

public class RegisterUser
{
    [Required(ErrorMessage = "Username is required")]
    public string? Username { get; set; }
    
    [EmailAddress]
    [Required(ErrorMessage = "Email is required")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Password is required")]
    public string? Password { get; set; }
    
    [Required(ErrorMessage = "Role is required")]
    public List<string>? Roles { get; set; }
}