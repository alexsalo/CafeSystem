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
    public partial class ShowAllTables : Form
    {
        private cafesystemEntities4 cafeContext;
        private ManagerForm m_mangerForm;
        public ShowAllTables(ManagerForm F)
        {
            InitializeComponent();
            m_mangerForm = F;
        }

        private void back_to_manager_btn_Click(object sender, EventArgs e)
        {
            m_mangerForm.Show();
            this.Close();
        }

        private void Load_data_Click(object sender, EventArgs e)
        {
            cafeContext = new cafesystemEntities4();
            var foodQuery = from f in cafeContext.food_category select f;
            var recipeQuery = from r in cafeContext.recipe select r;
            var recipestuffQuery = from rs in cafeContext.recipe_stuff select rs;
            var ingridientQuery = from i in cafeContext.ingridient select i;
            var measureQuery = from m in cafeContext.measure select m;
            var supplyQuery = from s in cafeContext.supply select s;
            var departmentQuery = from d in cafeContext.department select d;
            var workersQuery = from w in cafeContext.worker select w;
            var ordersQuery = from o in cafeContext.ordert select o;
            var orderstuffQuery = from os in cafeContext.order_stuff select os;
            try
            {
                foodGridView1.DataSource = ((ObjectQuery)foodQuery).Execute(MergeOption.AppendOnly);
                foodGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                RecipeGridView1.DataSource = ((ObjectQuery)recipeQuery).Execute(MergeOption.AppendOnly);
                RecipeGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                recipestuffGridView1.DataSource = ((ObjectQuery)recipestuffQuery).Execute(MergeOption.AppendOnly);
                recipestuffGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                ingridientGridView1.DataSource = ((ObjectQuery)ingridientQuery).Execute(MergeOption.AppendOnly);
                ingridientGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                MeasureGridView1.DataSource = ((ObjectQuery)measureQuery).Execute(MergeOption.AppendOnly);
                MeasureGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                supplyGridView1.DataSource = ((ObjectQuery)supplyQuery).Execute(MergeOption.AppendOnly);
                supplyGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                departmentGridView1.DataSource = ((ObjectQuery)departmentQuery).Execute(MergeOption.AppendOnly);
                departmentGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                workerGridView1.DataSource = ((ObjectQuery)workersQuery).Execute(MergeOption.AppendOnly);
                workerGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                OrderdataGridView1.DataSource = ((ObjectQuery)ordersQuery).Execute(MergeOption.AppendOnly);
                OrderdataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                OrderStuffdataGridView2.DataSource = ((ObjectQuery)orderstuffQuery).Execute(MergeOption.AppendOnly);
                OrderStuffdataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
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

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void md5_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void workerGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (workerGridView1[Constants.PASSWORD_COLUMN, e.RowIndex].Value != null)
                {
                    string s = workerGridView1[Constants.PASSWORD_COLUMN, e.RowIndex].Value.ToString();
                    workerGridView1[Constants.PASSWORD_COLUMN, e.RowIndex].Value =
                        MD5cheksum.getMd5Hash(s);
                }
            }
        }

    }
}
