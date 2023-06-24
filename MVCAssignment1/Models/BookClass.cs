using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
    public class BookClass
    {
        public string BookID { get; set; }
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public string Publisher_Name { get; set; }

        public int No_Of_Copies { get; set; }
        public int Price { get; set; }
    }
}