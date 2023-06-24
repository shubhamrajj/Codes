using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HRMSBusinessLIB;
using HRMSEntitiesLibrary;
using HRMSmvcCRUD.Models;

namespace HRMSmvcCRUD.Controllers
{
    public class HRMS1Controller : Controller
    {
        // GET: HRMS1
        public ActionResult Index()
        {
            var bll = new HRMS_BusinessLayer();
            var lstEmps = bll.GetAllEmps().Select(o => new HRMSmvcCRUD.Models.Employee
            {
                Ecode = o.Ecode,
                Ename = o.Ename,
                Salary = o.Salary,
                Deptid = o.Deptid,
            });
            return View(lstEmps);
           
        }

        [HttpGet]
        public ActionResult WeaklyTypeForm()
        {
            return View();
        }




        [HttpGet]
        public ActionResult Display()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Display(Registration register/*string Name,string City,List<string> Courses,DateTime Date_Of_Enrollment*/)
        {
            string msg = $"Thank you for Registering,{register.Name}";
            msg += $"\nLocation:{register.City}";
            msg += $"\nCourses Interested :{GetCourses(register.Courses)}";
            msg += $"\nApprox Date :{register.Date_Of_Enrollment.ToString("dd//MM/yy")}";

            ViewData.Add("msg", msg);
            return View();
        }
        private string GetCourses(List<string> courses)
        {
            var str = "";
            foreach (var c in courses)
            {
                str += c + ";";

            }
            return str; 
        }

    }
}