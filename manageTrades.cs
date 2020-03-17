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


        private void manageTrades_Load(object sender, EventArgs e)
        {
            
            DT = dAL.CreateConn();

            dgvAllTrades.DataSource = DT;
        }

        private void cmbTrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT = new DataTable();
            DAL dAL = new DAL();
            DT = dAL.ReadStatusData(cmbTrades.Text);

            dgvAllTrades.DataSource = DT;
        }
        private void update()
        {
            int row = dgvAllTrades.CurrentRow.Index;
            string ID = dgvAllTrades.Rows[row].Cells[0].Value.ToString();
            string Decision= dgvAllTrades.Rows[row].Cells[3].Value.ToString();
            string profit = dgvAllTrades.Rows[row].Cells[4].Value.ToString();
            string amount = dgvAllTrades.Rows[row].Cells[5].Value.ToString();

            dAL.udpateRecords(ID, Decision, profit, amount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgvAllTrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    } 
    
}
