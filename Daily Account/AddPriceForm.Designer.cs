
namespace Daily_Account
{
    partial class AddPriceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddItemButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Item Name";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Animated = true;
            this.ItemNameTextBox.AutoRoundedCorners = true;
            this.ItemNameTextBox.BorderRadius = 17;
            this.ItemNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemNameTextBox.DefaultText = "";
            this.ItemNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ItemNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ItemNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameTextBox.DisabledState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ItemNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameTextBox.FocusedState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ItemNameTextBox.HoverState.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Location = new System.Drawing.Point(32, 81);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.PasswordChar = '\0';
            this.ItemNameTextBox.PlaceholderText = "";
            this.ItemNameTextBox.SelectedText = "";
            this.ItemNameTextBox.ShadowDecoration.Parent = this.ItemNameTextBox;
            this.ItemNameTextBox.Size = new System.Drawing.Size(487, 36);
            this.ItemNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ItemNameTextBox.TabIndex = 0;
            // 
            // AddItemButton
            // 
            this.AddItemButton.CheckedState.Parent = this.AddItemButton;
            this.AddItemButton.CustomImages.Parent = this.AddItemButton;
            this.AddItemButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.AddItemButton.ForeColor = System.Drawing.Color.White;
            this.AddItemButton.HoverState.Parent = this.AddItemButton;
            this.AddItemButton.Location = new System.Drawing.Point(32, 150);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.ShadowDecoration.Parent = this.AddItemButton;
            this.AddItemButton.Size = new System.Drawing.Size(487, 45);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add New Item";
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click_1);
            // 
            // AddPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 233);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPriceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox ItemNameTextBox;
        private Guna.UI2.WinForms.Guna2Button AddItemButton;
    }
}