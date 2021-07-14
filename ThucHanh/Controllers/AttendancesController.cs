using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ThucHanh.DTOs;
using ThucHanh.Models;

namespace ThucHanh.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        private AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend (/*[FromBody] int courseId*/AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendences.Any(a => a.AttendeeId == userId && a.CourseID == attendanceDto.CourseId))
                return BadRequest("The Attendance Already exists");

            var attendance = new Attendence
            {
                CourseID = attendanceDto.CourseId,
                AttendeeId = userId//User.Identity.GetUserId()
            };

            _dbContext.Attendences.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
