
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
            this.components = new System.ComponentModel.Container();
            this.ExitButton = new Guna.UI2.WinForms.Guna2Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutlinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReportButton = new Guna.UI2.WinForms.Guna2Button();
            this.StatisticsButton = new Guna.UI2.WinForms.Guna2Button();
            this.StockButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.PurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PurchasePanel = new System.Windows.Forms.Panel();
            this.DeletePurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateRecordsButton = new Guna.UI2.WinForms.Guna2Button();
            this.DisplayPurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddPurchaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesPanel = new System.Windows.Forms.Panel();
            this.DeleteSalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateSalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.DisplaySalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddSalesButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.PurchasePanel.SuspendLayout();
            this.SalesPanel.SuspendLayout();
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
            this.ExitButton.Location = new System.Drawing.Point(3, 3);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.LogoutlinkLabel);
            this.panel1.Controls.Add(this.ExitButton);
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
            // HomeButton
            // 
            this.HomeButton.Animated = true;
            this.HomeButton.BorderRadius = 10;
            this.HomeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.HomeButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.HomeButton.CheckedState.Parent = this.HomeButton;
            this.HomeButton.CustomImages.Parent = this.HomeButton;
            this.HomeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.HoverState.Parent = this.HomeButton;
            this.HomeButton.Location = new System.Drawing.Point(64, 117);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.ShadowDecoration.Parent = this.HomeButton;
            this.HomeButton.Size = new System.Drawing.Size(180, 45);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // LogoutlinkLabel
            // 
            this.LogoutlinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutlinkLabel.AutoSize = true;
            this.LogoutlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutlinkLabel.LinkColor = System.Drawing.Color.White;
            this.LogoutlinkLabel.Location = new System.Drawing.Point(74, 565);
            this.LogoutlinkLabel.Name = "LogoutlinkLabel";
            this.LogoutlinkLabel.Size = new System.Drawing.Size(87, 29);
            this.LogoutlinkLabel.TabIndex = 5;
            this.LogoutlinkLabel.TabStop = true;
            this.LogoutlinkLabel.Text = "Logout";
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
            this.ReportButton.Location = new System.Drawing.Point(64, 372);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.ShadowDecoration.Parent = this.ReportButton;
            this.ReportButton.Size = new System.Drawing.Size(180, 45);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "Reports";
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
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
            this.StatisticsButton.Location = new System.Drawing.Point(64, 321);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.ShadowDecoration.Parent = this.StatisticsButton;
            this.StatisticsButton.Size = new System.Drawing.Size(180, 45);
            this.StatisticsButton.TabIndex = 3;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
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
            this.StockButton.Location = new System.Drawing.Point(64, 270);
            this.StockButton.Name = "StockButton";
            this.StockButton.ShadowDecoration.Parent = this.StockButton;
            this.StockButton.Size = new System.Drawing.Size(180, 45);
            this.StockButton.TabIndex = 2;
            this.StockButton.Text = "Stock";
            this.StockButton.Click += new System.EventHandler(this.StockButton_Click);
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
            this.SalesButton.Location = new System.Drawing.Point(64, 219);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.ShadowDecoration.Parent = this.SalesButton;
            this.SalesButton.Size = new System.Drawing.Size(180, 45);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Sales";
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
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
            this.PurchaseButton.Location = new System.Drawing.Point(64, 168);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.ShadowDecoration.Parent = this.PurchaseButton;
            this.PurchaseButton.Size = new System.Drawing.Size(180, 45);
            this.PurchaseButton.TabIndex = 0;
            this.PurchaseButton.Text = "purchase";
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DashBoardPanel.BackColor = System.Drawing.Color.White;
            this.DashBoardPanel.Location = new System.Drawing.Point(259, 24);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(929, 609);
            this.DashBoardPanel.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.DashBoardPanel;
            // 
            // PurchasePanel
            // 
            this.PurchasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.PurchasePanel.Controls.Add(this.DeletePurchaseButton);
            this.PurchasePanel.Controls.Add(this.UpdateRecordsButton);
            this.PurchasePanel.Controls.Add(this.DisplayPurchaseButton);
            this.PurchasePanel.Controls.Add(this.AddPurchaseButton);
            this.PurchasePanel.Location = new System.Drawing.Point(256, 189);
            this.PurchasePanel.Name = "PurchasePanel";
            this.PurchasePanel.Size = new System.Drawing.Size(200, 198);
            this.PurchasePanel.TabIndex = 6;
            // 
            // DeletePurchaseButton
            // 
            this.DeletePurchaseButton.Animated = true;
            this.DeletePurchaseButton.BorderRadius = 5;
            this.DeletePurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeletePurchaseButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DeletePurchaseButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeletePurchaseButton.CheckedState.Parent = this.DeletePurchaseButton;
            this.DeletePurchaseButton.CustomImages.Parent = this.DeletePurchaseButton;
            this.DeletePurchaseButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DeletePurchaseButton.ForeColor = System.Drawing.Color.White;
            this.DeletePurchaseButton.HoverState.Parent = this.DeletePurchaseButton;
            this.DeletePurchaseButton.Location = new System.Drawing.Point(4, 148);
            this.DeletePurchaseButton.Name = "DeletePurchaseButton";
            this.DeletePurchaseButton.ShadowDecoration.Parent = this.DeletePurchaseButton;
            this.DeletePurchaseButton.Size = new System.Drawing.Size(194, 45);
            this.DeletePurchaseButton.TabIndex = 0;
            this.DeletePurchaseButton.Text = "Delete Purchase";
            this.DeletePurchaseButton.Click += new System.EventHandler(this.DeletePurchaseButton_Click);
            // 
            // UpdateRecordsButton
            // 
            this.UpdateRecordsButton.Animated = true;
            this.UpdateRecordsButton.BorderRadius = 5;
            this.UpdateRecordsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdateRecordsButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdateRecordsButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateRecordsButton.CheckedState.Parent = this.UpdateRecordsButton;
            this.UpdateRecordsButton.CustomImages.Parent = this.UpdateRecordsButton;
            this.UpdateRecordsButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.UpdateRecordsButton.ForeColor = System.Drawing.Color.White;
            this.UpdateRecordsButton.HoverState.Parent = this.UpdateRecordsButton;
            this.UpdateRecordsButton.Location = new System.Drawing.Point(3, 100);
            this.UpdateRecordsButton.Name = "UpdateRecordsButton";
            this.UpdateRecordsButton.ShadowDecoration.Parent = this.UpdateRecordsButton;
            this.UpdateRecordsButton.Size = new System.Drawing.Size(194, 45);
            this.UpdateRecordsButton.TabIndex = 0;
            this.UpdateRecordsButton.Text = "Updated Purchase";
            this.UpdateRecordsButton.Click += new System.EventHandler(this.UpdateRecordsButton_Click);
            // 
            // DisplayPurchaseButton
            // 
            this.DisplayPurchaseButton.Animated = true;
            this.DisplayPurchaseButton.BorderRadius = 5;
            this.DisplayPurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DisplayPurchaseButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DisplayPurchaseButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DisplayPurchaseButton.CheckedState.Parent = this.DisplayPurchaseButton;
            this.DisplayPurchaseButton.CustomImages.Parent = this.DisplayPurchaseButton;
            this.DisplayPurchaseButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DisplayPurchaseButton.ForeColor = System.Drawing.Color.White;
            this.DisplayPurchaseButton.HoverState.Parent = this.DisplayPurchaseButton;
            this.DisplayPurchaseButton.Location = new System.Drawing.Point(3, 51);
            this.DisplayPurchaseButton.Name = "DisplayPurchaseButton";
            this.DisplayPurchaseButton.ShadowDecoration.Parent = this.DisplayPurchaseButton;
            this.DisplayPurchaseButton.Size = new System.Drawing.Size(194, 45);
            this.DisplayPurchaseButton.TabIndex = 0;
            this.DisplayPurchaseButton.Text = "Display All Purchases";
            this.DisplayPurchaseButton.Click += new System.EventHandler(this.DisplayPurchaseButton_Click);
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Animated = true;
            this.AddPurchaseButton.BorderRadius = 5;
            this.AddPurchaseButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddPurchaseButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddPurchaseButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddPurchaseButton.CheckedState.Parent = this.AddPurchaseButton;
            this.AddPurchaseButton.CustomImages.Parent = this.AddPurchaseButton;
            this.AddPurchaseButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.AddPurchaseButton.ForeColor = System.Drawing.Color.White;
            this.AddPurchaseButton.HoverState.Parent = this.AddPurchaseButton;
            this.AddPurchaseButton.Location = new System.Drawing.Point(3, 3);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.ShadowDecoration.Parent = this.AddPurchaseButton;
            this.AddPurchaseButton.Size = new System.Drawing.Size(194, 45);
            this.AddPurchaseButton.TabIndex = 1;
            this.AddPurchaseButton.Text = "Add Purchase";
            this.AddPurchaseButton.Click += new System.EventHandler(this.AddPurchaseButton_Click);
            // 
            // SalesPanel
            // 
            this.SalesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.SalesPanel.Controls.Add(this.DeleteSalesButton);
            this.SalesPanel.Controls.Add(this.UpdateSalesButton);
            this.SalesPanel.Controls.Add(this.DisplaySalesButton);
            this.SalesPanel.Controls.Add(this.AddSalesButton);
            this.SalesPanel.Location = new System.Drawing.Point(256, 240);
            this.SalesPanel.Name = "SalesPanel";
            this.SalesPanel.Size = new System.Drawing.Size(200, 198);
            this.SalesPanel.TabIndex = 7;
            // 
            // DeleteSalesButton
            // 
            this.DeleteSalesButton.Animated = true;
            this.DeleteSalesButton.BorderRadius = 5;
            this.DeleteSalesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DeleteSalesButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DeleteSalesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeleteSalesButton.CheckedState.Parent = this.DeleteSalesButton;
            this.DeleteSalesButton.CustomImages.Parent = this.DeleteSalesButton;
            this.DeleteSalesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DeleteSalesButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSalesButton.HoverState.Parent = this.DeleteSalesButton;
            this.DeleteSalesButton.Location = new System.Drawing.Point(4, 148);
            this.DeleteSalesButton.Name = "DeleteSalesButton";
            this.DeleteSalesButton.ShadowDecoration.Parent = this.DeleteSalesButton;
            this.DeleteSalesButton.Size = new System.Drawing.Size(194, 45);
            this.DeleteSalesButton.TabIndex = 0;
            this.DeleteSalesButton.Text = "Delete Sales";
            this.DeleteSalesButton.Click += new System.EventHandler(this.DeleteSalesButton_Click);
            // 
            // UpdateSalesButton
            // 
            this.UpdateSalesButton.Animated = true;
            this.UpdateSalesButton.BorderRadius = 5;
            this.UpdateSalesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdateSalesButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdateSalesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateSalesButton.CheckedState.Parent = this.UpdateSalesButton;
            this.UpdateSalesButton.CustomImages.Parent = this.UpdateSalesButton;
            this.UpdateSalesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.UpdateSalesButton.ForeColor = System.Drawing.Color.White;
            this.UpdateSalesButton.HoverState.Parent = this.UpdateSalesButton;
            this.UpdateSalesButton.Location = new System.Drawing.Point(3, 100);
            this.UpdateSalesButton.Name = "UpdateSalesButton";
            this.UpdateSalesButton.ShadowDecoration.Parent = this.UpdateSalesButton;
            this.UpdateSalesButton.Size = new System.Drawing.Size(194, 45);
            this.UpdateSalesButton.TabIndex = 0;
            this.UpdateSalesButton.Text = "Updated Sales";
            this.UpdateSalesButton.Click += new System.EventHandler(this.UpdateSalesButton_Click);
            // 
            // DisplaySalesButton
            // 
            this.DisplaySalesButton.Animated = true;
            this.DisplaySalesButton.BorderRadius = 5;
            this.DisplaySalesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DisplaySalesButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.DisplaySalesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DisplaySalesButton.CheckedState.Parent = this.DisplaySalesButton;
            this.DisplaySalesButton.CustomImages.Parent = this.DisplaySalesButton;
            this.DisplaySalesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.DisplaySalesButton.ForeColor = System.Drawing.Color.White;
            this.DisplaySalesButton.HoverState.Parent = this.DisplaySalesButton;
            this.DisplaySalesButton.Location = new System.Drawing.Point(3, 51);
            this.DisplaySalesButton.Name = "DisplaySalesButton";
            this.DisplaySalesButton.ShadowDecoration.Parent = this.DisplaySalesButton;
            this.DisplaySalesButton.Size = new System.Drawing.Size(194, 45);
            this.DisplaySalesButton.TabIndex = 0;
            this.DisplaySalesButton.Text = "Display All Sales";
            this.DisplaySalesButton.Click += new System.EventHandler(this.DisplaySalesButton_Click);
            // 
            // AddSalesButton
            // 
            this.AddSalesButton.Animated = true;
            this.AddSalesButton.BorderRadius = 5;
            this.AddSalesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddSalesButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddSalesButton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddSalesButton.CheckedState.Parent = this.AddSalesButton;
            this.AddSalesButton.CustomImages.Parent = this.AddSalesButton;
            this.AddSalesButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.AddSalesButton.ForeColor = System.Drawing.Color.White;
            this.AddSalesButton.HoverState.Parent = this.AddSalesButton;
            this.AddSalesButton.Location = new System.Drawing.Point(3, 3);
            this.AddSalesButton.Name = "AddSalesButton";
            this.AddSalesButton.ShadowDecoration.Parent = this.AddSalesButton;
            this.AddSalesButton.Size = new System.Drawing.Size(194, 45);
            this.AddSalesButton.TabIndex = 1;
            this.AddSalesButton.Text = "Add Sales";
            this.AddSalesButton.Click += new System.EventHandler(this.AddSalesButton_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.SalesPanel);
            this.Controls.Add(this.PurchasePanel);
            this.Controls.Add(this.DashBoardPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PurchasePanel.ResumeLayout(false);
            this.SalesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ExitButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LogoutlinkLabel;
        private Guna.UI2.WinForms.Guna2Button ReportButton;
        private Guna.UI2.WinForms.Guna2Button StatisticsButton;
        private Guna.UI2.WinForms.Guna2Button StockButton;
        private Guna.UI2.WinForms.Guna2Button SalesButton;
        private Guna.UI2.WinForms.Guna2Button PurchaseButton;
        private System.Windows.Forms.Panel DashBoardPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button HomeButton;
        private System.Windows.Forms.Panel PurchasePanel;
        private Guna.UI2.WinForms.Guna2Button AddPurchaseButton;
        private Guna.UI2.WinForms.Guna2Button DeletePurchaseButton;
        private Guna.UI2.WinForms.Guna2Button UpdateRecordsButton;
        private Guna.UI2.WinForms.Guna2Button DisplayPurchaseButton;
        private System.Windows.Forms.Panel SalesPanel;
        private Guna.UI2.WinForms.Guna2Button DeleteSalesButton;
        private Guna.UI2.WinForms.Guna2Button UpdateSalesButton;
        private Guna.UI2.WinForms.Guna2Button DisplaySalesButton;
        private Guna.UI2.WinForms.Guna2Button AddSalesButton;
    }
}