
namespace LoginUI
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            this.SignedinasLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.reportBugButton = new System.Windows.Forms.Button();
            this.VersionNo = new System.Windows.Forms.Label();
            this.CheckForUpdatesButton = new System.Windows.Forms.Button();
            this.UserProfileSettingsButton = new System.Windows.Forms.Button();
            this.AvatarImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateAvailableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignedinasLabel
            // 
            this.SignedinasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignedinasLabel.AutoSize = true;
            this.SignedinasLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignedinasLabel.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignedinasLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.SignedinasLabel.Location = new System.Drawing.Point(182, 138);
            this.SignedinasLabel.Name = "SignedinasLabel";
            this.SignedinasLabel.Size = new System.Drawing.Size(137, 32);
            this.SignedinasLabel.TabIndex = 2;
            this.SignedinasLabel.Text = "MY PROFILE";
            this.SignedinasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ChangePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.White;
            this.ChangePasswordButton.Location = new System.Drawing.Point(71, 413);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(355, 47);
            this.ChangePasswordButton.TabIndex = 5;
            this.ChangePasswordButton.Text = "CHANGE PASSWORD";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogOutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LogOutButton.Location = new System.Drawing.Point(12, 500);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(275, 47);
            this.LogOutButton.TabIndex = 14;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.myOrdersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myOrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myOrdersButton.FlatAppearance.BorderSize = 0;
            this.myOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myOrdersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myOrdersButton.ForeColor = System.Drawing.Color.White;
            this.myOrdersButton.Location = new System.Drawing.Point(71, 313);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(355, 47);
            this.myOrdersButton.TabIndex = 15;
            this.myOrdersButton.Text = "MY ORDERS";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // reportBugButton
            // 
            this.reportBugButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.reportBugButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportBugButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBugButton.FlatAppearance.BorderSize = 0;
            this.reportBugButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBugButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBugButton.ForeColor = System.Drawing.Color.White;
            this.reportBugButton.Location = new System.Drawing.Point(71, 213);
            this.reportBugButton.Name = "reportBugButton";
            this.reportBugButton.Size = new System.Drawing.Size(355, 47);
            this.reportBugButton.TabIndex = 16;
            this.reportBugButton.Text = "REPORT A BUG";
            this.reportBugButton.UseVisualStyleBackColor = false;
            // 
            // VersionNo
            // 
            this.VersionNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionNo.AutoSize = true;
            this.VersionNo.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNo.ForeColor = System.Drawing.Color.White;
            this.VersionNo.Location = new System.Drawing.Point(413, 511);
            this.VersionNo.Name = "VersionNo";
            this.VersionNo.Size = new System.Drawing.Size(80, 23);
            this.VersionNo.TabIndex = 18;
            this.VersionNo.Text = "v0.2(Beta)";
            // 
            // CheckForUpdatesButton
            // 
            this.CheckForUpdatesButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdatesButton.BackgroundImage = global::FoodZilla.Properties.Resources.CheckForUpdates;
            this.CheckForUpdatesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckForUpdatesButton.FlatAppearance.BorderSize = 0;
            this.CheckForUpdatesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckForUpdatesButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.CheckForUpdatesButton.Location = new System.Drawing.Point(12, 12);
            this.CheckForUpdatesButton.Name = "CheckForUpdatesButton";
            this.CheckForUpdatesButton.Size = new System.Drawing.Size(50, 40);
            this.CheckForUpdatesButton.TabIndex = 20;
            this.CheckForUpdatesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CheckForUpdatesButton.UseVisualStyleBackColor = false;
            this.CheckForUpdatesButton.Click += new System.EventHandler(this.CheckForUpdatesButton_Click);
            // 
            // UserProfileSettingsButton
            // 
            this.UserProfileSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserProfileSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.UserProfileSettingsButton.BackgroundImage = global::FoodZilla.Properties.Resources.SettingsIcon;
            this.UserProfileSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserProfileSettingsButton.FlatAppearance.BorderSize = 0;
            this.UserProfileSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserProfileSettingsButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.UserProfileSettingsButton.Location = new System.Drawing.Point(453, 12);
            this.UserProfileSettingsButton.Name = "UserProfileSettingsButton";
            this.UserProfileSettingsButton.Size = new System.Drawing.Size(40, 40);
            this.UserProfileSettingsButton.TabIndex = 19;
            this.UserProfileSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UserProfileSettingsButton.UseVisualStyleBackColor = false;
            this.UserProfileSettingsButton.Click += new System.EventHandler(this.UserProfileSettingsButton_Click);
            // 
            // AvatarImage
            // 
            this.AvatarImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvatarImage.BackColor = System.Drawing.Color.Transparent;
            this.AvatarImage.Image = global::FoodZilla.Properties.Resources.UserAvatar;
            this.AvatarImage.Location = new System.Drawing.Point(197, 23);
            this.AvatarImage.Name = "AvatarImage";
            this.AvatarImage.Size = new System.Drawing.Size(100, 100);
            this.AvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarImage.TabIndex = 17;
            this.AvatarImage.TabStop = false;
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
            // UpdateAvailableLabel
            // 
            this.UpdateAvailableLabel.AutoSize = true;
            this.UpdateAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.UpdateAvailableLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 8.2F);
            this.UpdateAvailableLabel.ForeColor = System.Drawing.Color.White;
            this.UpdateAvailableLabel.Location = new System.Drawing.Point(12, 55);
            this.UpdateAvailableLabel.Name = "UpdateAvailableLabel";
            this.UpdateAvailableLabel.Size = new System.Drawing.Size(102, 19);
            this.UpdateAvailableLabel.TabIndex = 21;
            this.UpdateAvailableLabel.Text = "v0.22 Available!";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 560);
            this.Controls.Add(this.UpdateAvailableLabel);
            this.Controls.Add(this.CheckForUpdatesButton);
            this.Controls.Add(this.UserProfileSettingsButton);
            this.Controls.Add(this.VersionNo);
            this.Controls.Add(this.AvatarImage);
            this.Controls.Add(this.reportBugButton);
            this.Controls.Add(this.myOrdersButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.SignedinasLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SignedinasLabel;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button myOrdersButton;
        private System.Windows.Forms.Button reportBugButton;
        private System.Windows.Forms.PictureBox AvatarImage;
        private System.Windows.Forms.Label VersionNo;
        private System.Windows.Forms.Button UserProfileSettingsButton;
        private System.Windows.Forms.Button CheckForUpdatesButton;
        private System.Windows.Forms.Label UpdateAvailableLabel;
    }
}

