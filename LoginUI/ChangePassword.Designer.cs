
namespace LoginUI
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.SignInLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Proceed = new System.Windows.Forms.Button();
            this.OldPassword = new System.Windows.Forms.Label();
            this.OldPasswordField = new System.Windows.Forms.TextBox();
            this.NEWPASSWORDLABEL = new System.Windows.Forms.Label();
            this.NewPasswordField = new System.Windows.Forms.TextBox();
            this.CONFIRMPASSWORDLABEL = new System.Windows.Forms.Label();
            this.ConfirmNewPasswordField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = resources.GetString("pictureBox1.ImageLocation");
            this.pictureBox1.Location = new System.Drawing.Point(-918, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Proceed
            // 
            this.Proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Proceed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proceed.ForeColor = System.Drawing.Color.White;
            this.Proceed.Location = new System.Drawing.Point(16, 374);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(355, 47);
            this.Proceed.TabIndex = 5;
            this.Proceed.Text = "PROCEED";
            this.Proceed.UseVisualStyleBackColor = false;
            this.Proceed.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // OldPassword
            // 
            this.OldPassword.AutoSize = true;
            this.OldPassword.BackColor = System.Drawing.Color.Transparent;
            this.OldPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.OldPassword.Location = new System.Drawing.Point(11, 13);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(227, 28);
            this.OldPassword.TabIndex = 10;
            this.OldPassword.Text = "ENTER OLD PASSWORD";
            // 
            // OldPasswordField
            // 
            this.OldPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.OldPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.OldPasswordField.Location = new System.Drawing.Point(16, 57);
            this.OldPasswordField.Multiline = true;
            this.OldPasswordField.Name = "OldPasswordField";
            this.OldPasswordField.PasswordChar = '*';
            this.OldPasswordField.Size = new System.Drawing.Size(355, 47);
            this.OldPasswordField.TabIndex = 11;
            // 
            // NEWPASSWORDLABEL
            // 
            this.NEWPASSWORDLABEL.AutoSize = true;
            this.NEWPASSWORDLABEL.BackColor = System.Drawing.Color.Transparent;
            this.NEWPASSWORDLABEL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWPASSWORDLABEL.ForeColor = System.Drawing.SystemColors.Window;
            this.NEWPASSWORDLABEL.Location = new System.Drawing.Point(11, 122);
            this.NEWPASSWORDLABEL.Name = "NEWPASSWORDLABEL";
            this.NEWPASSWORDLABEL.Size = new System.Drawing.Size(232, 28);
            this.NEWPASSWORDLABEL.TabIndex = 16;
            this.NEWPASSWORDLABEL.Text = "ENTER NEW PASSWORD";
            // 
            // NewPasswordField
            // 
            this.NewPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.NewPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.NewPasswordField.Location = new System.Drawing.Point(16, 166);
            this.NewPasswordField.Multiline = true;
            this.NewPasswordField.Name = "NewPasswordField";
            this.NewPasswordField.PasswordChar = '*';
            this.NewPasswordField.Size = new System.Drawing.Size(355, 47);
            this.NewPasswordField.TabIndex = 17;
            // 
            // CONFIRMPASSWORDLABEL
            // 
            this.CONFIRMPASSWORDLABEL.AutoSize = true;
            this.CONFIRMPASSWORDLABEL.BackColor = System.Drawing.Color.Transparent;
            this.CONFIRMPASSWORDLABEL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONFIRMPASSWORDLABEL.ForeColor = System.Drawing.SystemColors.Window;
            this.CONFIRMPASSWORDLABEL.Location = new System.Drawing.Point(11, 244);
            this.CONFIRMPASSWORDLABEL.Name = "CONFIRMPASSWORDLABEL";
            this.CONFIRMPASSWORDLABEL.Size = new System.Drawing.Size(262, 28);
            this.CONFIRMPASSWORDLABEL.TabIndex = 18;
            this.CONFIRMPASSWORDLABEL.Text = "RE-ENTER NEW PASSWORD";
            // 
            // ConfirmNewPasswordField
            // 
            this.ConfirmNewPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ConfirmNewPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmNewPasswordField.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPasswordField.ForeColor = System.Drawing.SystemColors.Window;
            this.ConfirmNewPasswordField.Location = new System.Drawing.Point(16, 288);
            this.ConfirmNewPasswordField.Multiline = true;
            this.ConfirmNewPasswordField.Name = "ConfirmNewPasswordField";
            this.ConfirmNewPasswordField.PasswordChar = '*';
            this.ConfirmNewPasswordField.Size = new System.Drawing.Size(355, 47);
            this.ConfirmNewPasswordField.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfirmNewPasswordField);
            this.panel1.Controls.Add(this.CONFIRMPASSWORDLABEL);
            this.panel1.Controls.Add(this.NewPasswordField);
            this.panel1.Controls.Add(this.NEWPASSWORDLABEL);
            this.panel1.Controls.Add(this.OldPasswordField);
            this.panel1.Controls.Add(this.OldPassword);
            this.panel1.Controls.Add(this.Proceed);
            this.panel1.Location = new System.Drawing.Point(59, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 433);
            this.panel1.TabIndex = 20;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(505, 642);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.Label OldPassword;
        private System.Windows.Forms.TextBox OldPasswordField;
        private System.Windows.Forms.Label NEWPASSWORDLABEL;
        private System.Windows.Forms.TextBox NewPasswordField;
        private System.Windows.Forms.Label CONFIRMPASSWORDLABEL;
        private System.Windows.Forms.TextBox ConfirmNewPasswordField;
        private System.Windows.Forms.Panel panel1;
    }
}

