using forex.Engine;
using forex.objects;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        engine en = new engine();

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Boolean close = false;
            if(cmbDecision.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("please select a decision");
                
            }
            else if(txtNotes.Text.Equals(""))
            {
                MessageBox.Show("please enter notes for the trade");
               
            }

            else
            {
                placetrades trades = new placetrades(cmbDecision.Text, txtNotes.Text);



                DAL.InsertData(trades.makedecision, trades.myNotes, "OPEN");





                GlobalVariables.TradesPath = @"C:\kwanda\forex\Files\Trades.txt";
                var textToWrite = trades.makedecision + "|" + trades.myNotes + "|" + "OPEN";

                en.writeFile(GlobalVariables.TradesPath, textToWrite);

                txtNotes.Text = "";
                cmbDecision.Text = "";
            }
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var trades = new List<string>();
            GlobalVariables.TradesDecisions= @"C:\kwanda\forex\Files\states.txt";
            trades = en.ReadFile(GlobalVariables.TradesDecisions,"");


            foreach(var trs in trades)
            {
                cmbDecision.Items.Add(trs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTrades display = new DisplayTrades();
            display.ShowDialog();
        }
    }
}
