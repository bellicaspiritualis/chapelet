using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Data.SQLite;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace chapelet
{


    public class DBConn
    {
        public static Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        public SqlConnection _con;
        public SqlCommand Cmd;
        public SqlDataAdapter _da;
        public DataTable _dt;

        public DBConn()
        {
            //string database_connection = "Data Source=Database\\modlitewnik.db;Version=3;";
            _con = new SqlConnection(@"Data Source=KOMP\SQLEXPRESS;Initial Catalog=modlitewnik;Integrated Security=True;Pooling=False");
            _con.Open();
        }

        public void SqlQuery(string queryText)
        {
            Cmd = new SqlCommand(queryText, _con);
        }

        public DataTable QueryEx()
        {
            _da = new SqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }
    }
}
