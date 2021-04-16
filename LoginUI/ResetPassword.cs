using LoginUI.CustomClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginUI
{

    public partial class ResetPassword : Form
    {

        public SqlConnection connection = new SqlConnection();

        Random generator = new Random();

        public string emailAddress = "";

        int verificationCode = new int();

        bool isOTPVerified = false;

        public ResetPassword(string _emailAdress)
        {
            InitializeComponent();

            emailAddress = _emailAdress;

            EmailLabel.Text = _emailAdress;

            verificationCode = generator.Next(100000, 1000000);

            CustomClasses.VerificationMailSender vsender = new VerificationMailSender();

            vsender.SendMail(_emailAdress, verificationCode);

            MessageBox.Show(connection.ServerProcessId.ToString());

        }

        private void ComeByMistakeButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(false);
            form.Show();
            this.Close();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open) {

                connection.Open();
            }


            Proceed.Enabled = false;

            if (isOTPVerified)
            {
                if (NewPasswordField.Text == ConfirmNewPasswordField.Text)
                {
                    //string cmdtext = $"UPDATE credentials  SET PASSWORD = '{NewPasswordField.Text}' WHERE username = '{emailAddress}'";

                    string cmdtext = $"[dbo].[change_password] '{emailAddress}' , '{NewPasswordField.Text}'";


                    SqlCommand cmd = new SqlCommand(cmdtext, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed");

                        LoginForm loginUI = new LoginForm(false);
                        loginUI.Show();

                    }
                    catch (SqlException eror)
                    {
                        MessageBox.Show(eror.Errors[1].Message);
                    }
                }
                else {
                    MessageBox.Show("Both Passwords must Match!");
                }


                Proceed.Enabled = true;
            }
        }

        private void Verify_Click(object sender, EventArgs e)
        {

            Verify.Enabled = false;

            if (verificationCode == Int64.Parse(OTPField.Text))
            {
                isOTPVerified = true;
                OTPLabel.ForeColor = Color.Green;
                OTPLabel.Text = "Correct OTP";
                Verify.Dispose();
                OTPField.Enabled = false;
            }
            else {
                isOTPVerified = false;
                OTPLabel.ForeColor = Color.Red;
                OTPLabel.Text = "Incorrect OTP";
            }

            Verify.Enabled = true;
        }

    }
}
