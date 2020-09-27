namespace demov1
{
    partial class HomeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.history_button = new System.Windows.Forms.Button();
            this.exam_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.homeLabel = new System.Windows.Forms.Label();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.userDataLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.examPanel = new System.Windows.Forms.Panel();
            this.examlistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.examPanel.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.history_button);
            this.panel1.Controls.Add(this.exam_button);
            this.panel1.Controls.Add(this.profile_button);
            this.panel1.Controls.Add(this.homeLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 64);
            this.panel1.TabIndex = 0;
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.history_button.Location = new System.Drawing.Point(889, 19);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(75, 23);
            this.history_button.TabIndex = 3;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // exam_button
            // 
            this.exam_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exam_button.Location = new System.Drawing.Point(793, 19);
            this.exam_button.Name = "exam_button";
            this.exam_button.Size = new System.Drawing.Size(75, 23);
            this.exam_button.TabIndex = 2;
            this.exam_button.Text = "Exams";
            this.exam_button.UseVisualStyleBackColor = false;
            this.exam_button.Click += new System.EventHandler(this.exam_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.profile_button.Location = new System.Drawing.Point(690, 19);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(75, 23);
            this.profile_button.TabIndex = 1;
            this.profile_button.Text = "Profile";
            this.profile_button.UseVisualStyleBackColor = false;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(23, 19);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(66, 25);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Hello, ";
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.userDataLabel);
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Location = new System.Drawing.Point(12, 70);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(227, 408);
            this.profilePanel.TabIndex = 1;
            // 
            // userDataLabel
            // 
            this.userDataLabel.AutoSize = true;
            this.userDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDataLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.userDataLabel.Location = new System.Drawing.Point(12, 61);
            this.userDataLabel.Name = "userDataLabel";
            this.userDataLabel.Size = new System.Drawing.Size(60, 24);
            this.userDataLabel.TabIndex = 1;
            this.userDataLabel.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // examPanel
            // 
            this.examPanel.Controls.Add(this.examlistview);
            this.examPanel.Controls.Add(this.label2);
            this.examPanel.Location = new System.Drawing.Point(245, 71);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(407, 408);
            this.examPanel.TabIndex = 2;
            // 
            // examlistview
            // 
            this.examlistview.CheckBoxes = true;
            this.examlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.examlistview.Location = new System.Drawing.Point(8, 46);
            this.examlistview.MultiSelect = false;
            this.examlistview.Name = "examlistview";
            this.examlistview.Size = new System.Drawing.Size(396, 315);
            this.examlistview.TabIndex = 1;
            this.examlistview.UseCompatibleStateImageBehavior = false;
            this.examlistview.View = System.Windows.Forms.View.Details;
            this.examlistview.Click += new System.EventHandler(this.examlistview_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exam Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Exam Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Exams";
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.label3);
            this.historyPanel.Location = new System.Drawing.Point(671, 70);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(306, 408);
            this.historyPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "History";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(989, 491);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.examPanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.examPanel.ResumeLayout(false);
            this.examPanel.PerformLayout();
            this.historyPanel.ResumeLayout(false);
            this.historyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button exam_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel examPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userDataLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView examlistview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}