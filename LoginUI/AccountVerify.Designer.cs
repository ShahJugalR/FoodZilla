
namespace LoginUI
{
    partial class AccountVerify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountVerify));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.OTPField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ComeByMistakeButton = new System.Windows.Forms.Button();
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
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.VerifyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Location = new System.Drawing.Point(71, 406);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(355, 47);
            this.VerifyButton.TabIndex = 5;
            this.VerifyButton.Text = "VERIFY";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.BackColor = System.Drawing.Color.Transparent;
            this.captchaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.captchaLabel.Location = new System.Drawing.Point(66, 239);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(113, 28);
            this.captchaLabel.TabIndex = 10;
            this.captchaLabel.Text = "ENTER OTP";
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
            // ComeByMistakeButton
            // 
            this.ComeByMistakeButton.BackColor = System.Drawing.Color.Transparent;
            this.ComeByMistakeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComeByMistakeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeByMistakeButton.FlatAppearance.BorderSize = 0;
            this.ComeByMistakeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ComeByMistakeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ComeByMistakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComeByMistakeButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComeByMistakeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ComeByMistakeButton.Location = new System.Drawing.Point(12, 474);
            this.ComeByMistakeButton.Name = "ComeByMistakeButton";
            this.ComeByMistakeButton.Size = new System.Drawing.Size(275, 47);
            this.ComeByMistakeButton.TabIndex = 14;
            this.ComeByMistakeButton.Text = "COME BY MISTAKE? SIGN IN";
            this.ComeByMistakeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ComeByMistakeButton.UseVisualStyleBackColor = false;
            this.ComeByMistakeButton.Click += new System.EventHandler(this.ComeByMistakeButton_Click);
            // 
            // AccountVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 533);
            this.ControlBox = false;
            this.Controls.Add(this.ComeByMistakeButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OTPField);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountVerify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountVerify";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.TextBox OTPField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button ComeByMistakeButton;
    }
}

