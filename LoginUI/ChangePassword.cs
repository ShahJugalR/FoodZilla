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
        public string sqlConnectionString = @"Data Source=DBMS-hotelDB.mssql.somee.com;Initial Catalog=DBMS-hotelDB;Persist Security Info=True;User ID=shahjugalr_SQLLogin_1;Password=akhqbsikty";


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


                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.ConnectionString = sqlConnectionString;
                        connection.Open();
                    }


                    SqlCommand cmd = new SqlCommand(cmdtext, connection);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Changed");
                        Settings.Default["LoggedUserPassword"] = NewPasswordField.Text;
                        Settings.Default.Save();


                        this.Close();

                    }
                    catch (SqlException eror)
                    {
                        MessageBox.Show(eror.Errors[1].Message);
                    }
                }
                else
                {
                    MessageBox.Show("Both Passwords must Match!");
                }


            }
            else {

                MessageBox.Show("Old Password Not Correct");
            }

            Proceed.Enabled = true;
        }

    }
}
