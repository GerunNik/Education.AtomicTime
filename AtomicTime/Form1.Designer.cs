namespace AtomicTime
{
    partial class Form1
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
            this.showTime_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showTime_txt
            // 
            this.showTime_txt.AutoSize = true;
            this.showTime_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.showTime_txt.Location = new System.Drawing.Point(71, 61);
            this.showTime_txt.Name = "showTime_txt";
            this.showTime_txt.Size = new System.Drawing.Size(200, 76);
            this.showTime_txt.TabIndex = 0;
            this.showTime_txt.Text = "24:00";
            this.showTime_txt.TextChanged += new System.EventHandler(this.showTime_txt_TextChanged);
            this.showTime_txt.Click += new System.EventHandler(this.showTime_txt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showTime_txt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showTime_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showTime_txt;
        private System.Windows.Forms.Button button1;
    }
}

