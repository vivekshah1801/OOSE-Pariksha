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
    public partial class ExamForm : Form
    {
        public User user { get; set; }
        public Exam exam { get; set; }
        public ExamStatus examStatus { get; set; }
        public List<QuestionStatus> qStatusList {get;set;}
        public List<Question> qList { get; set; }
        public int i = 0;
        public int seconds { get; set; }

        public ExamForm(User user, Exam exam)
        {
            InitializeComponent();
            this.i = 0;
            this.user = user;
            this.exam = exam;
            this.examStatus = new ExamStatus(exam);
            this.qList = Question.getQuestions(exam);
            this.exam.qcount = qList.Count;


            this.exam.duration = 1;

            this.seconds = this.exam.duration * 60;
            Console.WriteLine("This Exam has" + qList.Count + "Questions.");
            qStatusList = new List<QuestionStatus>();
            for (int x=0;x<this.exam.qcount;x++)
            {
                qStatusList.Add(new QuestionStatus());
            }

            eName.Text = exam.name;
            showQuestion(this.i);
            
            timer1.Start();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.i++;
            showQuestion(i);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            this.i--;
            showQuestion(i);
        }

        public void showQuestion(int i)
        {
            qNo.Text = (i + 1).ToString();
            qText.Text = qList[i].q;
            op1.Text = qList[i].op1;
            op2.Text = qList[i].op2;
            op3.Text = qList[i].op3;
            op4.Text = qList[i].op4;
            numericUpDown1.Value = i+1;

            op1.Checked = op2.Checked = op3.Checked = op4.Checked = false;

            
            if(qStatusList[i].attempted)
            {
                label4.Text = "You Answered: " + qStatusList[i].givenAns;

                if (qStatusList[i].givenAns == op1.Text)
                    op1.Checked = true;
                else if (qStatusList[i].givenAns == op2.Text)
                    op2.Checked = true;
                else if (qStatusList[i].givenAns == op3.Text)
                    op3.Checked = true;
                else if (qStatusList[i].givenAns == op4.Text)
                    op4.Checked = true;
            }
            else label4.Text = "";

            if (this.i == this.exam.qcount-1)
                finishBtn.Visible = true;
            else
                finishBtn.Visible = false;
            
            setFooter(i);
            setButtons(i);
        }

        public void setFooter(int i)
        {
            label1.Text = "Total : " + this.exam.qcount + " Questions\t" +
                "  |  Attempted : " + this.examStatus.attempted + " Questions\t" ;
        }

        public void setButtons(int i)
        {
            if (i > 0) prevButton.Enabled = true;
            else prevButton.Enabled = false;

            if (i < this.exam.qcount-1) nextButton.Enabled = true;
            else nextButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = (int)numericUpDown1.Value;
            if(val>0 && val<=this.exam.qcount)
            {
                this.i = val-1;
                showQuestion(this.i);
            }
            else
                numericUpDown1.Value = i + 1;
        }

        private void option_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(qStatusList[i].attempted)
            {
                if(qStatusList[i].givenAns == rb.Text)
                {
                    rb.Checked = false;
                    qStatusList[i].attempted = false;
                    qStatusList[i].givenAns = "";
                    this.examStatus.attempted--;
                    label4.Text = "";
                    setFooter(i);
                }
                else
                {

                    qStatusList[i].givenAns = rb.Text;
                    label4.Text = "You Answered: " + qStatusList[i].givenAns;
                }
            }
            else
            {
                qStatusList[i].attempted = true;
                qStatusList[i].givenAns = rb.Text;
                this.examStatus.attempted++;
                label4.Text = "You Answered: " + qStatusList[i].givenAns;
                setFooter(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.seconds--;
            Console.WriteLine(this.seconds);
            if(this.seconds<0)
            {
                timer1.Stop();
                finishBtn_Click(null,null);
                MessageBox.Show(this.seconds.ToString());
            }
            TimeSpan ts = TimeSpan.FromMinutes(this.seconds);
            timeCountdown.Text = ts.ToString();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            new ResultForm(user,exam,qList, qStatusList).Show();
            this.Hide();
        }
    }


    public class ExamStatus
    {
        public int attempted { get; set; }
        public int total { get; set; }
        public int current { get; set; }
        public Exam e { get; set; }
        
        public ExamStatus(Exam e)
        {
            this.attempted = 0;
            this.current = 1;
        }
    }

    public class QuestionStatus
    {
        public QuestionStatus()
        {
            this.attempted = false;
            this.givenAns = null;
        }

        public bool attempted { get; set; }
        public string givenAns { get; set; }
    }
}
