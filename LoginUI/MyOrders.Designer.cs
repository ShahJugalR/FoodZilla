
namespace LoginUI
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restaurant_name = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Show_items_table = new System.Windows.Forms.DataGridView();
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
            this.Restaurant_name.Size = new System.Drawing.Size(241, 65);
            this.Restaurant_name.TabIndex = 13;
            this.Restaurant_name.Text = "My Orders";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::FoodZilla.Properties.Resources.NicePng_close_icon_png_470104;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(971, 9);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 31;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Show_items_table
            // 
            this.Show_items_table.AllowUserToAddRows = false;
            this.Show_items_table.AllowUserToDeleteRows = false;
            this.Show_items_table.AllowUserToResizeColumns = false;
            this.Show_items_table.AllowUserToResizeRows = false;
            this.Show_items_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Show_items_table.BackgroundColor = System.Drawing.Color.White;
            this.Show_items_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Show_items_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Show_items_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Show_items_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Show_items_table.EnableHeadersVisualStyles = false;
            this.Show_items_table.GridColor = System.Drawing.Color.White;
            this.Show_items_table.Location = new System.Drawing.Point(23, 78);
            this.Show_items_table.MultiSelect = false;
            this.Show_items_table.Name = "Show_items_table";
            this.Show_items_table.ReadOnly = true;
            this.Show_items_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Show_items_table.RowHeadersVisible = false;
            this.Show_items_table.RowHeadersWidth = 51;
            this.Show_items_table.RowTemplate.Height = 24;
            this.Show_items_table.ShowCellToolTips = false;
            this.Show_items_table.Size = new System.Drawing.Size(1012, 555);
            this.Show_items_table.TabIndex = 32;
            this.Show_items_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show_restaurants_table_CellClick);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 645);
            this.ControlBox = false;
            this.Controls.Add(this.Show_items_table);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.Restaurant_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Show_items_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Restaurant_name;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.DataGridView Show_items_table;
    }
}

