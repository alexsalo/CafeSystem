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
        private cafesystemEntities3 cafeContext;
        public CashierFrom(MainForm f)
        {
            InitializeComponent();
            m_mainForm = f;
            cafeContext = new cafesystemEntities3();

            orderList.Items.Add("-----Order #" + Constants.Functions.ORDER_NUM().ToString()
                +"------------------------------------------------");
            orderList.Items.Add("-----"+System.DateTime.Now+"------------------------");
            orderList.Items.Add("------------------------------------------------------"+
                "--------------------------");
        }

        private void backToMainBtn_Click(object sender, EventArgs e)
        {
            m_mainForm.Show();
            this.Close();
        }

        private void CashierFrom_Load(object sender, EventArgs e)
        {
            IQueryable<recipe_stuff> recipestuffQuery = from rs in cafeContext.recipe_stuff                                                
                                                        select rs;
            IQueryable<ingridient> ingQuery = from ing in cafeContext.ingridient
                                              select ing;
            recipe_stuff[] rsA = recipestuffQuery.ToArray();
            ingridient[] ingA = ingQuery.ToArray();

            IQueryable<recipe> recipeQuery = from r in cafeContext.recipe
                                             select r;
            List<Button> btnlist = new List<Button>();
            foreach (recipe r in recipeQuery)
            {
                r.totalcost = 0;
                for (int i = 0; i < rsA.Count(); i++)
                    if (rsA[i].recipe_id == r.recipe_id)
                        for (int j = 0; j < ingA.Count(); j++)
                            if (ingA[j].ingridient_id == rsA[i].ingridient_id)
                                r.totalcost += ingA[j].cost * rsA[i].count;

                btnlist.Add(new Button()
                    {
                        Name = r.name + "Btn",
                        Text = r.name + " " + r.totalcost.ToString()+ " $",
                        Size = new System.Drawing.Size(80, 40),
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
