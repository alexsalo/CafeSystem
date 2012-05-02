namespace CafeSystem
{
    partial class Recipes
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
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.food_category_lb = new System.Windows.Forms.ListBox();
            this.recipe_lb = new System.Windows.Forms.ListBox();
            this.ingridients_lb = new System.Windows.Forms.ListBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.ShowRecipeBtn = new System.Windows.Forms.Button();
            this.back_to_manager = new System.Windows.Forms.Button();
            this.DeleteRecipe = new System.Windows.Forms.Button();
            this.mainRecipeTable = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            this.recipeLayoutTable.SuspendLayout();
            this.mainRecipeTable.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeLayoutTable
            // 
            this.recipeLayoutTable.ColumnCount = 3;
            this.recipeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.recipeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.recipeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.recipeLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.recipeLayoutTable.Controls.Add(this.food_category_lb, 0, 0);
            this.recipeLayoutTable.Controls.Add(this.recipe_lb, 1, 0);
            this.recipeLayoutTable.Controls.Add(this.ingridients_lb, 2, 0);
            this.recipeLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeLayoutTable.Location = new System.Drawing.Point(3, 35);
            this.recipeLayoutTable.Name = "recipeLayoutTable";
            this.recipeLayoutTable.RowCount = 1;
            this.recipeLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.recipeLayoutTable.Size = new System.Drawing.Size(632, 311);
            this.recipeLayoutTable.TabIndex = 7;
            // 
            // food_category_lb
            // 
            this.food_category_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.food_category_lb.FormattingEnabled = true;
            this.food_category_lb.Location = new System.Drawing.Point(3, 3);
            this.food_category_lb.Name = "food_category_lb";
            this.food_category_lb.Size = new System.Drawing.Size(197, 305);
            this.food_category_lb.TabIndex = 0;
            this.food_category_lb.SelectedIndexChanged += new System.EventHandler(this.food_category_lb_SelectedIndexChanged);
            // 
            // recipe_lb
            // 
            this.recipe_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipe_lb.FormattingEnabled = true;
            this.recipe_lb.Location = new System.Drawing.Point(206, 3);
            this.recipe_lb.Name = "recipe_lb";
            this.recipe_lb.Size = new System.Drawing.Size(209, 305);
            this.recipe_lb.TabIndex = 1;
            this.recipe_lb.SelectedIndexChanged += new System.EventHandler(this.recipe_lb_SelectedIndexChanged);
            // 
            // ingridients_lb
            // 
            this.ingridients_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingridients_lb.FormattingEnabled = true;
            this.ingridients_lb.Location = new System.Drawing.Point(421, 3);
            this.ingridients_lb.Name = "ingridients_lb";
            this.ingridients_lb.Size = new System.Drawing.Size(208, 305);
            this.ingridients_lb.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveChanges.Location = new System.Drawing.Point(0, 0);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(102, 26);
            this.saveChanges.TabIndex = 6;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // ShowRecipeBtn
            // 
            this.ShowRecipeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowRecipeBtn.Location = new System.Drawing.Point(102, 0);
            this.ShowRecipeBtn.Name = "ShowRecipeBtn";
            this.ShowRecipeBtn.Size = new System.Drawing.Size(120, 26);
            this.ShowRecipeBtn.TabIndex = 5;
            this.ShowRecipeBtn.Text = "Show Recipes";
            this.ShowRecipeBtn.UseVisualStyleBackColor = true;
            this.ShowRecipeBtn.Click += new System.EventHandler(this.ShowRecipeBtn_Click);
            // 
            // back_to_manager
            // 
            this.back_to_manager.Dock = System.Windows.Forms.DockStyle.Right;
            this.back_to_manager.Location = new System.Drawing.Point(377, 0);
            this.back_to_manager.Name = "back_to_manager";
            this.back_to_manager.Size = new System.Drawing.Size(149, 26);
            this.back_to_manager.TabIndex = 0;
            this.back_to_manager.Text = "Back to manager routine";
            this.back_to_manager.UseVisualStyleBackColor = true;
            this.back_to_manager.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteRecipe
            // 
            this.DeleteRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteRecipe.Location = new System.Drawing.Point(526, 0);
            this.DeleteRecipe.Name = "DeleteRecipe";
            this.DeleteRecipe.Size = new System.Drawing.Size(106, 26);
            this.DeleteRecipe.TabIndex = 8;
            this.DeleteRecipe.Text = "Delete Row";
            this.DeleteRecipe.UseVisualStyleBackColor = true;
            this.DeleteRecipe.Click += new System.EventHandler(this.DeleteRecipe_Click);
            // 
            // mainRecipeTable
            // 
            this.mainRecipeTable.ColumnCount = 1;
            this.mainRecipeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainRecipeTable.Controls.Add(this.recipeLayoutTable, 0, 1);
            this.mainRecipeTable.Controls.Add(this.buttonsPanel, 0, 0);
            this.mainRecipeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRecipeTable.Location = new System.Drawing.Point(0, 0);
            this.mainRecipeTable.Name = "mainRecipeTable";
            this.mainRecipeTable.RowCount = 2;
            this.mainRecipeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.455587F));
            this.mainRecipeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.54441F));
            this.mainRecipeTable.Size = new System.Drawing.Size(638, 349);
            this.mainRecipeTable.TabIndex = 8;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.back_to_manager);
            this.buttonsPanel.Controls.Add(this.DeleteRecipe);
            this.buttonsPanel.Controls.Add(this.panel1);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(632, 26);
            this.buttonsPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowRecipeBtn);
            this.panel1.Controls.Add(this.saveChanges);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 26);
            this.panel1.TabIndex = 1;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.ControlBox = false;
            this.Controls.Add(this.mainRecipeTable);
            this.Name = "Recipes";
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            this.recipeLayoutTable.ResumeLayout(false);
            this.mainRecipeTable.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource recipeBindingSource;
        private System.Windows.Forms.TableLayoutPanel recipeLayoutTable;
        private System.Windows.Forms.Button ShowRecipeBtn;
        private System.Windows.Forms.Button back_to_manager;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button DeleteRecipe;
        private System.Windows.Forms.TableLayoutPanel mainRecipeTable;
        private System.Windows.Forms.ListBox food_category_lb;
        private System.Windows.Forms.ListBox recipe_lb;
        private System.Windows.Forms.ListBox ingridients_lb;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel panel1;
        
    }
}