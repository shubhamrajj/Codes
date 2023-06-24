using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPDotNetIdentityDemo
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname= txtName.Text;
            string pwd = txtPass.Text;

            //Identity
            var userIdentity = new IdentityUser { UserName = uname, };
            //Store IdentityUser
            var userStore=new UserStore<IdentityUser>();

            //UserManager
            var userManager=new UserManager<IdentityUser>(userStore);

            //Register User in Identity Database (Code First is Used)

            IdentityResult result=userManager.Create(userIdentity, pwd);

            if(result.Succeeded)
            {
                lblMsg.Text = $"User {uname} registered successfully";
            }
            else
            {
                lblMsg.Text = "Some error occured could not register user :" +result.Errors.FirstOrDefault();
            }


        }
    }
}