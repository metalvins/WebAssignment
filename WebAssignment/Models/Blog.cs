﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebAssignment.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(5000)]
        public string Content { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime Date { get; set; } = DateTime.Now;

        public Author Author { get; set; }
    }
}
