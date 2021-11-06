﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Stock
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Fruit_Stock.static_classes.Db_connect.openConnection();
            

            MessageBox.Show("Connection is " + Fruit_Stock.static_classes.Db_connect.conn.State.ToString(),
                "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Fruit_Stock.static_classes.Db_connect.closeConnection();

            MessageBox.Show("Connection is " + Fruit_Stock.static_classes.Db_connect.conn.State.ToString(),
                "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // login

        }
    }
}
