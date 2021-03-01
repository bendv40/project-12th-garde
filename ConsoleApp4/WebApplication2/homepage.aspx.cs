using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using ConsoleApp4;
    using System.Data;

using System.Data.OleDb;
namespace WebApplication2
{
    public partial class homepage : System.Web.UI.Page
    {
        int id;
      

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "welcome " + Session["value"].ToString() + " to the reviews site ! bellow you can see all the songs or albums that have a review by clicking on the select button next to them and you can add a review of your own to an existing song or a new song by clicking on the button below!";
            GridView1.DataSource = MUSICmethods.getallmusic();
            GridView1.DataBind();
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("addreview.aspx");
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
           if(Session["value"].ToString()=="admin")
            {
                Button2.Visible = true;
            }

           
            GridView2.DataSource = reviewsmethods.getByid(int.Parse(GridView1.SelectedRow.Cells[1].Text));

            GridView2.DataBind();


            Label3.Text= performermethods.getperformernamebymusic(int.Parse(GridView1.SelectedRow.Cells[1].Text));


            Label5.Text = genremothods.getganrebyid(int.Parse(GridView1.SelectedRow.Cells[3].Text));







           


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            performermethods.removeperformer(int.Parse(GridView1.SelectedRow.Cells[1].Text));
            reviewsmethods.removereviewbymusic(int.Parse(GridView1.SelectedRow.Cells[1].Text));
            MUSICmethods.removemusic(int.Parse(GridView1.SelectedRow.Cells[1].Text));            
           

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["value"].ToString() == "admin")
            {
                Button3.Visible = true;
            }

            Label7.Text = usermethods.getuserbyid(int.Parse(GridView2.SelectedRow.Cells[3].Text));




        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            reviewsmethods.removereview(int.Parse(GridView2.SelectedRow.Cells[1].Text));          
            DataTable dt = reviewsmethods.getByid(int.Parse(GridView1.SelectedRow.Cells[1].Text));
            if (dt.Rows.Count == 0)
            {
                performermethods.removeperformer(int.Parse(GridView1.SelectedRow.Cells[1].Text));
                MUSICmethods.removemusic(int.Parse(GridView1.SelectedRow.Cells[1].Text));
               
            }
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("LOG IN.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView1.DataBind();
            GridView2.DataBind();
        }
    }
}