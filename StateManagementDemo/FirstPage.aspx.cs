using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNextPage_Click(object sender, EventArgs e)
        {
            string uname=txtName.Text;
            string pno=txtPno.Text;
            Response.Redirect($"~/SecondPage.aspx?txtName={uname}&txtPno={pno}");
        }
    }
}