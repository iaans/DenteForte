﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenteForte_v2.Apresentacao
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value++;
            }
            catch
            {
                timer1.Enabled = false;
                this.Dispose();
            }

        }
    }
}

