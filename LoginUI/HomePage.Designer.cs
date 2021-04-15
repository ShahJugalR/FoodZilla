
namespace LoginUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_restaurants_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RestaurantField = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.Profile = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_restaurants_table)).BeginInit();
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
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(122)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 65);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Restaurant";
            // 
            // Show_restaurants_table
            // 
            this.Show_restaurants_table.AllowUserToAddRows = false;
            this.Show_restaurants_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Show_restaurants_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Show_restaurants_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Show_restaurants_table.BackgroundColor = System.Drawing.Color.White;
            this.Show_restaurants_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Show_restaurants_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Show_restaurants_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Show_restaurants_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Show_restaurants_table.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Show_restaurants_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Show_restaurants_table.EnableHeadersVisualStyles = false;
            this.Show_restaurants_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_restaurants_table.Location = new System.Drawing.Point(12, 125);
            this.Show_restaurants_table.Name = "Show_restaurants_table";
            this.Show_restaurants_table.ReadOnly = true;
            this.Show_restaurants_table.RowHeadersVisible = false;
            this.Show_restaurants_table.RowHeadersWidth = 51;
            this.Show_restaurants_table.RowTemplate.Height = 24;
            this.Show_restaurants_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Show_restaurants_table.Size = new System.Drawing.Size(1023, 508);
            this.Show_restaurants_table.TabIndex = 31;
            this.Show_restaurants_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Show_restaurants_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Show_restaurants_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Show_restaurants_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Show_restaurants_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Show_restaurants_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Show_restaurants_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Show_restaurants_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Show_restaurants_table.ThemeStyle.HeaderStyle.Height = 4;
            this.Show_restaurants_table.ThemeStyle.ReadOnly = true;
            this.Show_restaurants_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Show_restaurants_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Show_restaurants_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Show_restaurants_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Show_restaurants_table.ThemeStyle.RowsStyle.Height = 24;
            this.Show_restaurants_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Show_restaurants_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Show_restaurants_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_restaurants_table_CellClick);
            // 
            // RestaurantField
            // 
            this.RestaurantField.Animated = true;
            this.RestaurantField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RestaurantField.DefaultText = "";
            this.RestaurantField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RestaurantField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RestaurantField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RestaurantField.DisabledState.Parent = this.RestaurantField;
            this.RestaurantField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RestaurantField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RestaurantField.FocusedState.Parent = this.RestaurantField;
            this.RestaurantField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RestaurantField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RestaurantField.HoverState.Parent = this.RestaurantField;
            this.RestaurantField.Location = new System.Drawing.Point(13, 97);
            this.RestaurantField.Name = "RestaurantField";
            this.RestaurantField.PasswordChar = '\0';
            this.RestaurantField.PlaceholderText = "Backend Issue Dont use this field  [Not a frontend issue]";
            this.RestaurantField.SelectedText = "";
            this.RestaurantField.ShadowDecoration.Parent = this.RestaurantField;
            this.RestaurantField.Size = new System.Drawing.Size(579, 22);
            this.RestaurantField.TabIndex = 32;
            // 
            // SearchButton
            // 
            this.SearchButton.Animated = true;
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.CustomImages.Parent = this.SearchButton;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.HoverState.Parent = this.SearchButton;
            this.SearchButton.Location = new System.Drawing.Point(598, 94);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.ShadowDecoration.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(207, 25);
            this.SearchButton.TabIndex = 33;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Profile
            // 
            this.Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Profile.Animated = true;
            this.Profile.BackColor = System.Drawing.Color.Transparent;
            this.Profile.BackgroundImage = global::FoodZilla.Properties.Resources.UserAvatar;
            this.Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profile.CheckedState.Parent = this.Profile;
            this.Profile.CustomImages.Parent = this.Profile;
            this.Profile.FillColor = System.Drawing.Color.Transparent;
            this.Profile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Profile.ForeColor = System.Drawing.Color.White;
            this.Profile.HoverState.Parent = this.Profile;
            this.Profile.IndicateFocus = true;
            this.Profile.Location = new System.Drawing.Point(981, 9);
            this.Profile.Name = "Profile";
            this.Profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Profile.ShadowDecoration.Parent = this.Profile;
            this.Profile.Size = new System.Drawing.Size(50, 50);
            this.Profile.TabIndex = 34;
            this.Profile.UseTransparentBackground = true;
            this.Profile.Click += new System.EventHandler(this.LoadProfileButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 645);
            this.ControlBox = false;
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RestaurantField);
            this.Controls.Add(this.Show_restaurants_table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_restaurants_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView Show_restaurants_table;
        private Guna.UI2.WinForms.Guna2TextBox RestaurantField;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private Guna.UI2.WinForms.Guna2CircleButton Profile;
    }
}

