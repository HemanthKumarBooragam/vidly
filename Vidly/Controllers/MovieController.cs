using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        Movie movie = new Movie() { Id = 1, Name = "OG", Hero = "PSPK", Language = "Telugu" };
        // GET: Movie
        public ActionResult Random()
        {
            return View(movie);
        }

        public ActionResult Hero()
        {
            return View(movie);
        }

        public ActionResult Language()
        {
            return View(movie);
        }
    }
}