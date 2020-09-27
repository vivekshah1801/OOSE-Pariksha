namespace demov1
{
    partial class ResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.notAttemptedLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.examBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kudos Vivek, You completed NIS Exam.";
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.Location = new System.Drawing.Point(409, 250);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(55, 13);
            this.incorrectLabel.TabIndex = 1;
            this.incorrectLabel.Text = "Incorrect: ";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(48, 250);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(47, 13);
            this.correctLabel.TabIndex = 2;
            this.correctLabel.Text = "Correct: ";
            // 
            // notAttemptedLabel
            // 
            this.notAttemptedLabel.AutoSize = true;
            this.notAttemptedLabel.Location = new System.Drawing.Point(722, 250);
            this.notAttemptedLabel.Name = "notAttemptedLabel";
            this.notAttemptedLabel.Size = new System.Drawing.Size(81, 13);
            this.notAttemptedLabel.TabIndex = 3;
            this.notAttemptedLabel.Text = "Not Attempted: ";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(527, 412);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // examBtn
            // 
            this.examBtn.Location = new System.Drawing.Point(345, 412);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(75, 23);
            this.examBtn.TabIndex = 5;
            this.examBtn.Text = "Take Another Exam";
            this.examBtn.UseVisualStyleBackColor = true;
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(412, 323);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result: ";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 485);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.examBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.notAttemptedLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.label1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label notAttemptedLabel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button examBtn;
        private System.Windows.Forms.Label resultLabel;
    }
}