
namespace LoginUI
{
    partial class ForgottenPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgottenPassword));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.RequestOTP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailAddressField = new System.Windows.Forms.TextBox();
            this.EmailAdressLabel = new System.Windows.Forms.Label();
            this.newHereButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignInLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInLabel.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLabel.ForeColor = System.Drawing.Color.White;
            this.SignInLabel.Location = new System.Drawing.Point(29, 9);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(454, 97);
            this.SignInLabel.TabIndex = 0;
            this.SignInLabel.Text = "FoodZilla";
            // 
            // RequestOTP
            // 
            this.RequestOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.RequestOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RequestOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RequestOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestOTP.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestOTP.ForeColor = System.Drawing.Color.White;
            this.RequestOTP.Location = new System.Drawing.Point(71, 275);
            this.RequestOTP.Name = "RequestOTP";
            this.RequestOTP.Size = new System.Drawing.Size(355, 47);
            this.RequestOTP.TabIndex = 5;
            this.RequestOTP.Text = "REQUEST OTP";
            this.RequestOTP.UseVisualStyleBackColor = false;
            this.RequestOTP.Click += new System.EventHandler(this.LoginButton_Click);
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
            // EmailAddressField
            // 
            this.EmailAddressField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.EmailAddressField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressField.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailAddressField.Location = new System.Drawing.Point(71, 174);
            this.EmailAddressField.Multiline = true;
            this.EmailAddressField.Name = "EmailAddressField";
            this.EmailAddressField.Size = new System.Drawing.Size(355, 47);
            this.EmailAddressField.TabIndex = 14;
            // 
            // EmailAdressLabel
            // 
            this.EmailAdressLabel.AutoSize = true;
            this.EmailAdressLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailAdressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAdressLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailAdressLabel.Location = new System.Drawing.Point(66, 130);
            this.EmailAdressLabel.Name = "EmailAdressLabel";
            this.EmailAdressLabel.Size = new System.Drawing.Size(69, 28);
            this.EmailAdressLabel.TabIndex = 13;
            this.EmailAdressLabel.Text = "EMAIL";
            // 
            // newHereButton
            // 
            this.newHereButton.BackColor = System.Drawing.Color.Transparent;
            this.newHereButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newHereButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newHereButton.FlatAppearance.BorderSize = 0;
            this.newHereButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newHereButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newHereButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newHereButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHereButton.ForeColor = System.Drawing.SystemColors.Window;
            this.newHereButton.Location = new System.Drawing.Point(15, 377);
            this.newHereButton.Name = "newHereButton";
            this.newHereButton.Size = new System.Drawing.Size(275, 47);
            this.newHereButton.TabIndex = 15;
            this.newHereButton.Text = "CAME BY MISTAKE? SIGN IN";
            this.newHereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newHereButton.UseVisualStyleBackColor = false;
            this.newHereButton.Click += new System.EventHandler(this.newHereButton_Click);
            // 
            // ForgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 436);
            this.ControlBox = false;
            this.Controls.Add(this.newHereButton);
            this.Controls.Add(this.EmailAddressField);
            this.Controls.Add(this.EmailAdressLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RequestOTP);
            this.Controls.Add(this.SignInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgottenPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgottenPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Button RequestOTP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EmailAddressField;
        private System.Windows.Forms.Label EmailAdressLabel;
        private System.Windows.Forms.Button newHereButton;
    }
}

