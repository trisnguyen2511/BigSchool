using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThucHanh.Models;

namespace ThucHanh.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course>  UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}