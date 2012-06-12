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
using System.Data.Entity;

namespace CafeSystem
{
    public partial class AddRecipeForm : Form
    {
        private cafesystemEntities4 m_cafecontext;
        private recipe m_recipe;
        private recipe_stuff m_rs;
        private int totalcost;
        private List<recipe_stuff> tempstuff;
        public AddRecipeForm()
        {
            InitializeComponent();
            m_cafecontext = new cafesystemEntities4();
            totalcost = 0;
        }

        private void addRecipe_btn_Click(object sender, EventArgs e)
        {
            m_recipe = recipe.Createrecipe(1, name_tb.Text);
            m_recipe.description = desc_rb.Text;
            m_recipe.food_category_id = (int)food_category_cb.SelectedValue;
            m_cafecontext.recipe.AddObject(m_recipe);

            for (int i=0; i<tempstuff.Count; i++)
                m_cafecontext.recipe_stuff.AddObject(tempstuff[i]);

            m_cafecontext.SaveChanges();
            this.Close();
        }

        private void AddRecipeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafesystemDataSet.ingridient' table. You can move, or remove it, as needed.
            this.ingridientTableAdapter.Fill(this.cafesystemDataSet.ingridient);
            // TODO: This line of code loads data into the 'cafesystemDataSet.food_category' table. You can move, or remove it, as needed.
            this.food_categoryTableAdapter.Fill(this.cafesystemDataSet.food_category);
            tempstuff = new List<recipe_stuff>();
        }

        private void existIngrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ingridients_listbox.Items.Add(existIngrid.Text);
            cost_lb.Items.Add(count_lb.Text);
            ing_count_lb.Items.Add(1);
            int ing_index = (int)((ListBox)sender).SelectedValue;
            string auto_inc_recipe_query = "select AUTO_INCREMENT from information_schema.tables where TABLE_SCHEMA = 'cafesystem' and TABLE_NAME = 'recipe'";
            int[] rec_indexes = m_cafecontext.ExecuteStoreQuery<int>(auto_inc_recipe_query).ToArray();
            int recipe_index = rec_indexes[0];

            m_rs = recipe_stuff.Createrecipe_stuff(ing_index, recipe_index, 1, 1);
            tempstuff.Add(m_rs);        

            totalcost += ingridientTableAdapter.GetData()[ing_index].cost;
            totalcost_tb.Text = totalcost.ToString();
        }

        private void ing_count_lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int newct = (int)ing_count_lb.Items[ing_count_lb.SelectedIndex] + 1;
            ing_count_lb.Items[ing_count_lb.SelectedIndex] = newct;
            object o = cost_lb.Items[ing_count_lb.SelectedIndex];
            totalcost += Int32.Parse(o.ToString());
            totalcost_tb.Text = totalcost.ToString();
            tempstuff[((ListBox)sender).SelectedIndex].count += 1;
        }

    }
}
