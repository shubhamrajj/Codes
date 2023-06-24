using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeDetails
{
    public partial class ValidationControlsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMsg.Text = "Page is OK !!!";
            }
            else
            {
                lblMsg.Text = "Page is Invalid !!!";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string data = args.Value;
            if (data == "Welcome")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
                CustomValidator1.ErrorMessage = "This Data is Invalid !!!";
            }
        }
    }
}
