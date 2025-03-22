﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "OG"};

            return View(movie);
        }

        public ActionResult Hero()
        {
            var movie = new Movie() { Id = 1, Name = "OG", Hero = "PSPK" };

            return View(movie);
        }
    }
}