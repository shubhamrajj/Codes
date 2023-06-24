using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDetails
{
    public partial class RepeatersDataDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected double GetBonus(object salary)
        {
            double bonus = 0;
            int sal = (int)salary;
            if(sal>3000)
            {
                bonus = 0.1 * sal;
            }
            else
            {
                bonus = 0.2 * sal;
            }
            return bonus;
        }
    }
}