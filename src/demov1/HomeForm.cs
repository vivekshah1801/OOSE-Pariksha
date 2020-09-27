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
    public partial class HomeForm : Form
    {
        User user { get; set; }
        string state { get; set; }

        public HomeForm(User u)
        {
            InitializeComponent();
            Console.WriteLine("Home Form Loaded");
            state = "exam";
            toggleState("exam");
            user = u;
            homeLabel.Text += u.name;

            userDataLabel.Text = "Username : " + u.name + "\nUser Email Id: " + u.email;
            examlistview.Columns.Add("Exam name",100);
            List<Exam> examlist = Exam.getExams();
            foreach (var exam in examlist)
            { 
                string[] arr = new string[2];
                arr[0] = exam.name;
                arr[1] = exam.code;
                var listViewItem = new ListViewItem(arr);

                listViewItem.Tag = exam;
                examlistview.Items.Add(listViewItem);
                Console.WriteLine("Got Exams");
            }
        }


        

        private void toggleState(string state)
        {
            if(state=="profile")
            {
                examPanel.Visible = false;
                historyPanel.Visible = false;
                profilePanel.Visible = true;
            }
            else if(state=="exam")
            {
                examPanel.Visible = true;
                historyPanel.Visible = false;
                profilePanel.Visible = false;
            }
            else if(state=="history")
            {
                examPanel.Visible = false;
                historyPanel.Visible = true;
                profilePanel.Visible = false;
            }
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            toggleState("profile");
        }

        private void exam_button_Click(object sender, EventArgs e)
        {
            toggleState("exam");
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            toggleState("history");
        }


        private void examlistview_Click(object sender, EventArgs e)
        {
            if (examlistview.SelectedItems == null || examlistview.SelectedItems.Count == 0)
            {
                return;
            }
            var optedExam = (Exam)examlistview.SelectedItems[0].Tag;
            if (optedExam != null)
            {
                examlistview.SelectedItems.Clear();
                this.Hide();
                InstructionForm instructionform = new InstructionForm(user, optedExam);
                instructionform.Show();
            }
        }
    }
}
