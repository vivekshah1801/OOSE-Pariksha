using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace demov1.DataUtilities
{
    class DbConnection
    {
        static MySqlConnection con = null;
        DbConnection()
        {

        }

        //singleton pattern
        public static MySqlConnection getInstance()
        {
            if(con==null)
            {
                init();
            }
            return con; 
        }

        static void init()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            con = new MySqlConnection(ConString);
            con.Open();
            Console.WriteLine("Db Connected");
        }
    }

    public class DbAgent
    {
        MySqlCommand cmd { get; set; }

        public DbAgent()
        {
            cmd = new MySqlCommand();
            cmd.Connection = DbConnection.getInstance();
        }

        public MySqlCommand getAgent(string sql)
        {
            this.cmd.CommandText = sql;
            return this.cmd;
        }

    }
}
