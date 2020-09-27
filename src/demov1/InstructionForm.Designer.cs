namespace demov1
{
    partial class InstructionForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.examDetailsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(333, 94);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(74, 26);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello, ";
            // 
            // examDetailsLabel
            // 
            this.examDetailsLabel.AutoSize = true;
            this.examDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examDetailsLabel.Location = new System.Drawing.Point(264, 214);
            this.examDetailsLabel.Name = "examDetailsLabel";
            this.examDetailsLabel.Size = new System.Drawing.Size(226, 26);
            this.examDetailsLabel.TabIndex = 1;
            this.examDetailsLabel.Text = "You are about to take ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(338, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enroll Now For ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(961, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.examDetailsLabel);
            this.Controls.Add(this.helloLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label examDetailsLabel;
        private System.Windows.Forms.Button button1;
    }
}