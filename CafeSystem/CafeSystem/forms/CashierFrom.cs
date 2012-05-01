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
    public partial class CashierFrom : Form
    {
        private MainForm m_mainForm;
        public CashierFrom(MainForm f)
        {
            InitializeComponent();
            m_mainForm = f;
        }

        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            this.Close();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
