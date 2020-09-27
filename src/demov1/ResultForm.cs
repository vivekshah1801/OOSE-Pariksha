using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demov1.POJOs;

namespace demov1
{
    public partial class ResultForm : Form
    {
        User user { get; set; }
        Exam exam { get; set; }
        List<Question> qList { get; set; }
        List<QuestionStatus> qStatusList { get; set; }


        int total, correct, incorrect, notattempted;

        private void examBtn_Click(object sender, EventArgs e)
        {
            new HomeForm(user).Show();
            this.Hide();
        }

        public ResultForm(User user, Exam exam, List<Question> qList,List<QuestionStatus> qStatusList)
        {
            this.user = user;
            this.exam = exam;
            this.qList = qList;
            this.qStatusList = qStatusList;
            InitializeComponent();

            total = exam.qcount;
            for(int i=0;i<total;i++)
            {
                if (!qStatusList[i].attempted) { notattempted++; continue; }

                if (qStatusList[i].givenAns == qList[i].opCorrect)
                    correct++;
                else
                    incorrect++;
            }

            label1.Text = "Kudos " + user.name +
                "You Have Completed " + exam.name + " Successfully.";
            correctLabel.Text += correct.ToString() + " Out of " + total;
            incorrectLabel.Text += incorrect.ToString() + " Out of " + total;
            notAttemptedLabel.Text += notattempted.ToString() + " Out of " + total;
            resultLabel.Text += (correct*exam.marks).ToString() + "/" + total;

        }
    }
}
