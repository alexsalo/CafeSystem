namespace CafeSystem
{
    partial class ShowAllTables
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
            this.back_to_manager_btn = new System.Windows.Forms.Button();
            this.tables_tabControl = new System.Windows.Forms.TabControl();
            this.tabCategoryFood = new System.Windows.Forms.TabPage();
            this.foodGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRecipe = new System.Windows.Forms.TabPage();
            this.RecipeGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRecipe_Stuff = new System.Windows.Forms.TabPage();
            this.recipestuffGridView1 = new System.Windows.Forms.DataGridView();
            this.tabIngridient = new System.Windows.Forms.TabPage();
            this.ingridientGridView1 = new System.Windows.Forms.DataGridView();
            this.tabMeasure = new System.Windows.Forms.TabPage();
            this.MeasureGridView1 = new System.Windows.Forms.DataGridView();
            this.tabSupply = new System.Windows.Forms.TabPage();
            this.supplyGridView1 = new System.Windows.Forms.DataGridView();
            this.tabDepartment = new System.Windows.Forms.TabPage();
            this.departmentGridView1 = new System.Windows.Forms.DataGridView();
            this.tabWorker = new System.Windows.Forms.TabPage();
            this.workerGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Load_data = new System.Windows.Forms.Button();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.tabOrderStuff = new System.Windows.Forms.TabPage();
            this.OrderdataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderStuffdataGridView2 = new System.Windows.Forms.DataGridView();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.tables_tabControl.SuspendLayout();
            this.tabCategoryFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView1)).BeginInit();
            this.tabRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGridView1)).BeginInit();
            this.tabRecipe_Stuff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipestuffGridView1)).BeginInit();
            this.tabIngridient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingridientGridView1)).BeginInit();
            this.tabMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureGridView1)).BeginInit();
            this.tabSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplyGridView1)).BeginInit();
            this.tabDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView1)).BeginInit();
            this.tabWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.tabOrderStuff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderStuffdataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // back_to_manager_btn
            // 
            this.back_to_manager_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_to_manager_btn.Location = new System.Drawing.Point(0, 0);
            this.back_to_manager_btn.Name = "back_to_manager_btn";
            this.back_to_manager_btn.Size = new System.Drawing.Size(75, 24);
            this.back_to_manager_btn.TabIndex = 0;
            this.back_to_manager_btn.Text = "Back";
            this.back_to_manager_btn.UseVisualStyleBackColor = true;
            this.back_to_manager_btn.Click += new System.EventHandler(this.back_to_manager_btn_Click);
            // 
            // tables_tabControl
            // 
            this.tables_tabControl.Controls.Add(this.tabCategoryFood);
            this.tables_tabControl.Controls.Add(this.tabRecipe);
            this.tables_tabControl.Controls.Add(this.tabRecipe_Stuff);
            this.tables_tabControl.Controls.Add(this.tabIngridient);
            this.tables_tabControl.Controls.Add(this.tabMeasure);
            this.tables_tabControl.Controls.Add(this.tabSupply);
            this.tables_tabControl.Controls.Add(this.tabDepartment);
            this.tables_tabControl.Controls.Add(this.tabWorker);
            this.tables_tabControl.Controls.Add(this.tabOrder);
            this.tables_tabControl.Controls.Add(this.tabOrderStuff);
            this.tables_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tables_tabControl.Location = new System.Drawing.Point(3, 33);
            this.tables_tabControl.Name = "tables_tabControl";
            this.tables_tabControl.SelectedIndex = 0;
            this.tables_tabControl.Size = new System.Drawing.Size(765, 460);
            this.tables_tabControl.TabIndex = 1;
            // 
            // tabCategoryFood
            // 
            this.tabCategoryFood.Controls.Add(this.foodGridView1);
            this.tabCategoryFood.Location = new System.Drawing.Point(4, 22);
            this.tabCategoryFood.Name = "tabCategoryFood";
            this.tabCategoryFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoryFood.Size = new System.Drawing.Size(757, 434);
            this.tabCategoryFood.TabIndex = 0;
            this.tabCategoryFood.Text = "Food Category";
            this.tabCategoryFood.UseVisualStyleBackColor = true;
            // 
            // foodGridView1
            // 
            this.foodGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodGridView1.Location = new System.Drawing.Point(3, 3);
            this.foodGridView1.Name = "foodGridView1";
            this.foodGridView1.Size = new System.Drawing.Size(751, 428);
            this.foodGridView1.TabIndex = 0;
            // 
            // tabRecipe
            // 
            this.tabRecipe.Controls.Add(this.RecipeGridView1);
            this.tabRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabRecipe.Name = "tabRecipe";
            this.tabRecipe.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipe.Size = new System.Drawing.Size(757, 434);
            this.tabRecipe.TabIndex = 1;
            this.tabRecipe.Text = "Recipe";
            this.tabRecipe.UseVisualStyleBackColor = true;
            // 
            // RecipeGridView1
            // 
            this.RecipeGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipeGridView1.Location = new System.Drawing.Point(3, 3);
            this.RecipeGridView1.Name = "RecipeGridView1";
            this.RecipeGridView1.Size = new System.Drawing.Size(751, 428);
            this.RecipeGridView1.TabIndex = 0;
            // 
            // tabRecipe_Stuff
            // 
            this.tabRecipe_Stuff.Controls.Add(this.recipestuffGridView1);
            this.tabRecipe_Stuff.Location = new System.Drawing.Point(4, 22);
            this.tabRecipe_Stuff.Name = "tabRecipe_Stuff";
            this.tabRecipe_Stuff.Size = new System.Drawing.Size(757, 434);
            this.tabRecipe_Stuff.TabIndex = 2;
            this.tabRecipe_Stuff.Text = "Recipe Stuff";
            this.tabRecipe_Stuff.UseVisualStyleBackColor = true;
            // 
            // recipestuffGridView1
            // 
            this.recipestuffGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipestuffGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipestuffGridView1.Location = new System.Drawing.Point(0, 0);
            this.recipestuffGridView1.Name = "recipestuffGridView1";
            this.recipestuffGridView1.Size = new System.Drawing.Size(757, 434);
            this.recipestuffGridView1.TabIndex = 0;
            // 
            // tabIngridient
            // 
            this.tabIngridient.Controls.Add(this.ingridientGridView1);
            this.tabIngridient.Location = new System.Drawing.Point(4, 22);
            this.tabIngridient.Name = "tabIngridient";
            this.tabIngridient.Size = new System.Drawing.Size(757, 434);
            this.tabIngridient.TabIndex = 3;
            this.tabIngridient.Text = "Ingridients";
            this.tabIngridient.UseVisualStyleBackColor = true;
            // 
            // ingridientGridView1
            // 
            this.ingridientGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingridientGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridientGridView1.Location = new System.Drawing.Point(0, 0);
            this.ingridientGridView1.Name = "ingridientGridView1";
            this.ingridientGridView1.Size = new System.Drawing.Size(757, 434);
            this.ingridientGridView1.TabIndex = 0;
            // 
            // tabMeasure
            // 
            this.tabMeasure.Controls.Add(this.MeasureGridView1);
            this.tabMeasure.Location = new System.Drawing.Point(4, 22);
            this.tabMeasure.Name = "tabMeasure";
            this.tabMeasure.Size = new System.Drawing.Size(757, 434);
            this.tabMeasure.TabIndex = 4;
            this.tabMeasure.Text = "Measure";
            this.tabMeasure.UseVisualStyleBackColor = true;
            // 
            // MeasureGridView1
            // 
            this.MeasureGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeasureGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeasureGridView1.Location = new System.Drawing.Point(0, 0);
            this.MeasureGridView1.Name = "MeasureGridView1";
            this.MeasureGridView1.Size = new System.Drawing.Size(757, 434);
            this.MeasureGridView1.TabIndex = 0;
            // 
            // tabSupply
            // 
            this.tabSupply.Controls.Add(this.supplyGridView1);
            this.tabSupply.Location = new System.Drawing.Point(4, 22);
            this.tabSupply.Name = "tabSupply";
            this.tabSupply.Size = new System.Drawing.Size(757, 434);
            this.tabSupply.TabIndex = 5;
            this.tabSupply.Text = "Supply";
            this.tabSupply.UseVisualStyleBackColor = true;
            // 
            // supplyGridView1
            // 
            this.supplyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplyGridView1.Location = new System.Drawing.Point(0, 0);
            this.supplyGridView1.Name = "supplyGridView1";
            this.supplyGridView1.Size = new System.Drawing.Size(757, 434);
            this.supplyGridView1.TabIndex = 0;
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.departmentGridView1);
            this.tabDepartment.Location = new System.Drawing.Point(4, 22);
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.Size = new System.Drawing.Size(757, 434);
            this.tabDepartment.TabIndex = 6;
            this.tabDepartment.Text = "Departments";
            this.tabDepartment.UseVisualStyleBackColor = true;
            // 
            // departmentGridView1
            // 
            this.departmentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentGridView1.Location = new System.Drawing.Point(0, 0);
            this.departmentGridView1.Name = "departmentGridView1";
            this.departmentGridView1.Size = new System.Drawing.Size(757, 434);
            this.departmentGridView1.TabIndex = 0;
            // 
            // tabWorker
            // 
            this.tabWorker.Controls.Add(this.workerGridView1);
            this.tabWorker.Location = new System.Drawing.Point(4, 22);
            this.tabWorker.Name = "tabWorker";
            this.tabWorker.Size = new System.Drawing.Size(757, 434);
            this.tabWorker.TabIndex = 7;
            this.tabWorker.Text = "Workers";
            this.tabWorker.UseVisualStyleBackColor = true;
            // 
            // workerGridView1
            // 
            this.workerGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerGridView1.Location = new System.Drawing.Point(0, 0);
            this.workerGridView1.Name = "workerGridView1";
            this.workerGridView1.Size = new System.Drawing.Size(757, 434);
            this.workerGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tables_tabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.048387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.95161F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 496);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit_Btn);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Load_data);
            this.panel1.Controls.Add(this.back_to_manager_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 24);
            this.panel1.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.Save.Location = new System.Drawing.Point(150, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 24);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load_data
            // 
            this.Load_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.Load_data.Location = new System.Drawing.Point(75, 0);
            this.Load_data.Name = "Load_data";
            this.Load_data.Size = new System.Drawing.Size(75, 24);
            this.Load_data.TabIndex = 1;
            this.Load_data.Text = "Load data";
            this.Load_data.UseVisualStyleBackColor = true;
            this.Load_data.Click += new System.EventHandler(this.Load_data_Click);
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.OrderdataGridView1);
            this.tabOrder.Location = new System.Drawing.Point(4, 22);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(757, 434);
            this.tabOrder.TabIndex = 8;
            this.tabOrder.Text = "Orders";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // tabOrderStuff
            // 
            this.tabOrderStuff.Controls.Add(this.OrderStuffdataGridView2);
            this.tabOrderStuff.Location = new System.Drawing.Point(4, 22);
            this.tabOrderStuff.Name = "tabOrderStuff";
            this.tabOrderStuff.Size = new System.Drawing.Size(757, 434);
            this.tabOrderStuff.TabIndex = 9;
            this.tabOrderStuff.Text = "Order Stuff";
            this.tabOrderStuff.UseVisualStyleBackColor = true;
            // 
            // OrderdataGridView1
            // 
            this.OrderdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.OrderdataGridView1.Name = "OrderdataGridView1";
            this.OrderdataGridView1.Size = new System.Drawing.Size(757, 434);
            this.OrderdataGridView1.TabIndex = 0;
            // 
            // OrderStuffdataGridView2
            // 
            this.OrderStuffdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderStuffdataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderStuffdataGridView2.Location = new System.Drawing.Point(0, 0);
            this.OrderStuffdataGridView2.Name = "OrderStuffdataGridView2";
            this.OrderStuffdataGridView2.Size = new System.Drawing.Size(757, 434);
            this.OrderStuffdataGridView2.TabIndex = 0;
            // 
            // exit_Btn
            // 
            this.exit_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_Btn.Location = new System.Drawing.Point(690, 0);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(75, 24);
            this.exit_Btn.TabIndex = 3;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // ShowAllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 496);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowAllTables";
            this.Text = "ShowAllTables";
            this.tables_tabControl.ResumeLayout(false);
            this.tabCategoryFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodGridView1)).EndInit();
            this.tabRecipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeGridView1)).EndInit();
            this.tabRecipe_Stuff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipestuffGridView1)).EndInit();
            this.tabIngridient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingridientGridView1)).EndInit();
            this.tabMeasure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MeasureGridView1)).EndInit();
            this.tabSupply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplyGridView1)).EndInit();
            this.tabDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentGridView1)).EndInit();
            this.tabWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabOrder.ResumeLayout(false);
            this.tabOrderStuff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderStuffdataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_to_manager_btn;
        private System.Windows.Forms.TabControl tables_tabControl;
        private System.Windows.Forms.TabPage tabCategoryFood;
        private System.Windows.Forms.TabPage tabRecipe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView foodGridView1;
        private System.Windows.Forms.TabPage tabRecipe_Stuff;
        private System.Windows.Forms.TabPage tabIngridient;
        private System.Windows.Forms.TabPage tabMeasure;
        private System.Windows.Forms.TabPage tabSupply;
        private System.Windows.Forms.TabPage tabDepartment;
        private System.Windows.Forms.TabPage tabWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Load_data;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridView RecipeGridView1;
        private System.Windows.Forms.DataGridView recipestuffGridView1;
        private System.Windows.Forms.DataGridView ingridientGridView1;
        private System.Windows.Forms.DataGridView MeasureGridView1;
        private System.Windows.Forms.DataGridView supplyGridView1;
        private System.Windows.Forms.DataGridView departmentGridView1;
        private System.Windows.Forms.DataGridView workerGridView1;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.DataGridView OrderdataGridView1;
        private System.Windows.Forms.TabPage tabOrderStuff;
        private System.Windows.Forms.DataGridView OrderStuffdataGridView2;
        private System.Windows.Forms.Button exit_Btn;
    }
}