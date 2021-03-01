using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.OleDb;
namespace ConsoleApp4
{
    public class MUSICmethods
    {
        public static void addmusic(string name, int ganre)
        {
            string com = "insert into music (musicName,genre) VALUES ('" + name + "'," + ganre + ")";
            oledbhelper.Execute(com);
        }
        public static DataTable getallmusic()
        {
            string com = "select * from  music";
            return oledbhelper.GetTable(com);

        }
        public static DataTable updatereviewsCode(int Scode)
        {
            string com = "update music set Scode=" + Scode + "";
            return oledbhelper.GetTable(com);
        }
       
        public static DataTable getByname(string name)
        {
            string com = "select * from  music where name='" + name + "'";
            return oledbhelper.GetTable(com);
        }
        public static DataTable getByganre(int num)
        {
            string com = "select * from music where ganre=" + num + "";
            return oledbhelper.GetTable(com);
        }
        public static int getIDbyname(string name)
        {
            string com = "select * FROM music WHERE musicName = '" + name + "'";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return (int) dr["ID"];
            }
            return 0;
        }
        public static int isexistbyname(string name)
        {
            string com = "select * FROM music WHERE musicName = '" + name + "'";

            DataTable dt = oledbhelper.GetTable(com);
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            return 0;
        }
        public static void removemusic(int id)
        {
            string com = "Delete from music where ID = " + id + "";
            oledbhelper.Execute(com);
        }
    }
}
