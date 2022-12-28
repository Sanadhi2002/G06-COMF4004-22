﻿using System.ComponentModel.DataAnnotations;

namespace Project_G06.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }    
    }
}