
namespace Daily_Account
{
    partial class DashBoard
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
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.StockButton = new Guna.UI2.WinForms.Guna2Button();
            this.StatisticsButton = new Guna.UI2.WinForms.Guna2Button();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutlinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Animated = true;
            this.ExitButton.BorderRadius = 4;
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(1112, 26);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(63, 45);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 650);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(255)))), ((int)(((byte)(26)))));
            this.rectangleShape1.BorderWidth = 4;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(1178, 629);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LogoutlinkLabel);
            this.panel1.Controls.Add(this.ReportButton);
            this.panel1.Controls.Add(this.StatisticsButton);
            this.panel1.Controls.Add(this.StockButton);
            this.panel1.Controls.Add(this.SalesButton);
            this.panel1.Controls.Add(this.PurchaseButton);
            this.panel1.Location = new System.Drawing.Point(22, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 612);
            this.panel1.TabIndex = 3;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Animated = true;
            this.PurchaseButton.BorderRadius = 10;
            this.PurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.PurchaseButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.PurchaseButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.PurchaseButton.CheckedState.Parent = this.PurchaseButton;
            this.PurchaseButton.CustomImages.Parent = this.PurchaseButton;
            this.PurchaseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.PurchaseButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.PurchaseButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseButton.HoverState.Parent = this.PurchaseButton;
            this.PurchaseButton.Location = new System.Drawing.Point(64, 123);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.ShadowDecoration.Parent = this.PurchaseButton;
            this.PurchaseButton.Size = new System.Drawing.Size(180, 45);
            this.PurchaseButton.TabIndex = 0;
            this.PurchaseButton.Text = "purchase";
            // 
            // SalesButton
            // 
            this.SalesButton.Animated = true;
            this.SalesButton.BorderRadius = 10;
            this.SalesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SalesButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.SalesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.SalesButton.CheckedState.Parent = this.SalesButton;
            this.SalesButton.CustomImages.Parent = this.SalesButton;
            this.SalesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.SalesButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.HoverState.Parent = this.SalesButton;
            this.SalesButton.Location = new System.Drawing.Point(64, 174);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.ShadowDecoration.Parent = this.SalesButton;
            this.SalesButton.Size = new System.Drawing.Size(180, 45);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Sales";
            // 
            // StockButton
            // 
            this.StockButton.Animated = true;
            this.StockButton.BorderRadius = 10;
            this.StockButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StockButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.StockButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.StockButton.CheckedState.Parent = this.StockButton;
            this.StockButton.CustomImages.Parent = this.StockButton;
            this.StockButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.StockButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.StockButton.ForeColor = System.Drawing.Color.White;
            this.StockButton.HoverState.Parent = this.StockButton;
            this.StockButton.Location = new System.Drawing.Point(64, 225);
            this.StockButton.Name = "StockButton";
            this.StockButton.ShadowDecoration.Parent = this.StockButton;
            this.StockButton.Size = new System.Drawing.Size(180, 45);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Stock";
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Animated = true;
            this.StatisticsButton.BorderRadius = 10;
            this.StatisticsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StatisticsButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.StatisticsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.StatisticsButton.CheckedState.Parent = this.StatisticsButton;
            this.StatisticsButton.CustomImages.Parent = this.StatisticsButton;
            this.StatisticsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.StatisticsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.StatisticsButton.ForeColor = System.Drawing.Color.White;
            this.StatisticsButton.HoverState.Parent = this.StatisticsButton;
            this.StatisticsButton.Location = new System.Drawing.Point(64, 276);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.ShadowDecoration.Parent = this.StatisticsButton;
            this.StatisticsButton.Size = new System.Drawing.Size(180, 45);
            this.StatisticsButton.TabIndex = 3;
            this.StatisticsButton.Text = "Statistics";
            // 
            // ReportButton
            // 
            this.ReportButton.Animated = true;
            this.ReportButton.BorderRadius = 10;
            this.ReportButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ReportButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.ReportButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.ReportButton.CheckedState.Parent = this.ReportButton;
            this.ReportButton.CustomImages.Parent = this.ReportButton;
            this.ReportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.ReportButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ReportButton.ForeColor = System.Drawing.Color.White;
            this.ReportButton.HoverState.Parent = this.ReportButton;
            this.ReportButton.Location = new System.Drawing.Point(64, 327);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.ShadowDecoration.Parent = this.ReportButton;
            this.ReportButton.Size = new System.Drawing.Size(180, 45);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Reports";
            // 
            // LogoutlinkLabel
            // 
            this.LogoutlinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogoutlinkLabel.AutoSize = true;
            this.LogoutlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutlinkLabel.LinkColor = System.Drawing.Color.White;
            this.LogoutlinkLabel.Location = new System.Drawing.Point(59, 565);
            this.LogoutlinkLabel.Name = "LogoutlinkLabel";
            this.LogoutlinkLabel.Size = new System.Drawing.Size(87, 29);
            this.LogoutlinkLabel.TabIndex = 5;
            this.LogoutlinkLabel.TabStop = true;
            this.LogoutlinkLabel.Text = "Logout";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button PurchaseButton;
        private Guna.UI2.WinForms.Guna2Button StatisticsButton;
        private Guna.UI2.WinForms.Guna2Button StockButton;
        private Guna.UI2.WinForms.Guna2Button SalesButton;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private System.Windows.Forms.LinkLabel LogoutlinkLabel;
    }
}