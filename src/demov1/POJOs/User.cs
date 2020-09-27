using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using demov1.DataUtilities;

namespace demov1.POJOs
{
    public class User
    {
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String type { get; set; }
        public String password { get; set; }
        public DateTime lastLogin { get; set; }

        bool loginStatus { get; set; }

        public User()
        {
  
        }

        public User(string name,string email,string password,string type)
        {
            this.id = -1;
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
            this.lastLogin = DateTime.Now;
        }

        public User(int id,string name, string email, string password, string type)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.type = type;
            this.lastLogin = DateTime.Now;
        }
        
        public static int authUser(String email, String password)
        {
            string sql = "SELECT * FROM  tb_user "
                + "WHERE UserEmail = @email "
                + "AND UserPassword  = @password";
             
            MySqlCommand cmd = new DbAgent().getAgent(sql);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            int uid = -1;
            if (reader.Read())
            {
                uid = (int)reader["UserId"];
            }

            reader.Close();
            return uid;
        }

        public static User getUser(int id)
        {
            string sql = "SELECT * FROM  tb_user "
                + "WHERE UserId = @id";

            MySqlCommand cmd = new DbAgent().getAgent(sql);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@id", id);

            User u = null;

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                u = new User((int)reader["UserId"], (string)reader["UserName"], (string)reader["UserEmail"], (string)reader["UserPassword"], (string)reader["UserType"]);
                u.lastLogin = (DateTime)reader["UserLastLogin"];
                u.loginStatus = true;
            }

            reader.Close();
            return u;
        }

        public static bool userEmailExists(string email)
        {
            string sql = "SELECT * FROM  tb_user "
                + "WHERE UserEmail = @email ";

            MySqlCommand cmd = new DbAgent().getAgent(sql);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }

            reader.Close();
            return false;
        }

        public int registerUser()
        {
            if (userEmailExists(this.email))
            {
                return 0;
            }

            string sql = "INSERT INTO tb_user (UserName,UserEmail,UserPassword,UserType) VALUES (@name,@email,@password,@type)";

            MySqlCommand cmd = new DbAgent().getAgent(sql);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@name", this.name);
            cmd.Parameters.AddWithValue("@email", this.email);
            cmd.Parameters.AddWithValue("@password", this.password);
            cmd.Parameters.AddWithValue("@type", this.type);

            int check = (int)cmd.ExecuteNonQuery();

            return check;           

        }
    }
}
