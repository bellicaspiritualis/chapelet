using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace chapelet
{
    class DBConn
    {
        //public static string db_conn = "Data Source=modlitewnik.db;Version=3";
        public static string db_conn = "Data Source=" + Path.GetFullPath("Database/modlitewnik.db") +"; Version=3";
    }
}
