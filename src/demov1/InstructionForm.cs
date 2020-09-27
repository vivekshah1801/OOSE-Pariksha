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
    public partial class InstructionForm : Form
    {
        public User user { get; set; }
        public Exam exam { get; set; }

        public InstructionForm(User user,Exam exam)
        {
            InitializeComponent();
            this.user = user;
            this.exam = exam;
            helloLabel.Text += user.name;
            examDetailsLabel.Text += exam.name;
            button1.Text += exam.code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamForm examForm = new ExamForm(user, exam);
            examForm.Show(); 
        }
    }
}
