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
            this.back_to_manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_to_manager
            // 
            this.back_to_manager.Location = new System.Drawing.Point(400, 335);
            this.back_to_manager.Name = "back_to_manager";
            this.back_to_manager.Size = new System.Drawing.Size(149, 23);
            this.back_to_manager.TabIndex = 0;
            this.back_to_manager.Text = "Back to manager routine";
            this.back_to_manager.UseVisualStyleBackColor = true;
            this.back_to_manager.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 370);
            this.Controls.Add(this.back_to_manager);
            this.Name = "Recipes";
            this.Text = "Recipes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_to_manager;
    }
}