namespace CafeSystem
{
    partial class CashierFrom
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
            this.backToMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainBtn
            // 
            this.backToMainBtn.Location = new System.Drawing.Point(28, 30);
            this.backToMainBtn.Name = "backToMainBtn";
            this.backToMainBtn.Size = new System.Drawing.Size(193, 23);
            this.backToMainBtn.TabIndex = 0;
            this.backToMainBtn.Text = "Back to main menu";
            this.backToMainBtn.UseVisualStyleBackColor = true;
            this.backToMainBtn.Click += new System.EventHandler(this.backToMainBtn_Click);
            // 
            // CashierFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.backToMainBtn);
            this.Name = "CashierFrom";
            this.Text = "CashierFrom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainBtn;
    }
}