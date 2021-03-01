using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsoleApp4;

namespace WebApplication2
{
    public partial class addreview : System.Web.UI.Page
    {
        int num=1;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ID=0;
            if (TextBox1.Text != "" || TextBox2.Text != "" || TextBox3.Text != "")
            {



                if (MUSICmethods.isexistbyname(TextBox1.Text) == 1)
                {
                    ConsoleApp4.MUSICmethods.addmusic(TextBox1.Text.ToString(), num);
                    ID = MUSICmethods.getIDbyname(TextBox1.Text.ToString());
                }
                else
                {
                    ID = MUSICmethods.getIDbyname(TextBox1.Text.ToString());
                }
               
                    performermethods.addperformer(TextBox2.Text, ID);
                




                ConsoleApp4.reviewsmethods.addreview(TextBox3.Text.ToString(), ID, usermethods.getidbyuser(Session["Value"].ToString()));
                Response.Redirect("homepage.aspx");
            }
            else Label1.Text = "you did not fill all of the fields! fill them and the press the button!";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = DropDownList1.SelectedIndex + 1;
        }
    }
}