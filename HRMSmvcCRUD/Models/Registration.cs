using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRMSmvcCRUD.Models
{
    public class Registration
    {
        public int Name { get; set; }
        public string City { get; set; }
        public List<string> Courses { get; set; }
        public DateTime Date_Of_Enrollment { get; set; }

    }
}