using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDetails
{
    public partial class DetailForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteEmp_Click(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            string Ename=txtEname.Text;
            string Eid = txtEID.Text;
            string Salary = txtEsal.Text;
            string Deptid=txtDeptid.Text;
            lblEmpName.Text = Ename;
            lblEmpId.Text = Eid;
            lblEmpSal.Text = Salary;
            lblEmpDptID.Text = Deptid;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}