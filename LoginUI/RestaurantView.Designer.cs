﻿
namespace LoginUI
{
    partial class RestaurantView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restaurant_name = new System.Windows.Forms.Label();
            this.ITEMField = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.Show_items_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Close = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_items_table)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = resources.GetString("pictureBox1.ImageLocation");
            this.pictureBox1.Location = new System.Drawing.Point(-918, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Restaurant_name
            // 
            this.Restaurant_name.AutoEllipsis = true;
            this.Restaurant_name.AutoSize = true;
            this.Restaurant_name.BackColor = System.Drawing.Color.Transparent;
            this.Restaurant_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restaurant_name.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restaurant_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.Restaurant_name.Location = new System.Drawing.Point(12, 9);
            this.Restaurant_name.Name = "Restaurant_name";
            this.Restaurant_name.Size = new System.Drawing.Size(389, 65);
            this.Restaurant_name.TabIndex = 13;
            this.Restaurant_name.Text = "Search Restaurant";
            // 
            // ITEMField
            // 
            this.ITEMField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ITEMField.DefaultText = "";
            this.ITEMField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ITEMField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ITEMField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ITEMField.DisabledState.Parent = this.ITEMField;
            this.ITEMField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ITEMField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ITEMField.FocusedState.Parent = this.ITEMField;
            this.ITEMField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ITEMField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ITEMField.HoverState.Parent = this.ITEMField;
            this.ITEMField.Location = new System.Drawing.Point(13, 96);
            this.ITEMField.Name = "ITEMField";
            this.ITEMField.PasswordChar = '\0';
            this.ITEMField.PlaceholderText = "BAckend issues Not Frontend issue ";
            this.ITEMField.SelectedText = "";
            this.ITEMField.ShadowDecoration.Parent = this.ITEMField;
            this.ITEMField.Size = new System.Drawing.Size(579, 28);
            this.ITEMField.TabIndex = 31;
            // 
            // SearchButton
            // 
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.CustomImages.Parent = this.SearchButton;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.HoverState.Parent = this.SearchButton;
            this.SearchButton.Location = new System.Drawing.Point(598, 96);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.ShadowDecoration.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(250, 28);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Search";
            this.SearchButton.DoubleClick += new System.EventHandler(this.SearchButton_Click);
            // 
            // Show_items_table
            // 
            this.Show_items_table.AllowUserToAddRows = false;
            this.Show_items_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Show_items_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Show_items_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Show_items_table.BackgroundColor = System.Drawing.Color.White;
            this.Show_items_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Show_items_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Show_items_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Show_items_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Show_items_table.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Show_items_table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Show_items_table.EnableHeadersVisualStyles = false;
            this.Show_items_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_items_table.Location = new System.Drawing.Point(13, 131);
            this.Show_items_table.Name = "Show_items_table";
            this.Show_items_table.ReadOnly = true;
            this.Show_items_table.RowHeadersVisible = false;
            this.Show_items_table.RowHeadersWidth = 51;
            this.Show_items_table.RowTemplate.Height = 24;
            this.Show_items_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Show_items_table.Size = new System.Drawing.Size(1022, 502);
            this.Show_items_table.TabIndex = 33;
            this.Show_items_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Show_items_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Show_items_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Show_items_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Show_items_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Show_items_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Show_items_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Show_items_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_items_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Show_items_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Show_items_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Show_items_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Show_items_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Show_items_table.ThemeStyle.HeaderStyle.Height = 4;
            this.Show_items_table.ThemeStyle.ReadOnly = true;
            this.Show_items_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Show_items_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Show_items_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Show_items_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Show_items_table.ThemeStyle.RowsStyle.Height = 24;
            this.Show_items_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_items_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Show_items_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_restaurants_table_CellClick);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Close.CheckedState.Parent = this.Close;
            this.Close.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.Close.HoverState.Parent = this.Close;
            this.Close.Image = global::FoodZilla.Properties.Resources.NicePng_close_icon_png_470104;
            this.Close.ImageRotate = 0F;
            this.Close.ImageSize = new System.Drawing.Size(30, 30);
            this.Close.IndicateFocus = true;
            this.Close.Location = new System.Drawing.Point(971, 9);
            this.Close.Name = "Close";
            this.Close.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.Close.PressedState.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(64, 54);
            this.Close.TabIndex = 34;
            this.Close.UseTransparentBackground = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // RestaurantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 645);
            this.ControlBox = false;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Show_items_table);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ITEMField);
            this.Controls.Add(this.Restaurant_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurantView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_items_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Restaurant_name;
        private Guna.UI2.WinForms.Guna2TextBox ITEMField;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private Guna.UI2.WinForms.Guna2DataGridView Show_items_table;
        private Guna.UI2.WinForms.Guna2ImageButton Close;
    }
}

