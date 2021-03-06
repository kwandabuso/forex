﻿using forex.Engine;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        setup set = new setup();
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTrades displayTrades = new DisplayTrades();
            displayTrades.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          manageTrades   manage = new manageTrades();
            manage.ShowDialog();
        }

        private void rdoRunOnLive_CheckedChanged(object sender, EventArgs e)
        {
            
           GlobalVariables.DBPath =  set.getDBPath("Live");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalVariables.DBPath = set.getDBPath("");
        }
    }
}
