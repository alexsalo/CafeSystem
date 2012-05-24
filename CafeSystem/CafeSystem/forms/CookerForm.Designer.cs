namespace CafeSystem
{
    partial class CookerForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.viewrecipesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(191, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(81, 64);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewrecipesBtn
            // 
            this.viewrecipesBtn.Location = new System.Drawing.Point(13, 13);
            this.viewrecipesBtn.Name = "viewrecipesBtn";
            this.viewrecipesBtn.Size = new System.Drawing.Size(172, 63);
            this.viewrecipesBtn.TabIndex = 1;
            this.viewrecipesBtn.Text = "Recipes";
            this.viewrecipesBtn.UseVisualStyleBackColor = true;
            this.viewrecipesBtn.Click += new System.EventHandler(this.viewrecipesBtn_Click);
            // 
            // CookerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.ControlBox = false;
            this.Controls.Add(this.viewrecipesBtn);
            this.Controls.Add(this.backBtn);
            this.Name = "CookerForm";
            this.Text = "CookerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button viewrecipesBtn;
    }
}