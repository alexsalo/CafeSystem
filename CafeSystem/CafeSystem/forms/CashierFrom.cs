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
        private cafesystemEntities2 cafeContext;
        public CashierFrom(MainForm f)
        {
            InitializeComponent();
            m_mainForm = f;
            cafeContext = new cafesystemEntities2();

            orderList.Items.Add("-----Order #" + Constants.Functions.ORDER_NUM().ToString()
                +"------------------------------------------------");
            orderList.Items.Add("-----"+System.DateTime.Now+"-----");
            orderList.Items.Add("--------------------------------------------------------");
        }

        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            this.Close();
        }

        private void CashierFrom_Load(object sender, EventArgs e)
        {
            //int cost;
            IQueryable<recipe> recipeQuery = from r in cafeContext.recipe
                                             select r;
            List<Button> btnlist = new List<Button>();
            foreach (recipe r in recipeQuery)
            {
                //cost = 0;
                ////all ingridients for current recipe
                //IQueryable<int> recipestuffQuery = from rs in cafeContext.recipe_stuff
                //                                   where rs.recipe_id == r.recipe_id
                //                                   select rs.ingridient_id;
                ////total cost of it
                //int[] A = recipestuffQuery.ToArray<int>();
                //IQueryable<int> ingQuery = from ing in cafeContext.ingridient
                //                           where A.Contains<int>(ing.ingridient_id)
                //                           select ing.cost;
                //foreach (int i in ingQuery)
                //    cost += i;

                btnlist.Add(new Button()
                    {
                        Name = r.name + "Btn",
                        Text = r.name, //+ " " + cost.ToString(),
                        Size = new System.Drawing.Size(60, 40),
                    }
                    );
                btnlist.Last<Button>().Click += 
                    new EventHandler((s, args) => { orderList.Items.Add((s as Button).Text); });
            }
            foreach (Button b in btnlist)
                this.ItemsflowLayoutPanel1.Controls.Add(b);
        }    
    }
}
