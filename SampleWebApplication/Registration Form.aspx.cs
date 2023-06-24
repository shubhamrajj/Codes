using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebApplication
{
    public partial class Registration_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string city = DropDownList1.Text;
          

            string course = "";
            foreach(ListItem item in ListBox1.Items)
            {
                if(item.Selected)
                {
                    course+= item.Text+";";
                }
            }
            string date = Calendar1.SelectedDate.ToString("dd/MM/yyyy");


            lblMsg1.Text = "Thank you for Registering: "+name;
            lblMsg2.Text = "Location: " + city;
            lblMsg3.Text = "Courses Interested in: " + course;
            lblMsg4.Text = "Approximate Date Preffered: "+date;
        }
    }
}