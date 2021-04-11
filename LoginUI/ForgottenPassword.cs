using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginUI.CustomClasses;
using Microsoft.Data.SqlClient;

namespace LoginUI
{
    public partial class ForgottenPassword : Form
    {
        public SqlConnection connection = new SqlConnection();

        public ForgottenPassword()
        {
            InitializeComponent();
        }

        private void newHereButton_Click(object sender, EventArgs e)
        {
            LoginForm logui = new LoginForm(false);
            logui.doReconnection = false;
            this.Close();
            logui.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ResetPassword resetUI = new ResetPassword(EmailAddressField.Text);
            resetUI.connection = connection;
            resetUI.Show();
            this.Close();
        }
    }
}
