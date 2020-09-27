using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demov1.DataUtilities;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace demov1.POJOs
{
    public class Exam
    {
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int qcount { get; set; }
        public int duration { get; set; }
        public int marks { get; set; }
        public int negativemarks { get; set; }
        public bool isActive { get; set; }
        public User creator { get; set; }
        public DateTime starttime { get; set; }
        public DateTime endtime { get; set; }

        Exam(int id,string name,string code,string description,int qcount,int duration, int marks,int negativemarks,User user,DateTime starttime,DateTime endtime)
        {
            this.id = id;
            this.name = name;
            this.code = code;
            this.description = description;
            this.qcount = qcount;
            this.duration = duration;
            this.marks = marks;
            this.negativemarks = negativemarks;
            this.creator = user;
            this.starttime = starttime;
            this.endtime = endtime;
        }
        
        public static List<Exam> getExams()
        {
            List<Exam> examlist = new List<Exam>();
            string sql = "SELECT * FROM exam";
            MySqlDataReader reader =  new DbAgent().getAgent(sql).ExecuteReader();

            Exam e;
            while (reader.Read())
            {
                e = new Exam((int)reader["id"],(string)reader["name"],(string)reader["code"],(string)reader["description"],
                        (int)reader["qcount"], (int)reader["duration"], (int)reader["marks"], (int)reader["negativemarks"], null,(DateTime)reader["starttime"], (DateTime)reader["endtime"]);
                examlist.Add(e);
            }

            reader.Close();
            return examlist;
        }

        


        public override string ToString()
        {   
            return this.name + "| id: " + this.id + "\n";
        }


    }


}
