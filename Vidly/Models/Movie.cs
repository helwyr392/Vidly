﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        public Genre Genre { get; set; }

        public int GenreID { get; set; }

        public int NumberInStock { get; set; }
    }
}