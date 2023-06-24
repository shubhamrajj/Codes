using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMSmvcCRUD.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            //var y = (int)Session["Y"];

            var accno=Request.Cookies.Get("accountno").Value;
            ViewData.Add("accountno", accno);
            return View();
        }
    }
}