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

    public partial class AccountVerify : Form
    {

        public SqlConnection connection = new SqlConnection();

        Random generator = new Random();

        public string emailAddress = "";

        int verificationCode = new int();
        public AccountVerify(string _emailAdress)
        {
            InitializeComponent();

            emailAddress = _emailAdress;

            EmailLabel.Text = _emailAdress;

            verificationCode = generator.Next(100000, 1000000);

            CustomClasses.VerificationMailSender vsender = new VerificationMailSender();

            vsender.SendMail(_emailAdress, verificationCode);
        }

        private void ComeByMistakeButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(false);
            form.Show();
            this.Close();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            if (Int64.Parse(OTPField.Text) == verificationCode)
            {
                MessageBox.Show("Correct OTP");

               // string cmdtext = $"UPDATE credentials  SET isVerified = 1 WHERE username = '{emailAddress}'";


                string cmdtext = $"[dbo].[Verification] '{emailAddress}';";
                SqlCommand cmd = new SqlCommand(cmdtext, connection);
                try
                {
                    cmd.ExecuteNonQuery();

                    LoginForm loginUI = new LoginForm(false);
                    loginUI.Show();
                }
                catch (Exception eror) {
                    MessageBox.Show(eror.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong OTP Renter");
            }
        }
    }
}
