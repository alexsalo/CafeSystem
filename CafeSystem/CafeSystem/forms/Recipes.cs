﻿using System;
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
        private cafesystemEntities4 cafeContext;
        private ManagerForm m_manageForm;
        public Recipes(ManagerForm f)
        {
            InitializeComponent();
            m_manageForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dispose the object context.
            if (cafeContext != null)
                cafeContext.Dispose();
            m_manageForm.Show();
            this.Close();
        }

        private void ShowRecipeBtn_Click(object sender, EventArgs e)
        {
            cafeContext = new cafesystemEntities4();
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
            var recipestuffQuery = from rs in cafeContext.recipe_stuff
                                   select rs;
                                   
                
                
                //from rs in cafeContext.recipe_stuff
                               //    where rs.recipe_id == 1//(int)recipeGridView[0, e.RowIndex].Value
                                //   select rs.ingridients_id;

            try
            {
                this.StuffGridView.DataSource = ((ObjectQuery)recipestuffQuery).Execute(MergeOption.AppendOnly);
                //recipeGridView.Columns["recipe_id"].Visible = false;
                //recipeGridView.Columns["recipe_stuff"].Visible = false;
                StuffGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                StuffGridView.AllowUserToDeleteRows = true;
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
