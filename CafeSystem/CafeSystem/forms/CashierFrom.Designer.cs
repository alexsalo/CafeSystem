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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DismissBtn = new System.Windows.Forms.Button();
            this.MakeOrderBtn = new System.Windows.Forms.Button();
            this.DeleteSelectedBtn = new System.Windows.Forms.Button();
            this.ItemsflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orderList = new System.Windows.Forms.ListBox();
            this.totalOrder_tb = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToMainBtn
            // 
            this.backToMainBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backToMainBtn.Location = new System.Drawing.Point(0, 0);
            this.backToMainBtn.Name = "backToMainBtn";
            this.backToMainBtn.Size = new System.Drawing.Size(115, 30);
            this.backToMainBtn.TabIndex = 0;
            this.backToMainBtn.Text = "Back to main menu";
            this.backToMainBtn.UseVisualStyleBackColor = true;
            this.backToMainBtn.Click += new System.EventHandler(this.backToMainBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50315F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteSelectedBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemsflowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.66802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.331975F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 491);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DismissBtn);
            this.panel1.Controls.Add(this.MakeOrderBtn);
            this.panel1.Controls.Add(this.backToMainBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 30);
            this.panel1.TabIndex = 0;
            // 
            // DismissBtn
            // 
            this.DismissBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DismissBtn.Location = new System.Drawing.Point(209, 0);
            this.DismissBtn.Name = "DismissBtn";
            this.DismissBtn.Size = new System.Drawing.Size(110, 30);
            this.DismissBtn.TabIndex = 2;
            this.DismissBtn.Text = "Dismiss";
            this.DismissBtn.UseVisualStyleBackColor = true;
            this.DismissBtn.Click += new System.EventHandler(this.DismissBtn_Click);
            // 
            // MakeOrderBtn
            // 
            this.MakeOrderBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MakeOrderBtn.Location = new System.Drawing.Point(319, 0);
            this.MakeOrderBtn.Name = "MakeOrderBtn";
            this.MakeOrderBtn.Size = new System.Drawing.Size(114, 30);
            this.MakeOrderBtn.TabIndex = 1;
            this.MakeOrderBtn.Text = "Make an order";
            this.MakeOrderBtn.UseVisualStyleBackColor = true;
            this.MakeOrderBtn.Click += new System.EventHandler(this.MakeOrderBtn_Click);
            // 
            // DeleteSelectedBtn
            // 
            this.DeleteSelectedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSelectedBtn.Location = new System.Drawing.Point(444, 457);
            this.DeleteSelectedBtn.Name = "DeleteSelectedBtn";
            this.DeleteSelectedBtn.Size = new System.Drawing.Size(188, 30);
            this.DeleteSelectedBtn.TabIndex = 1;
            this.DeleteSelectedBtn.Text = "Delete selected";
            this.DeleteSelectedBtn.UseVisualStyleBackColor = true;
            this.DeleteSelectedBtn.Click += new System.EventHandler(this.DeleteSelectedBtn_Click);
            // 
            // ItemsflowLayoutPanel1
            // 
            this.ItemsflowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsflowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.ItemsflowLayoutPanel1.Name = "ItemsflowLayoutPanel1";
            this.ItemsflowLayoutPanel1.Size = new System.Drawing.Size(433, 446);
            this.ItemsflowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orderList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalOrder_tb, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(444, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.84305F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.15695F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 446);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // orderList
            // 
            this.orderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(3, 3);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(182, 416);
            this.orderList.TabIndex = 2;
            // 
            // totalOrder_tb
            // 
            this.totalOrder_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalOrder_tb.Location = new System.Drawing.Point(3, 425);
            this.totalOrder_tb.Name = "totalOrder_tb";
            this.totalOrder_tb.Size = new System.Drawing.Size(182, 20);
            this.totalOrder_tb.TabIndex = 0;
            // 
            // CashierFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 491);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CashierFrom";
            this.Text = "CashierFrom";
            this.Load += new System.EventHandler(this.CashierFrom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DismissBtn;
        private System.Windows.Forms.Button MakeOrderBtn;
        private System.Windows.Forms.Button DeleteSelectedBtn;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.FlowLayoutPanel ItemsflowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox totalOrder_tb;
    }
}