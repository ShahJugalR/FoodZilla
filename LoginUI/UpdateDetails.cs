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
    public partial class UpdateDetails : Form
    {

        public SqlConnection connection;

        public UpdateDetails() {

            InitializeComponent();

        }

        private void ExistingUserButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (connection.State == ConnectionState.Closed)
                {
                    connection.OpenAsync();
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }

            LoginForm form = new LoginForm(false);
            form.Show();
            this.Close();

        }
     

        private void LoginButton_Click(object sender, EventArgs e)
        {

            string cmdtext = $"[dbo].[customer_update_details] '{Settings.Default["LoggedUsername"].ToString()}', '{name.Text}', '{Adress.Text}' ;";


            SqlCommand cmd = new SqlCommand(cmdtext, connection);


            if (name.Text == "" || Adress.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else {

                try {

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.OpenAsync();
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Updation Successful");
                        this.Close();
                    }
                    catch (SqlException E)
                    {
                        MessageBox.Show(E.Message);
                    }
                }
                catch (Exception ev) {
                    MessageBox.Show(ev.Message);
                }

            }
            

        }

    }
}
