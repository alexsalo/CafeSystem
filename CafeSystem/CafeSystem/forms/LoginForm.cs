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

        private cafesystemEntities3 cafeContext;
        private MainForm m_mainform;
        private int m_departmentCallFrom;
        public LoginForm(MainForm F, int DEP)
        {
            InitializeComponent();
            m_mainform = F;
            m_departmentCallFrom = DEP;
            cafeContext = new cafesystemEntities3();

            ///test purposes
            if (DEP == Constants.MANAGERDEP_ID)
            {
                login_tb.Text = "AlexSalo";
                pass_tb.Text = "123";
            }
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            IQueryable<worker> userQuery = from w in cafeContext.worker
                                           where w.name + w.surname == login_tb.Text
                                           select w;
            if (userQuery.Any())
            {
                foreach (worker w in userQuery)
                    switch (m_departmentCallFrom)
                    {
                        case Constants.CASHIERDEP_ID:
                            if (w.department_id == Constants.CASHIERDEP_ID
                                || w.department_id == Constants.MANAGERDEP_ID)
                                if (pass_tb.Text == w.password)
                                {
                                    CashierFrom m_cashierForm = new CashierFrom(m_mainform);
                                    m_cashierForm.Show();
                                    this.Close();
                                }
                                else MessageBox.Show("Incorrect password");
                            else
                                MessageBox.Show("You don't have permission");
                            break;

                        case Constants.MANAGERDEP_ID:
                            if (w.department_id == Constants.MANAGERDEP_ID)
                                if (pass_tb.Text == w.password)
                                {
                                    ManagerForm m_managerForm = new ManagerForm(m_mainform);
                                    m_managerForm.Show();
                                    this.Close();                                    
                                }
                                else MessageBox.Show("Incorrect password");
                            else
                                MessageBox.Show("You don't have permission");
                            break;
                    }
            }
            else
                MessageBox.Show("No such login");
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            m_mainform.Show();
            this.Close();
        }
    }
}
