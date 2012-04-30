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
    public partial class Recipes : Form
    {
        private ManagerForm m_manageForm;
        public Recipes(ManagerForm f)
        {
            InitializeComponent();
            m_manageForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_manageForm.Show();
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
