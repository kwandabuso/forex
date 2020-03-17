using forex.Engine;
using forex.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private DataTable DT = new DataTable();
        engine en = new engine();
        
        private void DisplayTrades_Load(object sender, EventArgs e)
        {
            var mYlst = new List<string>();
            mYlst = ReadFile(@"C:\kwanda\forex\Files\states.txt");



            


            read();

            //cmbFilterByDecision.item.add = "Select Decision";

            //cmbFilterByDecision.SelectedIndex = 0;

            //DT = new DataTable();
            //DAL dAL = new DAL();
            //DT = dAL.ReadDecisionData();

            //cmbFilterByDecision.DataSource = DT;

            //cmbFilterByDecision.ValueMember = "Decision";
            //cmbFilterByDecision.DisplayMember = "Decision";
           // cmbFilterByDecision.DataSource = DT;
        }
        public Boolean read()
        {
            DAL dAL = new DAL();
            DT = dAL.ReadData();

            dataGridView1.DataSource = DT;
            //var trades = new List<string>();
            //engine en = new engine();
            //GlobalVariables.TradesPath = @"C:\kwanda\forex\Files\Trades.txt";
            //trades = en.ReadFile(GlobalVariables.TradesPath, "");

            //for (int j = 0; j < trades.Count; j++)
            //{
            //    var addToGrid = new List<string>();
            //    addToGrid = trades[j].Split('|').ToList();

            //    var rowIndex = dataGridView1.Rows.Add();

            //    for (int i = 0; i < addToGrid.Count; i++)
            //    {
            //        if(!addToGrid[i].Equals(""))
            //        {
            //            dataGridView1.Rows[rowIndex].Cells[i].Value = addToGrid[i];
            //        }

            //    }
            //}






            return true;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT = new DataTable();
            DAL dAL = new DAL();
            DT = dAL.ReadStatusData(cmbFilter.Text);

            dataGridView1.DataSource = DT;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFilterByDecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT = new DataTable();
            DAL dAL = new DAL();
            var selected = cmbFilterByDecision.Text;
            

            DT = dAL.ReadTradedsDataOnSelectedText(cmbFilterByDecision.Text);

            dataGridView1.DataSource = DT;
            
        }

        public static List<string> ReadFile(string path)
        {
            try
            {
                // Read file to list
                var lst = new List<string>();
                lst = File.ReadAllLines(path).ToList();

                return lst;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
