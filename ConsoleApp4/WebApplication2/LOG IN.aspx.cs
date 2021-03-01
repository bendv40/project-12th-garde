using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsoleApp4;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox2.Text == ConsoleApp4.usermethods.getPassword(TextBox1.Text))
            {

                Label2.Text = "RIGHT PASSWORD! HELLO " + TextBox1.Text;
                Session["Value"] = TextBox1.Text;
                Response.Redirect("homepage.aspx");
            }

            else
                Label2.Text = "WRONG PASSWORD OR USERNAME TRY AGIAN.....";
            
        }
    }
}