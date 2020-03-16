namespace forex
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rdoRunOnLive = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Place Trades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Trades";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Trades";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdoRunOnLive
            // 
            this.rdoRunOnLive.AutoSize = true;
            this.rdoRunOnLive.Location = new System.Drawing.Point(536, 39);
            this.rdoRunOnLive.Name = "rdoRunOnLive";
            this.rdoRunOnLive.Size = new System.Drawing.Size(97, 17);
            this.rdoRunOnLive.TabIndex = 3;
            this.rdoRunOnLive.TabStop = true;
            this.rdoRunOnLive.Text = "Run On LIVE!!!";
            this.rdoRunOnLive.UseVisualStyleBackColor = true;
            this.rdoRunOnLive.CheckedChanged += new System.EventHandler(this.rdoRunOnLive_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdoRunOnLive);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdoRunOnLive;
    }
}