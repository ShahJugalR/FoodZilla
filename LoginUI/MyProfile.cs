using LoginUI.CustomClasses;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using FoodZilla.Properties;


namespace LoginUI
{

    public partial class MyProfile : Form
    {

        float currentVersion;
        float latestVersion;

        ChangePassword changeUI = new ChangePassword();

        MyOrders orderUI = new MyOrders();

        UpdateDetails updateDetailsUI = new UpdateDetails();


        public SqlConnection connection = new SqlConnection();

        public MyProfile()
        {
            InitializeComponent();

            SignedinasLabel.Text = $"Welcome Back, {Settings.Default["LoggedUser"].ToString()}";


        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            LoginForm loginUI = new LoginForm(false);
            loginUI.Show();
            this.Close();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (changeUI.IsDisposed)
            {
                changeUI = new ChangePassword();
                changeUI.connection = connection;

            }
                    
            changeUI.Show();
            changeUI.Focus();

        }


        private void checkForUpdate() {

            string CMDText = "SELECT * FROM LatestUpdate;";



            SqlCommand cmd = new SqlCommand(CMDText, connection);
            try
            {
                if (connection.ConnectionString == "") {
                    connection.ConnectionString = @"Data Source=DBMS-hotelDB.mssql.somee.com;Initial Catalog=DBMS-hotelDB;Persist Security Info=True;User ID=shahjugalr_SQLLogin_1;Password=akhqbsikty";
                }


                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                try
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            latestVersion = float.Parse(reader[0].ToString());
                        }
                    }
                }

                catch (Exception e)
                {
                    
                    latestVersion = currentVersion;
                }




            }
            catch (Exception er) {

                latestVersion = currentVersion;
            }

            if (latestVersion == currentVersion)
            {
                CheckForUpdatesButton.Visible = false;
                UpdateAvailableLabel.Visible = false;
                CheckForUpdatesButton.Enabled = false;
                UpdateAvailableLabel.Enabled = false;
            }
            else
            {
                CheckForUpdatesButton.Visible = true;
                UpdateAvailableLabel.Visible = true;
                CheckForUpdatesButton.Enabled = true;
                UpdateAvailableLabel.Enabled = true;

                UpdateAvailableLabel.Text = $"v{latestVersion} available !";

            }

        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

            currentVersion = float.Parse(Settings.Default["version"].ToString());

            checkForUpdate();
            VersionNo.Text = $"v{currentVersion.ToString()}";
        }

        private void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1n_-zTP74xi7t4nD8Vth1XHcZ9XdoOatM/view?usp=sharing");
            //System.Diagnostics.Process.Start("https://doc-0k-2k-docs.googleusercontent.com/docs/securesc/uhqelpsgoqbtd75c1emk25146bkh77ga/pqet1ricfrsoe1l9g8anvbivbsravtek/1616232150000/13217960582775608700/13217960582775608700/1n_-zTP74xi7t4nD8Vth1XHcZ9XdoOatM?e=download&authuser=1&nonce=oqov2m1et6aj2&user=13217960582775608700&hash=ualdtt1f3pm9o8r4h56l5br54tagm8sj");
        }

        private void myOrdersButton_Click(object sender, EventArgs e)
        {
            if (orderUI.IsDisposed)
            {
                orderUI = new MyOrders();
            }

            orderUI.connection = connection;
            orderUI.Show();

            orderUI.Focus();
            
        }

        private void UserProfileSettingsButton_Click(object sender, EventArgs e)
        {

            if (updateDetailsUI.IsDisposed)
            {
                updateDetailsUI = new UpdateDetails();
            }

            updateDetailsUI.connection = connection;
            updateDetailsUI.Show();

            updateDetailsUI.Focus();
        }

        private void reportBugButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/13ZSj1VpL48AUkhbqmAs6csweKiRKrcIr/view?usp=sharing");
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
