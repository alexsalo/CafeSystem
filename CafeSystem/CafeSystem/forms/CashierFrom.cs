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
    //mvvm
    public partial class CashierFrom : Form
    {
        private MainForm m_mainForm;
        private cafesystemEntities4 cafeContext;
        private int m_currentORDERNUM;
        List<recipe> m_currentOrder;
        public CashierFrom(MainForm f)
        {
            InitializeComponent();
            m_mainForm = f;
            cafeContext = new cafesystemEntities4();
            //m_orders = new Dictionary<DateTime, List<recipe>>();
            m_currentOrder = new List<recipe>();

            m_currentORDERNUM = Constants.Functions.ORDER_NUM();
            printOrderTemplate();
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
            recipe[] rA = recipeQuery.ToArray();
            List<Button> btnlist = new List<Button>();

            foreach (recipe r in rA)
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
                    new EventHandler((s, args) => 
                    { 
                        orderList.Items.Add((s as Button).Text);
                        recipe re = new recipe();
                        re = getRecipe((s as Button).Name, rA);
                        m_currentOrder.Add(re);
                        totalOrder_tb.Text = getCurrentCost().ToString();
                    });
            }
            foreach (Button b in btnlist)
                this.ItemsflowLayoutPanel1.Controls.Add(b);
        }

        private recipe getRecipe(string text, recipe[] A)
        {
            for (int i = 0; i < A.Count(); i++)
                if (A[i].name + "Btn" == text)
                    return A[i];
            return null;
        }

        private int getCurrentCost()
        {
            int cost = 0;
            foreach (recipe r in m_currentOrder)
                cost += (int)r.totalcost;
            return cost;
        }

        private void DismissBtn_Click(object sender, EventArgs e)
        {
            m_currentOrder.Clear();
            orderList.Text = "";
            totalOrder_tb.Text = "";
            orderList.Items.Clear();
            printOrderTemplate();
        }

        private void MakeOrderBtn_Click(object sender, EventArgs e)
        {        
            ordert o = new ordert();
            o.date = DateTime.Now;
            o.totalcost = getCurrentCost();
            o.order_id = m_currentORDERNUM;
            cafeContext.AddToordert(o);

            
            foreach (recipe r in m_currentOrder)                            
                cafeContext.AddToorder_stuff(new order_stuff()
                {
                    order_id = m_currentORDERNUM,
                    recipe_id = r.recipe_id,
                });           
            
            cafeContext.SaveChanges();
            
            m_currentOrder.Clear();
            totalOrder_tb.Text = "";
            orderList.Items.Clear();
            m_currentORDERNUM = Constants.Functions.ORDER_NUM();
            printOrderTemplate();
        }

        private void printOrderTemplate()
        {
            orderList.Items.Add("-----Order #" + m_currentORDERNUM.ToString()
                + "------------------------------------------------");
            orderList.Items.Add("-----" + System.DateTime.Now + "------------------------");
            orderList.Items.Add("------------------------------------------------------" +
                "--------------------------");
        }

        private void DeleteSelectedBtn_Click(object sender, EventArgs e)
        {
            int index = orderList.SelectedIndex;
            if (index > 2)
            {
                orderList.Items.RemoveAt(index);
                m_currentOrder.RemoveAt(index - 3);
            }
        }
    }
}
