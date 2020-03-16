namespace forex
{
    partial class manageTrades
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
            this.dgvAllTrades = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTrades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTrades
            // 
            this.dgvAllTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvAllTrades.Location = new System.Drawing.Point(36, 74);
            this.dgvAllTrades.Name = "dgvAllTrades";
            this.dgvAllTrades.Size = new System.Drawing.Size(744, 155);
            this.dgvAllTrades.TabIndex = 0;
            this.dgvAllTrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllTrades_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTrades
            // 
            this.cmbTrades.FormattingEnabled = true;
            this.cmbTrades.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Profit",
            "Loss"});
            this.cmbTrades.Location = new System.Drawing.Point(36, 29);
            this.cmbTrades.Name = "cmbTrades";
            this.cmbTrades.Size = new System.Drawing.Size(121, 21);
            this.cmbTrades.TabIndex = 2;
            this.cmbTrades.SelectedIndexChanged += new System.EventHandler(this.cmbTrades_SelectedIndexChanged);
            // 
            // manageTrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 469);
            this.Controls.Add(this.cmbTrades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAllTrades);
            this.Name = "manageTrades";
            this.Text = "manageTrades";
            this.Load += new System.EventHandler(this.manageTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTrades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTrades;
    }
}