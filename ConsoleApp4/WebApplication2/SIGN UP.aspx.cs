using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsoleApp4;

namespace WebApplication2
{
    public partial class SIGN_UP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsoleApp4.usermethods.addUser(TextBox1.Text, TextBox2.Text);
          Response.Redirect("LOG IN.aspx");
        }
    }
}