﻿using System.ComponentModel.DataAnnotations;

namespace Authorization.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
      
        [Required]
        [StringLength(12, MinimumLength =8)]
        public string Password { get; set; }
    }
}
