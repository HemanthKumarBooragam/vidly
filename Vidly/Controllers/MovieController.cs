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
        public ActionResult Name(int movieId)
        {
            //return Content("This is a sample movie...");
            //return HttpNotFound();
            return Content(string.Format("The parameter value is : {0}", movieId));
        }

        public ActionResult Hero()
        {
            return View(movie);
        }

        public ActionResult Language()
        {
            return View(movie);
        }

        //Optional parameters using nullable type for int, for string not required
        // /Movie/Index will work as they have optional parameters
        //but /Movie/Index/10/Name will not work, as they are not valid params
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(string.Format("Page Index : {0} &  Sort By : {1}", pageIndex, sortBy));
        }

        //http://localhost:57119/Movie/Released/2025/01 
        //When we wanted to have a custom route, we need to add like this before the default route
        public ActionResult Released(int year, int month)
        {
            return Content(string.Format("Released Year : {0} & Month : {1}", year, month));
        }
    }
}