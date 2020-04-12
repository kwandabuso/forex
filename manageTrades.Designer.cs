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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbUpdateStatus = new System.Windows.Forms.ComboBox();
            this.cmbProfitOrLoss = new System.Windows.Forms.ComboBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.es = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblProfits = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllTrades
            // 
            this.dgvAllTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvAllTrades.Location = new System.Drawing.Point(36, 102);
            this.dgvAllTrades.Name = "dgvAllTrades";
            this.dgvAllTrades.ReadOnly = true;
            this.dgvAllTrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllTrades.Size = new System.Drawing.Size(744, 155);
            this.dgvAllTrades.TabIndex = 3;
            this.dgvAllTrades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllTrades_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTrades
            // 
            this.cmbTrades.FormattingEnabled = true;
            this.cmbTrades.Items.AddRange(new object[] {
            "All",
            "Open",
            "Closed",
            "Profit",
            "Loss",
            "Buy",
            "Sell",
            "Null"});
            this.cmbTrades.Location = new System.Drawing.Point(40, 12);
            this.cmbTrades.Name = "cmbTrades";
            this.cmbTrades.Size = new System.Drawing.Size(121, 21);
            this.cmbTrades.TabIndex = 0;
            this.cmbTrades.SelectedIndexChanged += new System.EventHandler(this.cmbTrades_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(99, 64);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Location = new System.Drawing.Point(439, 64);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(200, 20);
            this.dtpEnddate.TabIndex = 2;
            this.dtpEnddate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FROM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Profit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Profit/Loss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(718, 286);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 14;
            // 
            // cmbUpdateStatus
            // 
            this.cmbUpdateStatus.FormattingEnabled = true;
            this.cmbUpdateStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cmbUpdateStatus.Location = new System.Drawing.Point(214, 283);
            this.cmbUpdateStatus.Name = "cmbUpdateStatus";
            this.cmbUpdateStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateStatus.TabIndex = 15;
            // 
            // cmbProfitOrLoss
            // 
            this.cmbProfitOrLoss.FormattingEnabled = true;
            this.cmbProfitOrLoss.Items.AddRange(new object[] {
            "Loss",
            "Profit",
            "Null"});
            this.cmbProfitOrLoss.Location = new System.Drawing.Point(214, 329);
            this.cmbProfitOrLoss.Name = "cmbProfitOrLoss";
            this.cmbProfitOrLoss.Size = new System.Drawing.Size(121, 21);
            this.cmbProfitOrLoss.TabIndex = 16;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(214, 362);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(100, 20);
            this.txtProfit.TabIndex = 6;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(214, 403);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(289, 70);
            this.txtNotes.TabIndex = 17;
            // 
            // es
            // 
            this.es.AutoSize = true;
            this.es.Location = new System.Drawing.Point(35, 410);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(63, 13);
            this.es.TabIndex = 18;
            this.es.Text = "Post Motem";
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Location = new System.Drawing.Point(637, 313);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(35, 13);
            this.lblLoss.TabIndex = 19;
            this.lblLoss.Text = "LOSS";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(637, 344);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(46, 13);
            this.lblProfit.TabIndex = 20;
            this.lblProfit.Text = "PROFIT";
            // 
            // lblProfits
            // 
            this.lblProfits.AutoSize = true;
            this.lblProfits.Location = new System.Drawing.Point(718, 344);
            this.lblProfits.Name = "lblProfits";
            this.lblProfits.Size = new System.Drawing.Size(0, 13);
            this.lblProfits.TabIndex = 21;
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(718, 313);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(0, 13);
            this.lblLosses.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manageTrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblProfits);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.es);
            this.Controls.Add(this.cmbProfitOrLoss);
            this.Controls.Add(this.cmbUpdateStatus);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnddate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cmbTrades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAllTrades);
            this.Name = "manageTrades";
            this.Text = "Manage Trades";
            this.Load += new System.EventHandler(this.manageTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllTrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllTrades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTrades;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnddate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbUpdateStatus;
        private System.Windows.Forms.ComboBox cmbProfitOrLoss;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label es;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblProfits;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Button button2;
    }
}