﻿using System.ComponentModel.DataAnnotations;

namespace Blog.Core.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Occupation { get; set; }

        [Display(Name = "Administrator")]
        public bool IsAdmin { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
