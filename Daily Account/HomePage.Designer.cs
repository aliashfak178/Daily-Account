
namespace Daily_Account
{
    partial class HomePage
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
            this.PurchasePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TotalPurchaseAmountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TotalSalesAmountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterButton = new Guna.UI2.WinForms.Guna2Button();
            this.PurchasePanel.SuspendLayout();
            this.SalesPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchasePanel
            // 
            this.PurchasePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchasePanel.BackColor = System.Drawing.Color.White;
            this.PurchasePanel.BorderRadius = 10;
            this.PurchasePanel.BorderThickness = 2;
            this.PurchasePanel.Controls.Add(this.TotalPurchaseAmountLabel);
            this.PurchasePanel.Controls.Add(this.label2);
            this.PurchasePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PurchasePanel.Location = new System.Drawing.Point(104, 225);
            this.PurchasePanel.Name = "PurchasePanel";
            this.PurchasePanel.ShadowDecoration.Parent = this.PurchasePanel;
            this.PurchasePanel.Size = new System.Drawing.Size(338, 187);
            this.PurchasePanel.TabIndex = 0;
            // 
            // TotalPurchaseAmountLabel
            // 
            this.TotalPurchaseAmountLabel.AutoSize = true;
            this.TotalPurchaseAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPurchaseAmountLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPurchaseAmountLabel.Location = new System.Drawing.Point(87, 76);
            this.TotalPurchaseAmountLabel.Name = "TotalPurchaseAmountLabel";
            this.TotalPurchaseAmountLabel.Size = new System.Drawing.Size(40, 45);
            this.TotalPurchaseAmountLabel.TabIndex = 1;
            this.TotalPurchaseAmountLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 76);
            this.label2.TabIndex = 0;
            this.label2.Text = "₹";
            // 
            // SalesPanel
            // 
            this.SalesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesPanel.BackColor = System.Drawing.Color.White;
            this.SalesPanel.BorderColor = System.Drawing.Color.Transparent;
            this.SalesPanel.BorderRadius = 10;
            this.SalesPanel.BorderThickness = 2;
            this.SalesPanel.Controls.Add(this.TotalSalesAmountLabel);
            this.SalesPanel.Controls.Add(this.label3);
            this.SalesPanel.CustomBorderColor = System.Drawing.Color.Black;
            this.SalesPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SalesPanel.Location = new System.Drawing.Point(526, 225);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.ShadowDecoration.Parent = this.SalesPanel;
            this.SalesPanel.Size = new System.Drawing.Size(338, 187);
            this.SalesPanel.TabIndex = 0;
            // 
            // TotalSalesAmountLabel
            // 
            this.TotalSalesAmountLabel.AutoSize = true;
            this.TotalSalesAmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSalesAmountLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesAmountLabel.Location = new System.Drawing.Point(89, 76);
            this.TotalSalesAmountLabel.Name = "TotalSalesAmountLabel";
            this.TotalSalesAmountLabel.Size = new System.Drawing.Size(40, 45);
            this.TotalSalesAmountLabel.TabIndex = 1;
            this.TotalSalesAmountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "₹";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(134, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Purchase";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(551, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 42);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sales";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(913, 570);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(230)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(6, 10);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(894, 550);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filter Amount By Year";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterComboBox.Animated = true;
            this.FilterComboBox.AutoRoundedCorners = true;
            this.FilterComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterComboBox.BorderRadius = 17;
            this.FilterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterComboBox.FocusedState.Parent = this.FilterComboBox;
            this.FilterComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FilterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterComboBox.HoverState.Parent = this.FilterComboBox;
            this.FilterComboBox.ItemHeight = 30;
            this.FilterComboBox.ItemsAppearance.Parent = this.FilterComboBox;
            this.FilterComboBox.Location = new System.Drawing.Point(348, 51);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.ShadowDecoration.Parent = this.FilterComboBox;
            this.FilterComboBox.Size = new System.Drawing.Size(271, 36);
            this.FilterComboBox.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FilterButton.Animated = true;
            this.FilterButton.AutoRoundedCorners = true;
            this.FilterButton.BorderRadius = 21;
            this.FilterButton.CheckedState.Parent = this.FilterButton;
            this.FilterButton.CustomImages.Parent = this.FilterButton;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.HoverState.Parent = this.FilterButton;
            this.FilterButton.Location = new System.Drawing.Point(659, 51);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.ShadowDecoration.Parent = this.FilterButton;
            this.FilterButton.Size = new System.Drawing.Size(194, 45);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SalesPanel);
            this.Controls.Add(this.PurchasePanel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.PurchasePanel.ResumeLayout(false);
            this.PurchasePanel.PerformLayout();
            this.SalesPanel.ResumeLayout(false);
            this.SalesPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PurchasePanel;
        private Guna.UI2.WinForms.Guna2Panel SalesPanel;
        private System.Windows.Forms.Label TotalPurchaseAmountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalSalesAmountLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox FilterComboBox;
        private Guna.UI2.WinForms.Guna2Button FilterButton;
    }
}