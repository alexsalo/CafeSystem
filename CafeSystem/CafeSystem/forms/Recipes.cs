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

            IEnumerable<string> foodcatQuery = cafeContext.ExecuteStoreQuery<string>("select name from food_category");
            foreach (string s in foodcatQuery )
                food_category_lb.Items.Add(s);
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
            
        }

        private void food_category_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select name from recipe r where r.food_category_id = (select food_category_id from food_category fc where fc.name ='"
                    + ((ListBox)sender).SelectedItem.ToString() + "')";
            IEnumerable<string> recipeQuery = cafeContext.ExecuteStoreQuery<string>(query);
            recipe_lb.Items.Clear();                                 
            foreach (string s in recipeQuery)
                recipe_lb.Items.Add(s);
        }

        private void recipe_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select name from ingridient i where i.ingridient_id in (select ingridient_id from recipe_stuff rs where rs.recipe_id="
                + "(select recipe_id from recipe r where r.name= '"
                    + ((ListBox)sender).SelectedItem.ToString() + "'))";
            IEnumerable<string> stuffQuery = cafeContext.ExecuteStoreQuery<string>(query);
            ingridients_lb.Items.Clear();
            foreach (string s in stuffQuery)
                ingridients_lb.Items.Add(s);
        }

    }
}
