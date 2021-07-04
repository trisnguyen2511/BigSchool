﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucHanh.Models;
using ThucHanh.ViewModels;

namespace ThucHanh.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses

        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LectureID = User.Identity.GetUserId(),
                datetime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Coure.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}