using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemo
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name=Request.QueryString.Get("uname");
            string phone = Request.QueryString.Get("pno");

           username.Text = name;
            phonenum.Text=phone;
        }
    }
}