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
using System.Diagnostics;

namespace demov1
{
    public partial class WelcomeForm : Form
    {
        
        string state = "login";

        public WelcomeForm()
        {
            InitializeComponent();
            Console.WriteLine("Welcome Form loaded");
            toggleState("login");
        }

        private void toggleState(string state)
        {
            if(state == "login")
            {
                login_email.Text = "";
                login_password.Text = "";
                login_panel.Visible = true;
                reg_panel.Visible = false;
                this.state = state;
                return;
            }
            else if(state=="register")
            {
                login_panel.Visible = false;
                reg_panel.Visible = true;
                reg_name.Text = "";
                reg_email.Text = "";
                reg_password.Text = "";

                this.state = state;
                return;
            }
            return;
        }

        private void goto_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toggleState("register");
        }

        private void goto_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            toggleState("login");
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(reg_name.Text) ||
                    String.IsNullOrEmpty(reg_email.Text) ||
                    String.IsNullOrEmpty(reg_password.Text))
            {
                reg_msg.Text = "Please provide all neccessary details";
                Console.WriteLine("Fill all details");
                return;
            }

            string name = reg_name.Text;
            string email = reg_email.Text;
            string password = reg_password.Text;
            string type = "student";
            if (adminradio.Checked)
                type = "admin";


            User u = new User(name, email, password, type);
            int check = u.registerUser();

            if (check == 0)
            {
                reg_msg.Text = "Email already in use. Wanna login?";  
            }
            else if(check==1)
            {
                toggleState("login");
                login_msg.Text = "User registered succcessfully. Login now.";   
            }
            else
            {
                reg_msg.Text = "Error.";

            }
            return;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //comment out in production
            Form homeForm = new HomeForm(User.getUser(1));
            homeForm.Show();
            return;
            //testing over

            if (String.IsNullOrEmpty(login_email.Text) ||
                    String.IsNullOrEmpty(login_password.Text))
            {
                login_msg.Text = "Please provide all neccessary details";
                return;
            }

            string email = login_email.Text;
            string password = login_password.Text;
            
            if(!User.userEmailExists(email))
            {
                login_msg.Text = "Email is not registered. Wanna register?";
                return;
            }

            int uid = User.authUser(email, password);
            
            Console.Write(uid);
            if(uid == -1)
            {
                login_msg.Text = "Invalid Credentials.";
                return;
            }
            else if(uid>0)
            {
                User u = User.getUser(uid);
                //Form homeForm = new HomeForm(u);
                homeForm.Show();
                Console.WriteLine("Hello" + u.email + u.name);

                return;
            }
        }
    }
}
