﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThucHanh.Models
{
    public class Course
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }
        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LectureID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        [Required]

        public DateTime datetime { get; set; }

        public Category Category { get; set; }
        [Required]

        public byte CategoryId { get; set; }


    }
}