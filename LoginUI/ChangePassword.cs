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
using FoodZilla.Properties;

namespace LoginUI
{

    public partial class ChangePassword : Form
    {

        public SqlConnection connection = new SqlConnection();


        public string emailAddress = "";


        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ComeByMistakeButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm(false);
            form.Show();
            this.Close();
        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            Proceed.Enabled = false;

            if (OldPasswordField.Text == Settings.Default["LoggedUserPassword"].ToString())
            {
                if (NewPasswordField.Text == ConfirmNewPasswordField.Text)
                {
                   // string cmdtext = $"UPDATE credentials  SET PASSWORD = '{NewPasswordField.Text}' WHERE username = '{Settings.Default["LoggedUsername"].ToString()}'";

                    string cmdtext = $"[dbo].[change_password] '{Settings.Default["LoggedUsername"].ToString()}' , '{NewPasswordField.Text}'";


                    SqlCommand cmd = new SqlCommand(cmdtext, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed");
                        Settings.Default["LoggedUserPassword"] = NewPasswordField.Text;
                        Settings.Default.Save();


                        this.Close();

                    }
                    catch (Exception eror)
                    {
                        MessageBox.Show(eror.Message);
                    }
                }
                else {
                    MessageBox.Show("Both Passwords must Match!");
                }


                Proceed.Enabled = true;
            }
        }

    }
}
