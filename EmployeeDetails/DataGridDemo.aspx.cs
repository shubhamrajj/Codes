using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDetails
{
    public partial class DataGridDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
            lblMsg.Text = "Record Inserted !!!";
        }
    }
}