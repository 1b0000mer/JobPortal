﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCompanyInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompanyInfo frm = new CompanyInfo();
            frm.ShowDialog();
            this.Show();
        }
        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoUser frm = new InfoUser();
            frm.ShowDialog();
            this.Show();
        }
    }
}
