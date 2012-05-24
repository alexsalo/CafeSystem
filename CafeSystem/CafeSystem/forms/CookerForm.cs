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
    public partial class CookerForm : Form
    {
        private MainForm m_mainForm;
        public CookerForm(MainForm f)
        {
            InitializeComponent();
            m_mainForm = f;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            this.Close();
        }

        private void viewrecipesBtn_Click(object sender, EventArgs e)
        {
            Recipes m_recipes = new Recipes(this);
            m_recipes.Show();
            this.Hide();
        }
    }
}
