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
            this.recipeGridView = new System.Windows.Forms.DataGridView();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowRecipeBtn = new System.Windows.Forms.Button();
            this.back_to_manager = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.DeleteRecipe = new System.Windows.Forms.Button();
            this.StuffGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StuffGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeGridView
            // 
            this.recipeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeGridView.Location = new System.Drawing.Point(3, 39);
            this.recipeGridView.Name = "recipeGridView";
            this.recipeGridView.Size = new System.Drawing.Size(370, 307);
            this.recipeGridView.TabIndex = 1;
            this.recipeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipeGridView_CellClick);
            this.recipeGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.recipeGridView_CellMouseDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.Controls.Add(this.recipeGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteRecipe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StuffGridView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 349);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveChanges);
            this.panel1.Controls.Add(this.ShowRecipeBtn);
            this.panel1.Controls.Add(this.back_to_manager);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 28);
            this.panel1.TabIndex = 6;
            // 
            // ShowRecipeBtn
            // 
            this.ShowRecipeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowRecipeBtn.Location = new System.Drawing.Point(149, 0);
            this.ShowRecipeBtn.Name = "ShowRecipeBtn";
            this.ShowRecipeBtn.Size = new System.Drawing.Size(120, 28);
            this.ShowRecipeBtn.TabIndex = 5;
            this.ShowRecipeBtn.Text = "Show Recipes";
            this.ShowRecipeBtn.UseVisualStyleBackColor = true;
            this.ShowRecipeBtn.Click += new System.EventHandler(this.ShowRecipeBtn_Click);
            // 
            // back_to_manager
            // 
            this.back_to_manager.Dock = System.Windows.Forms.DockStyle.Left;
            this.back_to_manager.Location = new System.Drawing.Point(0, 0);
            this.back_to_manager.Name = "back_to_manager";
            this.back_to_manager.Size = new System.Drawing.Size(149, 28);
            this.back_to_manager.TabIndex = 0;
            this.back_to_manager.Text = "Back to manager routine";
            this.back_to_manager.UseVisualStyleBackColor = true;
            this.back_to_manager.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveChanges.Location = new System.Drawing.Point(268, 0);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(102, 28);
            this.saveChanges.TabIndex = 6;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // DeleteRecipe
            // 
            this.DeleteRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteRecipe.Location = new System.Drawing.Point(379, 3);
            this.DeleteRecipe.Name = "DeleteRecipe";
            this.DeleteRecipe.Size = new System.Drawing.Size(256, 30);
            this.DeleteRecipe.TabIndex = 8;
            this.DeleteRecipe.Text = "Delete Row";
            this.DeleteRecipe.UseVisualStyleBackColor = true;
            this.DeleteRecipe.Click += new System.EventHandler(this.DeleteRecipe_Click);
            // 
            // StuffGridView
            // 
            this.StuffGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuffGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StuffGridView.Location = new System.Drawing.Point(379, 39);
            this.StuffGridView.Name = "StuffGridView";
            this.StuffGridView.Size = new System.Drawing.Size(256, 307);
            this.StuffGridView.TabIndex = 9;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Recipes";
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StuffGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recipeGridView;
        private System.Windows.Forms.BindingSource recipeBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowRecipeBtn;
        private System.Windows.Forms.Button back_to_manager;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button DeleteRecipe;
        private System.Windows.Forms.DataGridView StuffGridView;
        
    }
}