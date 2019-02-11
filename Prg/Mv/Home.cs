﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mrln.Mv
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            ftContainer.SelectedTab = tpMoviles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void Home_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
