namespace CafeSystem
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.CashierMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manager Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierMode
            // 
            this.CashierMode.Location = new System.Drawing.Point(263, 79);
            this.CashierMode.Name = "CashierMode";
            this.CashierMode.Size = new System.Drawing.Size(165, 114);
            this.CashierMode.TabIndex = 1;
            this.CashierMode.Text = "Cashier Mode";
            this.CashierMode.UseVisualStyleBackColor = true;
            this.CashierMode.Click += new System.EventHandler(this.CashierMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Cafe System 1.0   Alex Salo 2012 (C)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashierMode);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "CafeSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CashierMode;
        private System.Windows.Forms.Label label1;
    }
}

