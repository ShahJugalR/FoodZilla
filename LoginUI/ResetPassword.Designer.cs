
namespace LoginUI
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.Proceed = new System.Windows.Forms.Button();
            this.OTPLabel = new System.Windows.Forms.Label();
            this.OTPField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Verify = new System.Windows.Forms.Button();
            this.NewPasswordField = new System.Windows.Forms.TextBox();
            this.NEWPASSWORDLABEL = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordField = new System.Windows.Forms.TextBox();
            this.CONFIRMPASSWORDLABEL = new System.Windows.Forms.Label();
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
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameLabel.Location = new System.Drawing.Point(66, 124);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(258, 28);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "WE HAVE SENT AN OTP TO";
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proceed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.ForeColor = System.Drawing.Color.White;
            this.Proceed.Location = new System.Drawing.Point(71, 600);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(355, 47);
            this.Proceed.TabIndex = 5;
            this.Proceed.Text = "PROCEED";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // OTPLabel
            // 
            this.OTPLabel.AutoSize = true;
            this.OTPLabel.BackColor = System.Drawing.Color.Transparent;
            this.OTPLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.OTPLabel.Location = new System.Drawing.Point(66, 239);
            this.OTPLabel.Name = "OTPLabel";
            this.OTPLabel.Size = new System.Drawing.Size(113, 28);
            this.OTPLabel.TabIndex = 10;
            this.OTPLabel.Text = "ENTER OTP";
            // 
            // OTPField
            // 
            this.OTPField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.OTPField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OTPField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPField.ForeColor = System.Drawing.SystemColors.Window;
            this.OTPField.Location = new System.Drawing.Point(71, 283);
            this.OTPField.Multiline = true;
            this.OTPField.Name = "OTPField";
            this.OTPField.Size = new System.Drawing.Size(155, 47);
            this.OTPField.TabIndex = 11;
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
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailLabel.Location = new System.Drawing.Point(66, 173);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(219, 28);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "\"j*******@****.*om\"";
            // 
            // Verify
            // 
            this.Verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Verify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Verify.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verify.ForeColor = System.Drawing.Color.White;
            this.Verify.Location = new System.Drawing.Point(232, 283);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(194, 47);
            this.Verify.TabIndex = 15;
            this.Verify.Text = "VERIFY";
            this.Verify.UseVisualStyleBackColor = false;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // NewPasswordField
            // 
            this.NewPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.NewPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.NewPasswordField.Location = new System.Drawing.Point(71, 392);
            this.NewPasswordField.Multiline = true;
            this.NewPasswordField.Name = "NewPasswordField";
            this.NewPasswordField.Size = new System.Drawing.Size(355, 47);
            this.NewPasswordField.TabIndex = 17;
            // 
            // NEWPASSWORDLABEL
            // 
            this.NEWPASSWORDLABEL.AutoSize = true;
            this.NEWPASSWORDLABEL.BackColor = System.Drawing.Color.Transparent;
            this.NEWPASSWORDLABEL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWPASSWORDLABEL.ForeColor = System.Drawing.SystemColors.Window;
            this.NEWPASSWORDLABEL.Location = new System.Drawing.Point(66, 348);
            this.NEWPASSWORDLABEL.Name = "NEWPASSWORDLABEL";
            this.NEWPASSWORDLABEL.Size = new System.Drawing.Size(232, 28);
            this.NEWPASSWORDLABEL.TabIndex = 16;
            this.NEWPASSWORDLABEL.Text = "ENTER NEW PASSWORD";
            // 
            // ConfirmNewPasswordField
            // 
            this.ConfirmNewPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ConfirmNewPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmNewPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.ConfirmNewPasswordField.Location = new System.Drawing.Point(71, 514);
            this.ConfirmNewPasswordField.Multiline = true;
            this.ConfirmNewPasswordField.Name = "ConfirmNewPasswordField";
            this.ConfirmNewPasswordField.Size = new System.Drawing.Size(355, 47);
            this.ConfirmNewPasswordField.TabIndex = 19;
            // 
            // CONFIRMPASSWORDLABEL
            // 
            this.CONFIRMPASSWORDLABEL.AutoSize = true;
            this.CONFIRMPASSWORDLABEL.BackColor = System.Drawing.Color.Transparent;
            this.CONFIRMPASSWORDLABEL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFIRMPASSWORDLABEL.ForeColor = System.Drawing.SystemColors.Window;
            this.CONFIRMPASSWORDLABEL.Location = new System.Drawing.Point(66, 470);
            this.CONFIRMPASSWORDLABEL.Name = "CONFIRMPASSWORDLABEL";
            this.CONFIRMPASSWORDLABEL.Size = new System.Drawing.Size(262, 28);
            this.CONFIRMPASSWORDLABEL.TabIndex = 18;
            this.CONFIRMPASSWORDLABEL.Text = "RE-ENTER NEW PASSWORD";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 697);
            this.ControlBox = false;
            this.Controls.Add(this.ConfirmNewPasswordField);
            this.Controls.Add(this.CONFIRMPASSWORDLABEL);
            this.Controls.Add(this.NewPasswordField);
            this.Controls.Add(this.NEWPASSWORDLABEL);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OTPField);
            this.Controls.Add(this.OTPLabel);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.Label OTPLabel;
        private System.Windows.Forms.TextBox OTPField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.TextBox NewPasswordField;
        private System.Windows.Forms.Label NEWPASSWORDLABEL;
        private System.Windows.Forms.TextBox ConfirmNewPasswordField;
        private System.Windows.Forms.Label CONFIRMPASSWORDLABEL;
    }
}

