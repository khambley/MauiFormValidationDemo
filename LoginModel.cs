using System;
using System.ComponentModel.DataAnnotations;

namespace MauiValidationDemo
{
	public class LoginModel
	{
        [Required, MaxLength(50), EmailAddress]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

