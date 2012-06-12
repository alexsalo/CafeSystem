namespace CafeSystem
{
    partial class AddRecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.food_category_cb = new System.Windows.Forms.ComboBox();
            this.foodcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafesystemDataSet = new CafeSystem.cafesystemDataSet();
            this.fc_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.addRecipe_btn = new System.Windows.Forms.Button();
            this.food_categoryTableAdapter = new CafeSystem.cafesystemDataSetTableAdapters.food_categoryTableAdapter();
            this.desc_rb = new System.Windows.Forms.RichTextBox();
            this.ingridients_listbox = new System.Windows.Forms.ListBox();
            this.existIngrid = new System.Windows.Forms.ListBox();
            this.ingridientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingridientTableAdapter = new CafeSystem.cafesystemDataSetTableAdapters.ingridientTableAdapter();
            this.totalcost_tb = new System.Windows.Forms.TextBox();
            this.count_lb = new System.Windows.Forms.ListBox();
            this.ing_count_lb = new System.Windows.Forms.ListBox();
            this.cost_lb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafesystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tb
            // 
            this.name_tb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.name_tb.Location = new System.Drawing.Point(12, 39);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(167, 20);
            this.name_tb.TabIndex = 0;
            // 
            // food_category_cb
            // 
            this.food_category_cb.DataSource = this.foodcategoryBindingSource;
            this.food_category_cb.DisplayMember = "name";
            this.food_category_cb.FormattingEnabled = true;
            this.food_category_cb.Location = new System.Drawing.Point(13, 12);
            this.food_category_cb.Name = "food_category_cb";
            this.food_category_cb.Size = new System.Drawing.Size(166, 21);
            this.food_category_cb.TabIndex = 2;
            this.food_category_cb.ValueMember = "food_category_id";
            // 
            // foodcategoryBindingSource
            // 
            this.foodcategoryBindingSource.DataMember = "food_category";
            this.foodcategoryBindingSource.DataSource = this.cafesystemDataSet;
            // 
            // cafesystemDataSet
            // 
            this.cafesystemDataSet.DataSetName = "cafesystemDataSet";
            this.cafesystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fc_lb
            // 
            this.fc_lb.AutoSize = true;
            this.fc_lb.Location = new System.Drawing.Point(186, 19);
            this.fc_lb.Name = "fc_lb";
            this.fc_lb.Size = new System.Drawing.Size(105, 13);
            this.fc_lb.TabIndex = 3;
            this.fc_lb.Text = "Select food category";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(186, 46);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(105, 13);
            this.name_lb.TabIndex = 4;
            this.name_lb.Text = "Enter name of recipe";
            // 
            // addRecipe_btn
            // 
            this.addRecipe_btn.Location = new System.Drawing.Point(13, 290);
            this.addRecipe_btn.Name = "addRecipe_btn";
            this.addRecipe_btn.Size = new System.Drawing.Size(319, 23);
            this.addRecipe_btn.TabIndex = 6;
            this.addRecipe_btn.Text = "Create";
            this.addRecipe_btn.UseVisualStyleBackColor = true;
            this.addRecipe_btn.Click += new System.EventHandler(this.addRecipe_btn_Click);
            // 
            // food_categoryTableAdapter
            // 
            this.food_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // desc_rb
            // 
            this.desc_rb.Location = new System.Drawing.Point(13, 66);
            this.desc_rb.Name = "desc_rb";
            this.desc_rb.Size = new System.Drawing.Size(318, 52);
            this.desc_rb.TabIndex = 7;
            this.desc_rb.Text = "some description";
            // 
            // ingridients_listbox
            // 
            this.ingridients_listbox.FormattingEnabled = true;
            this.ingridients_listbox.Location = new System.Drawing.Point(12, 137);
            this.ingridients_listbox.Name = "ingridients_listbox";
            this.ingridients_listbox.Size = new System.Drawing.Size(94, 121);
            this.ingridients_listbox.TabIndex = 8;
            // 
            // existIngrid
            // 
            this.existIngrid.DataSource = this.ingridientBindingSource;
            this.existIngrid.DisplayMember = "name";
            this.existIngrid.FormattingEnabled = true;
            this.existIngrid.Location = new System.Drawing.Point(189, 137);
            this.existIngrid.Name = "existIngrid";
            this.existIngrid.Size = new System.Drawing.Size(102, 121);
            this.existIngrid.TabIndex = 9;
            this.existIngrid.ValueMember = "ingridient_id";
            this.existIngrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.existIngrid_MouseDoubleClick);
            // 
            // ingridientBindingSource
            // 
            this.ingridientBindingSource.DataMember = "ingridient";
            this.ingridientBindingSource.DataSource = this.cafesystemDataSet;
            // 
            // ingridientTableAdapter
            // 
            this.ingridientTableAdapter.ClearBeforeFill = true;
            // 
            // totalcost_tb
            // 
            this.totalcost_tb.Location = new System.Drawing.Point(13, 264);
            this.totalcost_tb.Name = "totalcost_tb";
            this.totalcost_tb.Size = new System.Drawing.Size(318, 20);
            this.totalcost_tb.TabIndex = 10;
            // 
            // count_lb
            // 
            this.count_lb.DataSource = this.ingridientBindingSource;
            this.count_lb.DisplayMember = "cost";
            this.count_lb.FormattingEnabled = true;
            this.count_lb.Location = new System.Drawing.Point(297, 137);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(34, 121);
            this.count_lb.TabIndex = 11;
            this.count_lb.ValueMember = "ingridient_id";
            // 
            // ing_count_lb
            // 
            this.ing_count_lb.FormattingEnabled = true;
            this.ing_count_lb.Location = new System.Drawing.Point(157, 137);
            this.ing_count_lb.Name = "ing_count_lb";
            this.ing_count_lb.Size = new System.Drawing.Size(26, 121);
            this.ing_count_lb.TabIndex = 12;
            this.ing_count_lb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ing_count_lb_MouseDoubleClick);
            // 
            // cost_lb
            // 
            this.cost_lb.FormattingEnabled = true;
            this.cost_lb.Location = new System.Drawing.Point(113, 137);
            this.cost_lb.Name = "cost_lb";
            this.cost_lb.Size = new System.Drawing.Size(38, 121);
            this.cost_lb.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingridients in base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Recipe stuff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Qnt";
            // 
            // AddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 316);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost_lb);
            this.Controls.Add(this.ing_count_lb);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.totalcost_tb);
            this.Controls.Add(this.existIngrid);
            this.Controls.Add(this.ingridients_listbox);
            this.Controls.Add(this.desc_rb);
            this.Controls.Add(this.addRecipe_btn);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.fc_lb);
            this.Controls.Add(this.food_category_cb);
            this.Controls.Add(this.name_tb);
            this.Name = "AddRecipeForm";
            this.Text = "Create new recipe";
            this.Load += new System.EventHandler(this.AddRecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafesystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ComboBox food_category_cb;
        private System.Windows.Forms.Label fc_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Button addRecipe_btn;
        private cafesystemDataSet cafesystemDataSet;
        private System.Windows.Forms.BindingSource foodcategoryBindingSource;
        private cafesystemDataSetTableAdapters.food_categoryTableAdapter food_categoryTableAdapter;
        private System.Windows.Forms.RichTextBox desc_rb;
        private System.Windows.Forms.ListBox ingridients_listbox;
        private System.Windows.Forms.ListBox existIngrid;
        private System.Windows.Forms.BindingSource ingridientBindingSource;
        private cafesystemDataSetTableAdapters.ingridientTableAdapter ingridientTableAdapter;
        private System.Windows.Forms.TextBox totalcost_tb;
        private System.Windows.Forms.ListBox count_lb;
        private System.Windows.Forms.ListBox ing_count_lb;
        private System.Windows.Forms.ListBox cost_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}