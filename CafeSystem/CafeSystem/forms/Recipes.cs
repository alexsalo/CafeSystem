using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace CafeSystem
{
    public partial class Recipes : Form
    {
        private cafesystemEntities1 cafeContext;
        private ManagerForm m_manageForm;
        public Recipes(ManagerForm f)
        {
            InitializeComponent();
            m_manageForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dispose the object context.
            cafeContext.Dispose();
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

        private void ShowRecipeBtn_Click(object sender, EventArgs e)
        {
            cafeContext = new cafesystemEntities1();
            var recipeQuery = from d in cafeContext.recipe
                              select d;
            try
            {
                this.recipeGridView.DataSource = ((ObjectQuery)recipeQuery).Execute(MergeOption.AppendOnly);
                recipeGridView.Columns["recipe_id"].Visible = false;
                recipeGridView.Columns["recipe_stuff"].Visible = false;
                recipeGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                recipeGridView.AllowUserToDeleteRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recipeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var recipestuffQuery = from d in cafeContext.recipe_stuff                                 
                                   select d.recipe_stuff_id;
            try
            {
                this.recipeGridView.DataSource = ((ObjectQuery)recipestuffQuery).Execute(MergeOption.AppendOnly);
                recipeGridView.Columns["recipe_id"].Visible = false;
                recipeGridView.Columns["recipe_stuff"].Visible = false;
                recipeGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                recipeGridView.AllowUserToDeleteRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                       
        }

        private void recipeGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                //DataGridViewCell cell = this.recipeGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //cell.ToolTipText = this.recipeGridView[2, e.RowIndex].Value.ToString();
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                // Save object changes to the database, 
                // display a message, and refresh the form.
                cafeContext.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteRecipe_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this row?", 
                "Delete row?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)                
                recipeGridView.Rows.Remove(recipeGridView.CurrentRow);
        }

    }
}
