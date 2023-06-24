using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            var emp = new Employee()
            {
                Ecode = 101,
                Ename = "Ravi",
                Salary = 1111,
                Deptid = 201
            };
            

            return View(emp);
        }
        public ActionResult Home()
        {
            ViewData["Message"] = "Welcome to Capgemini";
            var emp = new Employee()
            {
                Ecode = 101,
                Ename = "Ravi",
                Salary=1111,
                Deptid=201
            };
            ViewData["empObj"] = emp;

            return View();
        }
    }
}