using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.OleDb;
namespace ConsoleApp4
{
  public  class genremothods
    {
        public static void addganre(string ganre)
        {
            string com = "insert into ganre (ganre) VALUES ('" + ganre + "')";
            oledbhelper.Execute(com);
        }
        public static DataTable getallganres()
        {
            string com = "select * from  ganre";
            return oledbhelper.GetTable(com);

        }
        public static string getganrebyid(int id)
        {
            string com = "select * FROM ganre WHERE ID = " + id + "";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return dr["ganre"].ToString();
            }
            return null;
        }
    }
}
