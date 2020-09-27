namespace demov1
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_panel = new System.Windows.Forms.Panel();
            this.login_msg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goto_reg = new System.Windows.Forms.LinkLabel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.login_email = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.login_password = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.reg_panel = new System.Windows.Forms.Panel();
            this.adminradio = new System.Windows.Forms.RadioButton();
            this.studentradio = new System.Windows.Forms.RadioButton();
            this.reg_msg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goto_login = new System.Windows.Forms.LinkLabel();
            this.reg_button = new System.Windows.Forms.Button();
            this.reg_password = new System.Windows.Forms.TextBox();
            this.reg_email = new System.Windows.Forms.TextBox();
            this.reg_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.reg_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.login_msg);
            this.login_panel.Controls.Add(this.label6);
            this.login_panel.Controls.Add(this.goto_reg);
            this.login_panel.Controls.Add(this.lbLogin);
            this.login_panel.Controls.Add(this.login_email);
            this.login_panel.Controls.Add(this.login_button);
            this.login_panel.Controls.Add(this.lbPassword);
            this.login_panel.Controls.Add(this.login_password);
            this.login_panel.Controls.Add(this.lbUsername);
            this.login_panel.Location = new System.Drawing.Point(516, 59);
            this.login_panel.Margin = new System.Windows.Forms.Padding(2);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(312, 387);
            this.login_panel.TabIndex = 6;
            this.login_panel.Visible = false;
            // 
            // login_msg
            // 
            this.login_msg.AutoSize = true;
            this.login_msg.BackColor = System.Drawing.Color.Transparent;
            this.login_msg.ForeColor = System.Drawing.Color.Red;
            this.login_msg.Location = new System.Drawing.Point(97, 20);
            this.login_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_msg.Name = "login_msg";
            this.login_msg.Size = new System.Drawing.Size(0, 13);
            this.login_msg.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(92, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Not a member?";
            // 
            // goto_reg
            // 
            this.goto_reg.AutoSize = true;
            this.goto_reg.Location = new System.Drawing.Point(175, 317);
            this.goto_reg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goto_reg.Name = "goto_reg";
            this.goto_reg.Size = new System.Drawing.Size(46, 13);
            this.goto_reg.TabIndex = 15;
            this.goto_reg.TabStop = true;
            this.goto_reg.Text = "Register";
            this.goto_reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goto_reg_LinkClicked);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(100, 33);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(97, 41);
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Login";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // login_email
            // 
            this.login_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.Location = new System.Drawing.Point(100, 144);
            this.login_email.Margin = new System.Windows.Forms.Padding(4);
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(138, 21);
            this.login_email.TabIndex = 1;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Black;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.Location = new System.Drawing.Point(121, 264);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(76, 23);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPassword.Location = new System.Drawing.Point(20, 202);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(82, 17);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // login_password
            // 
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(100, 201);
            this.login_password.Margin = new System.Windows.Forms.Padding(4);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(138, 21);
            this.login_password.TabIndex = 2;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbUsername.Location = new System.Drawing.Point(47, 146);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 18);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Email: ";
            // 
            // reg_panel
            // 
            this.reg_panel.Controls.Add(this.adminradio);
            this.reg_panel.Controls.Add(this.studentradio);
            this.reg_panel.Controls.Add(this.reg_msg);
            this.reg_panel.Controls.Add(this.label5);
            this.reg_panel.Controls.Add(this.goto_login);
            this.reg_panel.Controls.Add(this.reg_button);
            this.reg_panel.Controls.Add(this.reg_password);
            this.reg_panel.Controls.Add(this.reg_email);
            this.reg_panel.Controls.Add(this.reg_name);
            this.reg_panel.Controls.Add(this.label4);
            this.reg_panel.Controls.Add(this.label3);
            this.reg_panel.Controls.Add(this.label2);
            this.reg_panel.Controls.Add(this.label1);
            this.reg_panel.Location = new System.Drawing.Point(107, 59);
            this.reg_panel.Margin = new System.Windows.Forms.Padding(2);
            this.reg_panel.Name = "reg_panel";
            this.reg_panel.Size = new System.Drawing.Size(312, 387);
            this.reg_panel.TabIndex = 7;
            // 
            // adminradio
            // 
            this.adminradio.AutoSize = true;
            this.adminradio.Location = new System.Drawing.Point(160, 253);
            this.adminradio.Name = "adminradio";
            this.adminradio.Size = new System.Drawing.Size(53, 17);
            this.adminradio.TabIndex = 20;
            this.adminradio.Text = "admin";
            this.adminradio.UseVisualStyleBackColor = true;
            // 
            // studentradio
            // 
            this.studentradio.AutoSize = true;
            this.studentradio.Checked = true;
            this.studentradio.Location = new System.Drawing.Point(66, 253);
            this.studentradio.Name = "studentradio";
            this.studentradio.Size = new System.Drawing.Size(60, 17);
            this.studentradio.TabIndex = 19;
            this.studentradio.TabStop = true;
            this.studentradio.Text = "student";
            this.studentradio.UseVisualStyleBackColor = true;
            // 
            // reg_msg
            // 
            this.reg_msg.AutoSize = true;
            this.reg_msg.BackColor = System.Drawing.Color.Transparent;
            this.reg_msg.ForeColor = System.Drawing.Color.Red;
            this.reg_msg.Location = new System.Drawing.Point(121, 20);
            this.reg_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reg_msg.Name = "reg_msg";
            this.reg_msg.Size = new System.Drawing.Size(0, 13);
            this.reg_msg.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(82, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Already a member ?";
            // 
            // goto_login
            // 
            this.goto_login.AutoSize = true;
            this.goto_login.Location = new System.Drawing.Point(188, 357);
            this.goto_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goto_login.Name = "goto_login";
            this.goto_login.Size = new System.Drawing.Size(33, 13);
            this.goto_login.TabIndex = 14;
            this.goto_login.TabStop = true;
            this.goto_login.Text = "Login";
            this.goto_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goto_login_LinkClicked);
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.Black;
            this.reg_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reg_button.Location = new System.Drawing.Point(106, 307);
            this.reg_button.Margin = new System.Windows.Forms.Padding(2);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(76, 23);
            this.reg_button.TabIndex = 13;
            this.reg_button.Text = "Register";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // reg_password
            // 
            this.reg_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_password.Location = new System.Drawing.Point(106, 203);
            this.reg_password.Margin = new System.Windows.Forms.Padding(4);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(138, 21);
            this.reg_password.TabIndex = 12;
            // 
            // reg_email
            // 
            this.reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_email.Location = new System.Drawing.Point(106, 155);
            this.reg_email.Margin = new System.Windows.Forms.Padding(4);
            this.reg_email.Name = "reg_email";
            this.reg_email.Size = new System.Drawing.Size(138, 21);
            this.reg_email.TabIndex = 11;
            // 
            // reg_name
            // 
            this.reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_name.Location = new System.Drawing.Point(106, 108);
            this.reg_name.Margin = new System.Windows.Forms.Padding(4);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(138, 21);
            this.reg_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(49, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(22, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 26F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.reg_panel);
            this.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pariksha";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.reg_panel.ResumeLayout(false);
            this.reg_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox login_email;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel goto_reg;
        private System.Windows.Forms.Label login_msg;
        private System.Windows.Forms.Panel reg_panel;
        private System.Windows.Forms.Label reg_msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel goto_login;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.TextBox reg_password;
        private System.Windows.Forms.TextBox reg_email;
        private System.Windows.Forms.TextBox reg_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton studentradio;
        private System.Windows.Forms.RadioButton adminradio;
    }
}

