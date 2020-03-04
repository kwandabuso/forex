using forex.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forex
{
    public partial class DisplayTrades : Form
    {
        public DisplayTrades()
        {
            InitializeComponent();
        }
        engine en = new engine();
        private void DisplayTrades_Load(object sender, EventArgs e)
        {
            var trades = new List<string>();
            GlobalVariables.TradesDecisions = @"C:\kwanda\forex\Files\Status.txt";
            trades = en.ReadFile(GlobalVariables.TradesDecisions, "");


            foreach (var trs in trades)
            {
                cmbFilter.Items.Add(trs);
            }
            read();
        }
        public Boolean read()
        {
            var trades = new List<string>();
            engine en = new engine();
            GlobalVariables.TradesPath = @"C:\kwanda\forex\Files\Trades.txt";
            trades = en.ReadFile(GlobalVariables.TradesPath, "");

            for (int j = 0; j < trades.Count; j++)
            {
                var addToGrid = new List<string>();
                addToGrid = trades[j].Split('|').ToList();

                var rowIndex = dataGridView1.Rows.Add();

                for (int i = 0; i < addToGrid.Count; i++)
                {
                    if(!addToGrid[i].Equals(""))
                    {
                        dataGridView1.Rows[rowIndex].Cells[i].Value = addToGrid[i];
                    }
                    
                }
            }



               
           

            return true;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trades = new List<string>();
            engine en = new engine();
            GlobalVariables.TradesPath = @"C:\kwanda\forex\Files\trades.txt";

            trades = en.ReadFile(GlobalVariables.TradesPath, cmbFilter.Text);
            dataGridView1.Rows.Clear();
            for (int j = 0; j < trades.Count; j++)
            {
                var addToGrid = new List<string>();
                addToGrid = trades[j].Split('|').ToList();

                var rowIndex = dataGridView1.Rows.Add();

                for (int i = 0; i < addToGrid.Count; i++)
                {
                    if (!addToGrid[i].Equals(""))
                    {
                        dataGridView1.Rows[rowIndex].Cells[i].Value = addToGrid[i];
                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
