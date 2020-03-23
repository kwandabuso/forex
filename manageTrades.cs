using Amazon.CognitoSync.Model;
using forex.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace forex
{
    public partial class manageTrades : Form
    {
        public manageTrades()
        {
            InitializeComponent();
        }
        private DataTable DT = new DataTable();
        DAL dAL = new DAL();
        string ID = "";

        private void manageTrades_Load(object sender, EventArgs e)
        {
            
            DT = dAL.ReadAllData();

            dgvAllTrades.DataSource = DT;


            lblTotal.Text = "$"+dAL.ReadSumOfProfits();

        }

        private void cmbTrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT = new DataTable();
            DAL dAL = new DAL();

            if(cmbTrades.Text.Equals("All"))
            {
                DT = dAL.ReadAllData();
            }
            else
                DT = dAL.ReadDataOnSelectedText(cmbTrades.Text);




            dgvAllTrades.DataSource = DT;
        }

        private void update(string ID, string Decision, string ReasonClosed,string amount)
        {
            
            dAL.UpdatePostgresData(ID, Decision, ReasonClosed, amount);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtStatus.Text.Equals(""))
            {
                MessageBox.Show("please enter status!!");
            }
            else if (txtReason.Text.Equals(""))
            {
                MessageBox.Show("please enter reason!!");
            }
            else if (txtProfit.Text.Equals(""))
            {
                MessageBox.Show("please enter Profit!!");
            }
            else
            {
                update(ID, txtStatus.Text, txtReason.Text, txtProfit.Text);
                txtStatus.Text = "";
                txtReason.Text = "";
                txtProfit.Text = "";
            }


            DT = dAL.ReadAllData();

            dgvAllTrades.DataSource = DT;

        }

        private void dgvAllTrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvAllTrades.CurrentRow.Index;
            ID = dgvAllTrades.Rows[row].Cells[6].Value.ToString();
            string Decision = dgvAllTrades.Rows[row].Cells[2].Value.ToString();
            string ReasonClosed = dgvAllTrades.Rows[row].Cells[4].Value.ToString();
            string amount = dgvAllTrades.Rows[row].Cells[5].Value.ToString();


            txtStatus.Text = Decision;
            txtReason.Text = ReasonClosed;
            txtProfit.Text = amount;
        }
    } 
    
}
