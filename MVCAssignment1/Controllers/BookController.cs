using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookEntityLayer;
using Book_BusinessLib;


using MVCAssignment1.Models;
using BookClass = MVCAssignment1.Models.BookClass;

namespace MVCAssignment1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var bll = new Book_BusinessLayer();

            var lstbooks= bll.DisplayBooks().Select(o => new MVCAssignment1.Models.BookClass    
            {
                BookID = o.BookID,
                Book_Name=o.Book_Name,
                Author_Name=o.Author_Name,
                Publisher_Name=o.Publisher_Name,
                No_Of_Copies=o.No_Of_Copies,
                Price=o.Price,
            });

            return View(lstbooks);
            
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MVCAssignment1.Models.BookClass book)
        {
            var record = new BookEntityLayer.BookDetails
            {
               BookID=book.BookID,
               Book_Name=book.Book_Name,
               Author_Name=book.Author_Name,
               Publisher_Name=book.Publisher_Name,
               No_Of_Copies=book.No_Of_Copies,
               Price=book.Price,


            };

            var bll = new Book_BusinessLayer();
            bll.AddBooks(record);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string Bid) 
        { 
            var bll=new Book_BusinessLayer();
            bll.DeleteBooks(Bid);
            return RedirectToAction("Index");
        }
    }
}