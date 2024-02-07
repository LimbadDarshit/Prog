﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOperations1
{
    public partial class ADMIN_LOGIN : Form
    {
        public ADMIN_LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            string RESPONSE = SQLConn.sql.CHKADMIN(unmtxt.Text, pwdtxt.Text);
            if (RESPONSE == "true")
            {
                this.Hide();
                LOADING load = new LOADING();
                load.Show();
            }
            else {
                MessageBox.Show( RESPONSE, "Error", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
        }
    }
}