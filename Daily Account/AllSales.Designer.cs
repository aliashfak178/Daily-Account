
namespace Daily_Account
{
    partial class AllSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FilterButton = new Guna.UI2.WinForms.Guna2Button();
            this.FilterComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SalesDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(230, 34);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(89, 29);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.Parent = this.SearchTextBox;
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.FocusedState.Parent = this.SearchTextBox;
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.HoverState.Parent = this.SearchTextBox;
            this.SearchTextBox.Location = new System.Drawing.Point(433, 27);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.ShadowDecoration.Parent = this.SearchTextBox;
            this.SearchTextBox.Size = new System.Drawing.Size(268, 36);
            this.SearchTextBox.TabIndex = 8;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.Animated = true;
            this.FilterButton.AutoRoundedCorners = true;
            this.FilterButton.BorderRadius = 21;
            this.FilterButton.CheckedState.Parent = this.FilterButton;
            this.FilterButton.CustomImages.Parent = this.FilterButton;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.FilterButton.ForeColor = System.Drawing.Color.White;
            this.FilterButton.HoverState.Parent = this.FilterButton;
            this.FilterButton.Location = new System.Drawing.Point(707, 24);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.ShadowDecoration.Parent = this.FilterButton;
            this.FilterButton.Size = new System.Drawing.Size(194, 45);
            this.FilterButton.TabIndex = 7;
            this.FilterButton.Text = "Filter";
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FilterComboBox
            // 
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
            this.FilterComboBox.Items.AddRange(new object[] {
            "By Bill Number",
            "By Recever Name",
            "By Date"});
            this.FilterComboBox.ItemsAppearance.Parent = this.FilterComboBox;
            this.FilterComboBox.Location = new System.Drawing.Point(12, 27);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.ShadowDecoration.Parent = this.FilterComboBox;
            this.FilterComboBox.Size = new System.Drawing.Size(271, 36);
            this.FilterComboBox.TabIndex = 6;
            // 
            // SalesDataGridView
            // 
            this.SalesDataGridView.AllowUserToAddRows = false;
            this.SalesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SalesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SalesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SalesDataGridView.ColumnHeadersHeight = 42;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SalesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SalesDataGridView.EnableHeadersVisualStyles = false;
            this.SalesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDataGridView.Location = new System.Drawing.Point(12, 98);
            this.SalesDataGridView.Name = "SalesDataGridView";
            this.SalesDataGridView.ReadOnly = true;
            this.SalesDataGridView.RowHeadersVisible = false;
            this.SalesDataGridView.RowTemplate.Height = 40;
            this.SalesDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SalesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesDataGridView.Size = new System.Drawing.Size(889, 449);
            this.SalesDataGridView.TabIndex = 5;
            this.SalesDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.SalesDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SalesDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SalesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SalesDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SalesDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SalesDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SalesDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SalesDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SalesDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SalesDataGridView.ThemeStyle.HeaderStyle.Height = 42;
            this.SalesDataGridView.ThemeStyle.ReadOnly = true;
            this.SalesDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SalesDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.SalesDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SalesDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SalesDataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.SalesDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SalesDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AllSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 570);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.SalesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllSales";
            this.Load += new System.EventHandler(this.AllSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Button FilterButton;
        private Guna.UI2.WinForms.Guna2ComboBox FilterComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView SalesDataGridView;
    }
}