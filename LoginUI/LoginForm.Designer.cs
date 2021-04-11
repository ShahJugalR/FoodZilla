
namespace LoginUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.LoginUsernameField = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginPasswordField = new System.Windows.Forms.TextBox();
            this.TroubleLoggingButton = new System.Windows.Forms.Button();
            this.newHereButton = new System.Windows.Forms.Button();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.LoginCaptchaField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.picture = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
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
            // LoginUsernameField
            // 
            this.LoginUsernameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LoginUsernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginUsernameField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsernameField.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginUsernameField.Location = new System.Drawing.Point(71, 168);
            this.LoginUsernameField.Multiline = true;
            this.LoginUsernameField.Name = "LoginUsernameField";
            this.LoginUsernameField.Size = new System.Drawing.Size(355, 47);
            this.LoginUsernameField.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.UsernameLabel.Location = new System.Drawing.Point(66, 124);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(69, 28);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "EMAIL";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.PasswordLabel.Location = new System.Drawing.Point(68, 239);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(118, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "PASSWORD";
            // 
            // LoginPasswordField
            // 
            this.LoginPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LoginPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginPasswordField.Location = new System.Drawing.Point(73, 283);
            this.LoginPasswordField.Multiline = true;
            this.LoginPasswordField.Name = "LoginPasswordField";
            this.LoginPasswordField.PasswordChar = '*';
            this.LoginPasswordField.Size = new System.Drawing.Size(355, 47);
            this.LoginPasswordField.TabIndex = 3;
            // 
            // TroubleLoggingButton
            // 
            this.TroubleLoggingButton.BackColor = System.Drawing.Color.Transparent;
            this.TroubleLoggingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TroubleLoggingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TroubleLoggingButton.FlatAppearance.BorderSize = 0;
            this.TroubleLoggingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TroubleLoggingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TroubleLoggingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TroubleLoggingButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroubleLoggingButton.ForeColor = System.Drawing.SystemColors.Window;
            this.TroubleLoggingButton.Location = new System.Drawing.Point(326, 553);
            this.TroubleLoggingButton.Name = "TroubleLoggingButton";
            this.TroubleLoggingButton.Size = new System.Drawing.Size(157, 47);
            this.TroubleLoggingButton.TabIndex = 7;
            this.TroubleLoggingButton.Text = "TROUBLE LOGGING?";
            this.TroubleLoggingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TroubleLoggingButton.UseVisualStyleBackColor = false;
            this.TroubleLoggingButton.Click += new System.EventHandler(this.TroubleLoggingButton_Click);
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
            this.newHereButton.Location = new System.Drawing.Point(12, 553);
            this.newHereButton.Name = "newHereButton";
            this.newHereButton.Size = new System.Drawing.Size(275, 47);
            this.newHereButton.TabIndex = 8;
            this.newHereButton.Text = "NEW HERE? CREATE ACCOUNT FOR FREE";
            this.newHereButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newHereButton.UseVisualStyleBackColor = false;
            this.newHereButton.Click += new System.EventHandler(this.newHereButton_Click);
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.BackColor = System.Drawing.Color.Transparent;
            this.captchaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captchaLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.captchaLabel.Location = new System.Drawing.Point(68, 352);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(99, 28);
            this.captchaLabel.TabIndex = 10;
            this.captchaLabel.Text = "CAPTCHA";
            // 
            // LoginCaptchaField
            // 
            this.LoginCaptchaField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.LoginCaptchaField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginCaptchaField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCaptchaField.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginCaptchaField.Location = new System.Drawing.Point(73, 396);
            this.LoginCaptchaField.Multiline = true;
            this.LoginCaptchaField.Name = "LoginCaptchaField";
            this.LoginCaptchaField.Size = new System.Drawing.Size(155, 47);
            this.LoginCaptchaField.TabIndex = 11;
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
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(71, 488);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(357, 47);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Location = new System.Drawing.Point(250, 347);
            this.picture.Name = "picture";
            this.picture.ShadowDecoration.Parent = this.picture;
            this.picture.Size = new System.Drawing.Size(178, 96);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            this.picture.UseTransparentBackground = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 612);
            this.ControlBox = false;
            this.Controls.Add(this.picture);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginCaptchaField);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.newHereButton);
            this.Controls.Add(this.TroubleLoggingButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginPasswordField);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LoginUsernameField);
            this.Controls.Add(this.SignInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.TextBox LoginUsernameField;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginPasswordField;
        private System.Windows.Forms.Button TroubleLoggingButton;
        private System.Windows.Forms.Button newHereButton;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.TextBox LoginCaptchaField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2PictureBox picture;
    }
}

