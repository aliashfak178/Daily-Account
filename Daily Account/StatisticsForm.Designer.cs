
namespace Daily_Account
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterByYearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PurchaseSalesPiChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PurchaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseSalesPiChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Filter Chart By Year";
            // 
            // FilterByYearComboBox
            // 
            this.FilterByYearComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterByYearComboBox.Animated = true;
            this.FilterByYearComboBox.AutoRoundedCorners = true;
            this.FilterByYearComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterByYearComboBox.BorderRadius = 17;
            this.FilterByYearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterByYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByYearComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByYearComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterByYearComboBox.FocusedState.Parent = this.FilterByYearComboBox;
            this.FilterByYearComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.FilterByYearComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FilterByYearComboBox.HoverState.Parent = this.FilterByYearComboBox;
            this.FilterByYearComboBox.ItemHeight = 30;
            this.FilterByYearComboBox.ItemsAppearance.Parent = this.FilterByYearComboBox;
            this.FilterByYearComboBox.Location = new System.Drawing.Point(287, 31);
            this.FilterByYearComboBox.Name = "FilterByYearComboBox";
            this.FilterByYearComboBox.ShadowDecoration.Parent = this.FilterByYearComboBox;
            this.FilterByYearComboBox.Size = new System.Drawing.Size(276, 36);
            this.FilterByYearComboBox.TabIndex = 6;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterButton.Animated = true;
            this.FilterButton.AutoRoundedCorners = true;
            this.FilterButton.BorderRadius = 21;
            this.FilterButton.CheckedState.Parent = this.FilterButton;
            this.FilterButton.CustomImages.Parent = this.FilterButton;
            this.FilterButton.FillColor = System.Drawing.Color.DarkViolet;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.HoverState.Parent = this.FilterButton;
            this.FilterButton.Location = new System.Drawing.Point(599, 22);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.ShadowDecoration.Parent = this.FilterButton;
            this.FilterButton.Size = new System.Drawing.Size(247, 45);
            this.FilterButton.TabIndex = 15;
            this.FilterButton.Text = "Filter";
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PurchaseSalesPiChart);
            this.panel1.Controls.Add(this.SalesChart);
            this.panel1.Controls.Add(this.PurchaseChart);
            this.panel1.Location = new System.Drawing.Point(17, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 988);
            this.panel1.TabIndex = 16;
            // 
            // PurchaseSalesPiChart
            // 
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Name = "ChartArea1";
            this.PurchaseSalesPiChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.PurchaseSalesPiChart.Legends.Add(legend4);
            this.PurchaseSalesPiChart.Location = new System.Drawing.Point(15, 660);
            this.PurchaseSalesPiChart.Name = "PurchaseSalesPiChart";
            this.PurchaseSalesPiChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "#.## %";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.PurchaseSalesPiChart.Series.Add(series4);
            this.PurchaseSalesPiChart.Size = new System.Drawing.Size(813, 300);
            this.PurchaseSalesPiChart.TabIndex = 1;
            this.PurchaseSalesPiChart.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            title4.ForeColor = System.Drawing.Color.DarkTurquoise;
            title4.Name = "Title1";
            title4.Text = "Purchase And Sales";
            this.PurchaseSalesPiChart.Titles.Add(title4);
            // 
            // SalesChart
            // 
            this.SalesChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesChart.BorderlineColor = System.Drawing.Color.Black;
            this.SalesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.SalesChart.BorderlineWidth = 3;
            chartArea5.Name = "ChartArea1";
            this.SalesChart.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.SalesChart.Legends.Add(legend5);
            this.SalesChart.Location = new System.Drawing.Point(15, 333);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.SalesChart.Series.Add(series5);
            this.SalesChart.Size = new System.Drawing.Size(793, 289);
            this.SalesChart.TabIndex = 0;
            this.SalesChart.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            title5.ForeColor = System.Drawing.Color.BlueViolet;
            title5.Name = "Title1";
            title5.Text = "Total Sales";
            this.SalesChart.Titles.Add(title5);
            // 
            // PurchaseChart
            // 
            this.PurchaseChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseChart.BorderlineColor = System.Drawing.Color.Black;
            this.PurchaseChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.PurchaseChart.BorderlineWidth = 3;
            chartArea6.Name = "ChartArea1";
            this.PurchaseChart.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.PurchaseChart.Legends.Add(legend6);
            this.PurchaseChart.Location = new System.Drawing.Point(15, 19);
            this.PurchaseChart.Name = "PurchaseChart";
            this.PurchaseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.PurchaseChart.Series.Add(series6);
            this.PurchaseChart.Size = new System.Drawing.Size(796, 289);
            this.PurchaseChart.TabIndex = 0;
            this.PurchaseChart.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            title6.ForeColor = System.Drawing.Color.BlueViolet;
            title6.Name = "Title1";
            title6.Text = "Total Purchase";
            this.PurchaseChart.Titles.Add(title6);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilterByYearComboBox);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseSalesPiChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox FilterByYearComboBox;
        private Guna.UI2.WinForms.Guna2Button FilterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PurchaseChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PurchaseSalesPiChart;
    }
}