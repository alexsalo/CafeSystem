using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class LoginForm : Form
    {
        private cafesystemEntities1 cafeContext;
        private MainForm m_mainform;
        public LoginForm(MainForm F)
        {
            InitializeComponent();
            m_mainform = F;

            cafeContext = new cafesystemEntities1();
            
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            if (login_tb.Text == "1" && pass_tb.Text == "2")
            {
                CashierFrom m_cashierForm = new CashierFrom(m_mainform);
                m_cashierForm.Show();
                this.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            m_mainform.Show();
            this.Close();
        }
    }
}
