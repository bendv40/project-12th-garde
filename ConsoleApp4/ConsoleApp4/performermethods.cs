using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.OleDb;
namespace ConsoleApp4
{
   public class performermethods
    {
        public static void addperformer(string name, int music)
        {
            string com = "insert into performer (performer,music) VALUES ('" + name + "'," + music +")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallreviews()
        {
            string com = "select * from  reviews";
            return oledbhelper.GetTable(com);

        }
        public static DataTable updateperformerCode(int code)
        {
            string com = "update performer set music=" + code + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByname(string name)
        {
            string com = "select * from  performer where performername=" + name + "";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getBymusic(int num)
        {
            string com = "select * from  performer where music=" + num + "";
            return oledbhelper.GetTable(com);
        }
       
        public static int isexistbyname(string name)
        {
            string com = "select * FROM performer WHERE performer = '" + name + "'";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            return 0;
        }
        public static void removeperformer(int id)
        {
            string com = "Delete from performer where music = " + id + "";
            oledbhelper.Execute(com);
        }
        public static string getperformernamebymusic(int music)
        {
            string com = "select * FROM performer WHERE music = " + music + "";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr["performer"].ToString();
            }
            return null;
        }
    }
}
