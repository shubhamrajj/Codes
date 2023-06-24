using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApplication
{
    public partial class DemoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string un=txtUserName.Text;
            string pwd=txtPassword.Text;
            if(un=="Admin" && pwd=="1234")
            {
                lblMessage.Text = "Logged in as Admin ";
            }
            else
            {
                lblMessage.Text = "Wrong Username or Password !!!";
            }
        }
    }
}