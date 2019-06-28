namespace POSSystem
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
            this.ItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MidPanel = new System.Windows.Forms.Panel();
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrderAndReceiptLabel = new System.Windows.Forms.Label();
            this.AllOrdersLabel = new System.Windows.Forms.Label();
            this.FinalDateTB = new System.Windows.Forms.TextBox();
            this.TotalPriceTB = new System.Windows.Forms.TextBox();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.CheckItemInfoRB = new System.Windows.Forms.RadioButton();
            this.AddOrderBT = new System.Windows.Forms.Button();
            this.CompleteOrderTB = new System.Windows.Forms.RadioButton();
            this.MidPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ItemsPanel.Location = new System.Drawing.Point(12, 11);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(453, 525);
            this.ItemsPanel.TabIndex = 0;
            // 
            // MidPanel
            // 
            this.MidPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MidPanel.Controls.Add(this.TotalPriceTB);
            this.MidPanel.Controls.Add(this.FinalDateTB);
            this.MidPanel.Location = new System.Drawing.Point(471, 42);
            this.MidPanel.Name = "MidPanel";
            this.MidPanel.Size = new System.Drawing.Size(482, 494);
            this.MidPanel.TabIndex = 1;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrdersPanel.Location = new System.Drawing.Point(959, 42);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(184, 494);
            this.OrdersPanel.TabIndex = 2;
            // 
            // OrderAndReceiptLabel
            // 
            this.OrderAndReceiptLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OrderAndReceiptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderAndReceiptLabel.Location = new System.Drawing.Point(471, 11);
            this.OrderAndReceiptLabel.Name = "OrderAndReceiptLabel";
            this.OrderAndReceiptLabel.Size = new System.Drawing.Size(482, 28);
            this.OrderAndReceiptLabel.TabIndex = 3;
            this.OrderAndReceiptLabel.Text = "ORDER AND RECEIPT";
            this.OrderAndReceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllOrdersLabel
            // 
            this.AllOrdersLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrdersLabel.Location = new System.Drawing.Point(959, 12);
            this.AllOrdersLabel.Name = "AllOrdersLabel";
            this.AllOrdersLabel.Size = new System.Drawing.Size(184, 27);
            this.AllOrdersLabel.TabIndex = 4;
            this.AllOrdersLabel.Text = "ALL ORDERS";
            this.AllOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalDateTB
            // 
            this.FinalDateTB.Location = new System.Drawing.Point(5, 464);
            this.FinalDateTB.Name = "FinalDateTB";
            this.FinalDateTB.Size = new System.Drawing.Size(233, 27);
            this.FinalDateTB.TabIndex = 0;
            this.FinalDateTB.Text = "Enter Final Date";
            // 
            // TotalPriceTB
            // 
            this.TotalPriceTB.Location = new System.Drawing.Point(244, 464);
            this.TotalPriceTB.Name = "TotalPriceTB";
            this.TotalPriceTB.ReadOnly = true;
            this.TotalPriceTB.Size = new System.Drawing.Size(235, 27);
            this.TotalPriceTB.TabIndex = 1;
            this.TotalPriceTB.Text = "Total Price: ";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTB.Location = new System.Drawing.Point(12, 543);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(195, 30);
            this.QuantityTB.TabIndex = 5;
            this.QuantityTB.Text = "Enter Quantity";
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Location = new System.Drawing.Point(214, 543);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(251, 30);
            this.AddNewItemButton.TabIndex = 6;
            this.AddNewItemButton.Text = "Add New Item";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            // 
            // CheckItemInfoRB
            // 
            this.CheckItemInfoRB.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckItemInfoRB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckItemInfoRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckItemInfoRB.Location = new System.Drawing.Point(13, 580);
            this.CheckItemInfoRB.Name = "CheckItemInfoRB";
            this.CheckItemInfoRB.Size = new System.Drawing.Size(452, 38);
            this.CheckItemInfoRB.TabIndex = 7;
            this.CheckItemInfoRB.TabStop = true;
            this.CheckItemInfoRB.Text = "ITEM INFORMATION";
            this.CheckItemInfoRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckItemInfoRB.UseVisualStyleBackColor = true;
            // 
            // AddOrderBT
            // 
            this.AddOrderBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderBT.Location = new System.Drawing.Point(476, 543);
            this.AddOrderBT.Name = "AddOrderBT";
            this.AddOrderBT.Size = new System.Drawing.Size(477, 75);
            this.AddOrderBT.TabIndex = 8;
            this.AddOrderBT.Text = "Add Order";
            this.AddOrderBT.UseVisualStyleBackColor = true;
            // 
            // CompleteOrderTB
            // 
            this.CompleteOrderTB.Appearance = System.Windows.Forms.Appearance.Button;
            this.CompleteOrderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteOrderTB.Location = new System.Drawing.Point(964, 543);
            this.CompleteOrderTB.Name = "CompleteOrderTB";
            this.CompleteOrderTB.Size = new System.Drawing.Size(179, 75);
            this.CompleteOrderTB.TabIndex = 9;
            this.CompleteOrderTB.Text = "COMPLETE ORDER";
            this.CompleteOrderTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CompleteOrderTB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 630);
            this.Controls.Add(this.CompleteOrderTB);
            this.Controls.Add(this.AddOrderBT);
            this.Controls.Add(this.CheckItemInfoRB);
            this.Controls.Add(this.AddNewItemButton);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.AllOrdersLabel);
            this.Controls.Add(this.OrderAndReceiptLabel);
            this.Controls.Add(this.OrdersPanel);
            this.Controls.Add(this.MidPanel);
            this.Controls.Add(this.ItemsPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Point Of Sale";
            this.MidPanel.ResumeLayout(false);
            this.MidPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ItemsPanel;
        private System.Windows.Forms.Panel MidPanel;
        private System.Windows.Forms.FlowLayoutPanel OrdersPanel;
        private System.Windows.Forms.Label OrderAndReceiptLabel;
        private System.Windows.Forms.Label AllOrdersLabel;
        private System.Windows.Forms.TextBox TotalPriceTB;
        private System.Windows.Forms.TextBox FinalDateTB;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Button AddNewItemButton;
        private System.Windows.Forms.RadioButton CheckItemInfoRB;
        private System.Windows.Forms.Button AddOrderBT;
        private System.Windows.Forms.RadioButton CompleteOrderTB;
    }
}

