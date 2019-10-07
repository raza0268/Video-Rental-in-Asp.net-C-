﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}