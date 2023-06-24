using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HRMSBusinessLIB;
using HRMSEntitiesLibrary;

using HRMSmvcCRUD.Models;
using Employee = HRMSmvcCRUD.Models.Employee;

namespace HRMSmvcCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            //get the record from business layer

            var Msg = "Welcome to HRMS Application ";
            ViewBag.Msg=Msg;
            var obj=new Employee { Ecode=111,Ename="John ",Salary=100000,Deptid=222};
            ViewData.Add("emp2", obj);
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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HRMSmvcCRUD.Models.Employee emp)
        {

            if (emp.Ecode < 0)
            {
                ModelState.AddModelError("Ecode", "Ecode must be greater than 0");
            }
            


            if (ModelState.IsValid)
            {
                var record = new HRMSEntitiesLibrary.Employee
                {
                    Ecode = emp.Ecode,
                    Ename = emp.Ename,
                    Salary = emp.Salary,
                    Deptid = emp.Deptid,
                };
                var bll = new HRMS_BusinessLayer();
                bll.AddEmployee(record);

                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var bll = new HRMS_BusinessLayer();
            bll.DeleteEmpbyID(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var bll=new HRMS_BusinessLayer();
            var emp = bll.FindEmpbyID(id);
            var empRecord = new HRMSmvcCRUD.Models.Employee
            {
                Ecode = emp.Ecode,
                Ename = emp.Ename,
                Salary = emp.Salary,
                Deptid = emp.Deptid
            };

            return View(empRecord);
        }
        [HttpPost]

        public ActionResult Edit(HRMSmvcCRUD.Models.Employee emp)
        {
            var empRecord = new HRMSEntitiesLibrary.Employee
            {
                Ecode = emp.Ecode,
                Ename = emp.Ename,
                Salary = emp.Salary,
                Deptid = emp.Deptid
            };
            var bll = new HRMS_BusinessLayer(); 
            bll.UpdateEmpbyID(empRecord);



            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var bll = new HRMS_BusinessLayer();
            var emp = bll.FindEmpbyID(id);
            var empRecord = new HRMSmvcCRUD.Models.Employee
            {
                Ecode = emp.Ecode,
                Ename = emp.Ename,
                Salary = emp.Salary,
                Deptid = emp.Deptid
            };
            return View(empRecord);
        }

        [HttpGet]

        public ActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
         public ActionResult AddEmp(Employee emp)
        {
            return RedirectToAction("DisplayDetails",new {Ecode=emp.Ecode,Ename=emp.Ename,Salary=emp.Salary,Deptid=emp.Deptid});

        }
        [HttpGet]
        public ActionResult DisplayDetails(Employee emp)
        {
            var bonus=emp.GetBonus();
           
            ViewData.Add("bonus", bonus);
            return View(emp);
        }
        
        
        [HttpGet]
        public ActionResult DisplayMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DisplayMessage(Message msg)
        {
            
            return View(msg);
        }
        [HttpGet]
        public ActionResult First()
        {

            //Client Side StateMAnagement using Cookies
            HttpCookie ck_accno = new HttpCookie("accountno", "1234567");

            Response.Cookies.Add(ck_accno);



            Session.Add("Y", 200);

            TempData.Add("X", 100);
            TempData.Keep("X");
            return View();
        }

        [HttpGet]
        public ActionResult Second()
        {
            //var y = (int)Session["Y"];
            return View();
        }
    }
}


    