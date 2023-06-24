using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace HRMSmvcCRUD.Models
{
    public class Employee
    {
        [Required]
        public int Ecode { get; set; }


        [Required]
        [StringLength(10,MinimumLength =5)]
        [RegularExpression("[aA-zZ]*",ErrorMessage ="Employee name must be only alphabets")]
        public string Ename { get; set; }

        [Required]
        [Range(1000,20000)]
        public int Salary { get; set; }
        
        [Required]
        [DataType("System.Int32")]
        [Display(Name ="Department ID")]
        [CustomDeptidCheck(ErrorMessage ="DeptID mus be either 201,202,203")]
        public int Deptid { get; set; }
        public double GetBonus()
        {
            var bonus = 0.0;
            if (Salary > 5000)
            {
                bonus = 0.1 * Salary;

            }
            else
            {
                bonus = 0.2 * Salary;
            }
            return bonus;   
        }
     }

    public class CustomDeptidCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var did=(int)value;
            if(did!=201||did!=202||did!=203)
            {
                return false;
            }
            else
            {
                return true;
            }
            return base.IsValid(value);
        }
    }

}
