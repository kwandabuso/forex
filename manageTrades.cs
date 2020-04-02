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
                DT = dAL.ReadDataOnSelectedText(cmbTrades.Text.ToUpper());




            dgvAllTrades.DataSource = DT;
        }

        private void update(string ID, string Decision, string ReasonClosed,string amount, string Postmotem)
        {
            try
            {
                dAL.UpdatePostgresData(ID, Decision, ReasonClosed, amount, Postmotem);
            }
            catch(Exception ex)
            {

            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUpdateStatus.Text.Equals(""))
            {
                MessageBox.Show("please enter status!!");
            }
            else if (cmbProfitOrLoss.Text.Equals(""))
            {
                MessageBox.Show("please enter reason!!");
            }
            else if (txtProfit.Text.Equals(""))
            {
                MessageBox.Show("please enter Profit!!");
            }
            else if(txtNotes.Text.Equals(""))
            {
                MessageBox.Show("please enter POST MOTEM notes!!");
            }
            else
            {
                ManageTrades MT = new ManageTrades(cmbUpdateStatus.Text.ToUpper(), cmbProfitOrLoss.Text.ToUpper(), txtProfit.Text, txtNotes.Text);

                update(ID, MT.Status, MT.ProfitLoss, MT.Amount, MT.PMotem);
                cmbUpdateStatus.Text = "";
                cmbProfitOrLoss.Text = "";
                txtProfit.Text = "";
                txtNotes.Text = "";
            }


            DT = dAL.ReadAllData();

            dgvAllTrades.DataSource = DT;

            lblTotal.Text = "$" + dAL.ReadSumOfProfits();
        }

        private void dgvAllTrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvAllTrades.CurrentRow.Index;
            ID = dgvAllTrades.Rows[row].Cells[0].Value.ToString();
            string Decision = dgvAllTrades.Rows[row].Cells[4].Value.ToString();
            string ReasonClosed = dgvAllTrades.Rows[row].Cells[5].Value.ToString();
            string amount = dgvAllTrades.Rows[row].Cells[6].Value.ToString();
            string post = dgvAllTrades.Rows[row].Cells[7].Value.ToString();

            cmbUpdateStatus.Text = Decision;
            cmbProfitOrLoss.Text = ReasonClosed;
            txtProfit.Text = amount;
            txtNotes.Text = post;
        }

       
    } 
    
}
