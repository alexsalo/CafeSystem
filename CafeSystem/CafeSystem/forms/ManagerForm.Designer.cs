namespace CafeSystem
{
    partial class ManagerForm
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
            this.viewRecipes = new System.Windows.Forms.Button();
            this.back_to_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewRecipes
            // 
            this.viewRecipes.Location = new System.Drawing.Point(12, 12);
            this.viewRecipes.Name = "viewRecipes";
            this.viewRecipes.Size = new System.Drawing.Size(128, 59);
            this.viewRecipes.TabIndex = 0;
            this.viewRecipes.Text = "Look up for recipes";
            this.viewRecipes.UseVisualStyleBackColor = true;
            this.viewRecipes.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_to_main
            // 
            this.back_to_main.Location = new System.Drawing.Point(138, 205);
            this.back_to_main.Name = "back_to_main";
            this.back_to_main.Size = new System.Drawing.Size(134, 45);
            this.back_to_main.TabIndex = 1;
            this.back_to_main.Text = "Back to main screen";
            this.back_to_main.UseVisualStyleBackColor = true;
            this.back_to_main.Click += new System.EventHandler(this.back_to_main_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.back_to_main);
            this.Controls.Add(this.viewRecipes);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewRecipes;
        private System.Windows.Forms.Button back_to_main;
    }
}