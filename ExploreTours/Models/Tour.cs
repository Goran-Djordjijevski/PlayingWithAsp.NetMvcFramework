using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExploreTours.Models
{
    public class Tour
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Display(Name = "Length in days")]
        [Range(minimum: 1, maximum: 99)]
        public int Length { get; set; }

        public decimal Price { get; set; }

        public string Rating { get; set; }

        [Display(Name = "Includes meals")]
        public bool IncludesMeals { get; set; }
    }
}