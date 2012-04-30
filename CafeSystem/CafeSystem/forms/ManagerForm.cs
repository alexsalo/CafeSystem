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
    public partial class ManagerForm : Form
    {        
        private MainForm m_mainform;
        public ManagerForm(MainForm f)
        {
            InitializeComponent();
            m_mainform = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recipes m_recipe = new Recipes(this);
            this.Hide(); 
            m_recipe.Show();           
        }

        private void back_to_main_Click(object sender, EventArgs e)
        {
            m_mainform.Show();
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
