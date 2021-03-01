using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.OleDb;
namespace ConsoleApp4
{
    public class usermethods
    {


        public static int getidbyuser (string name)
        {
            string com = "select * FROM users WHERE UserName = '" + name + "'";

          DataTable dt =  oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return   (int) dr["ID"];
            }
            return 0;
        }

        public static void addUser(string Name, string Password)
        {
            string com = "insert into users ([UserName],[PassWord]) VALUES ('" + Name + "','" + Password + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallUser()
        {
            string com = "select * from users";
            return oledbhelper.GetTable(com);
        }
        public static DataTable updatePassword(string pass)
        {
            string com = "update users set Password='" + pass + "'";
            return oledbhelper.GetTable(com);
        }

        public static DataTable getByUserName(string Name)
        {
            string com = "select * from users where Username='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByid(int Name)
        {
            string com = "select * from users where ID ='" + Name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBLastName(string Name)
        {
            string com = "select * from users where Lastname='" + Name + "'";
            return oledbhelper.GetTable(com);

        }
        public static string getPassword(string UserName)
        {
            string com = "select [PassWord] from Users where Username = '" + UserName + "'";
            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr[0].ToString();
            }
            return null;

        }
        public static string getuserbyid(int id)
        {
            string com = "select * FROM users WHERE ID = " + id + "";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr["Username"].ToString();
            }
            return null;
        }

    }
}