namespace demov1
{
    partial class ExamForm
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.eName = new System.Windows.Forms.Label();
            this.timeCountdown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qPanel = new System.Windows.Forms.Panel();
            this.finishBtn = new System.Windows.Forms.Button();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.op4 = new System.Windows.Forms.RadioButton();
            this.op3 = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.qText = new System.Windows.Forms.Label();
            this.qNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.qPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.eName);
            this.headerPanel.Controls.Add(this.timeCountdown);
            this.headerPanel.Controls.Add(this.label3);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1323, 57);
            this.headerPanel.TabIndex = 0;
            // 
            // eName
            // 
            this.eName.AutoSize = true;
            this.eName.Location = new System.Drawing.Point(16, 22);
            this.eName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(73, 17);
            this.eName.TabIndex = 2;
            this.eName.Text = "NIS Sess1";
            // 
            // timeCountdown
            // 
            this.timeCountdown.AutoSize = true;
            this.timeCountdown.Location = new System.Drawing.Point(1209, 22);
            this.timeCountdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeCountdown.Name = "timeCountdown";
            this.timeCountdown.Size = new System.Drawing.Size(44, 17);
            this.timeCountdown.TabIndex = 1;
            this.timeCountdown.Text = "10:50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1089, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Remaining";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 556);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 54);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1169, 15);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1233, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Jump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: 60 Ques | Attempted: 50 | Current : 5/60";
            // 
            // qPanel
            // 
            this.qPanel.Controls.Add(this.finishBtn);
            this.qPanel.Controls.Add(this.op1);
            this.qPanel.Controls.Add(this.label4);
            this.qPanel.Controls.Add(this.op4);
            this.qPanel.Controls.Add(this.op3);
            this.qPanel.Controls.Add(this.op2);
            this.qPanel.Controls.Add(this.qText);
            this.qPanel.Controls.Add(this.qNo);
            this.qPanel.Controls.Add(this.label2);
            this.qPanel.Location = new System.Drawing.Point(64, 65);
            this.qPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qPanel.Name = "qPanel";
            this.qPanel.Size = new System.Drawing.Size(1195, 468);
            this.qPanel.TabIndex = 2;
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(1036, 407);
            this.finishBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(100, 28);
            this.finishBtn.TabIndex = 9;
            this.finishBtn.Text = "Finish Exam";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Visible = false;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Location = new System.Drawing.Point(39, 182);
            this.op1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(116, 21);
            this.op1.TabIndex = 8;
            this.op1.TabStop = true;
            this.op1.Text = "Rahul Gandhi";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.option_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "You answered: ";
            // 
            // op4
            // 
            this.op4.AutoSize = true;
            this.op4.Location = new System.Drawing.Point(41, 308);
            this.op4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(128, 21);
            this.op4.TabIndex = 6;
            this.op4.TabStop = true;
            this.op4.Text = "Yogi Adityanath";
            this.op4.UseVisualStyleBackColor = true;
            this.op4.Click += new System.EventHandler(this.option_Click);
            // 
            // op3
            // 
            this.op3.AutoSize = true;
            this.op3.Location = new System.Drawing.Point(41, 263);
            this.op3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(93, 21);
            this.op3.TabIndex = 5;
            this.op3.TabStop = true;
            this.op3.Text = "Amit Shah";
            this.op3.UseVisualStyleBackColor = true;
            this.op3.Click += new System.EventHandler(this.option_Click);
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(41, 223);
            this.op2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(116, 21);
            this.op2.TabIndex = 4;
            this.op2.TabStop = true;
            this.op2.Text = "Rahul Gandhi";
            this.op2.UseVisualStyleBackColor = true;
            this.op2.Click += new System.EventHandler(this.option_Click);
            // 
            // qText
            // 
            this.qText.AutoSize = true;
            this.qText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qText.Location = new System.Drawing.Point(32, 71);
            this.qText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qText.Name = "qText";
            this.qText.Size = new System.Drawing.Size(204, 31);
            this.qText.TabIndex = 2;
            this.qText.Text = "Who is our PM?";
            // 
            // qNo
            // 
            this.qNo.AutoSize = true;
            this.qNo.Location = new System.Drawing.Point(120, 38);
            this.qNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qNo.Name = "qNo";
            this.qNo.Size = new System.Drawing.Size(16, 17);
            this.qNo.TabIndex = 1;
            this.qNo.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question: ";
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(17, 281);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(39, 28);
            this.prevButton.TabIndex = 3;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(1268, 281);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(39, 28);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 612);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.qPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.qPanel.ResumeLayout(false);
            this.qPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label eName;
        private System.Windows.Forms.Label timeCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel qPanel;
        private System.Windows.Forms.RadioButton op4;
        private System.Windows.Forms.RadioButton op3;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.Label qText;
        private System.Windows.Forms.Label qNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton op1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button finishBtn;
    }
}