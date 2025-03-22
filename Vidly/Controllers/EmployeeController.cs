using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class EmployeeController : Controller
    {
        Employee emp = new Employee() { Name="Surendra"};
        // GET: Employee
        public ActionResult Name()
        {
            return Content(string.Format("Employee Name : {0}", emp.Name));
        }
    }
}