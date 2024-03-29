﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafeSystem
{
    
    //metadata=res://*/CafeModel.csdl|res://*/CafeModel.ssdl|
    //res://*/CafeModel.msl;provider=MySql.Data.MySqlClient;
    //provider connection string="server=localhost;User Id=alex;
    //database=cafesystem"
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm m_loginFoem = new LoginForm(this, Constants.MANAGERDEP_ID);
            this.Hide();
            m_loginFoem.Show();
        }

        private void CashierMode_Click(object sender, EventArgs e)
        {
            //CashierFrom m_cashierFrom = new CashierFrom(this);
            LoginForm m_loginFoem = new LoginForm(this,Constants.CASHIERDEP_ID);
            this.Hide();
            m_loginFoem.Show();
        }

        private void coockerBtn_Click(object sender, EventArgs e)
        {
            LoginForm m_loginFoem = new LoginForm(this, Constants.COOCKERDEP_ID);
            this.Hide();
            m_loginFoem.Show();
        }
    }
}
