using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using demov1.DataUtilities;

namespace demov1.POJOs
{
    public class Question
    {
        public int id { get; set; }
        public string q { get; set; }

        public string op1 { get; set; }
        public string op2 { get; set; }
        public string op3 { get; set; }
        public string op4 { get; set; }
        public string opCorrect { get; set; }

        public int eid { get; set; }

        public Question(string q,string op1, string op2, string op3, string op4, string opCorrect,int eid)
        {
            this.q = q;
            this.op1 = op1;
            this.op2 = op2;
            this.op3 = op3;
            this.op4 = op4;
            this.opCorrect = opCorrect;
            this.eid = eid;
        }

        public Question(int id,string q, string op1, string op2, string op3, string op4, string opCorrect, int eid)
        {
            this.id = id;
            this.q = q;
            this.op1 = op1;
            this.op2 = op2;
            this.op3 = op3;
            this.op4 = op4;
            this.opCorrect = opCorrect;
            this.eid = eid;
        }

        public Question()
        {

        }

        public static List<Question> getQuestions(Exam exam)
        {
            List<Question> qlist = new List<Question>();
            string sql = "SELECT * FROM question WHERE examid=@eid";

            MySqlCommand cmd = new DbAgent().getAgent(sql);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@eid", exam.id);

            MySqlDataReader reader = cmd.ExecuteReader();

            Question q;
            while (reader.Read())
            {
                q = new Question((int)reader["id"], (string)reader["q"], (string)reader["op1"], (string)reader["op2"], (string)reader["op3"], (string)reader["op4"], (string)reader["opCorrect"], (int)exam.id);
                qlist.Add(q);
            }

            reader.Close();
            return qlist;
        }
    }
}
