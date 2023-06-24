using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace ASPDotNetIdentityDemo
{
    public partial class LoginUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname=txtName.Text;
            string pwd = txtPass.Text;

            //var userIdentity = new IdentityUser { UserName = uname };
            var userStore=new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var userIdentity =userManager.Find(uname, pwd);

            if (userIdentity==null)
            {
                lblMsg.Text = "Invalid username or password";
            }
            else
            {
                lblMsg.Text = "User login Successful";
                Response.Redirect("~/HomePage.aspx");
            }
        }
    }
}