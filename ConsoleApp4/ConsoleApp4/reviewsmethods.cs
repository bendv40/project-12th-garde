using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.OleDb;
namespace ConsoleApp4
{
   public class reviewsmethods
    {
        public static void addreview(string reviewtext , int music , int userid )
        {
            string com = "insert into reviews ([review],[music],[Suser]) VALUES ('" + reviewtext + "'," + music + "," + userid + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallreviews()
        {
            string com = "select * from reviews";
            return oledbhelper.GetTable(com);

        }
        public static DataTable updatereviewsUSER(int user)
        {
            string com = "update reviews set user=" + user + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByid(int id)
        {
            string com = "select * from  reviews where music =" + id + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBymusicname(string name)
        {
            string com = "select * from  reviews where music='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByuser(int num)
        {
            string com = "select * from reviews where user=" + num + "";
            return oledbhelper.GetTable(com);
        }
        public static void removereview(int id)
        {
            string com = "Delete from reviews where ID = " + id + "";
            oledbhelper.Execute(com);
        }
        public static void removereviewbymusic(int id)
        {
            string com = "Delete from reviews where music = " + id + "";
            oledbhelper.Execute(com);
        }
    }
}
