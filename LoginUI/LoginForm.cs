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
    public partial class LoginForm : Form
    {

        Dictionary<int, string> imagesLink =
new Dictionary<int, string>();

        Dictionary<int, string> imagesSolution =
new Dictionary<int, string>();

        string currentSolution;
        string currentImageLink;

        public bool doReconnection = true;

        SignUpForm signupForm = new SignUpForm();

        ForgottenPassword forgotUI = new ForgottenPassword();

        CustomClasses.SQLConnectorClass SQLconnecter = new CustomClasses.SQLConnectorClass();


        public LoginForm(bool _doReconnection)
        {


            imagesLink.Add(1, "https://www.scienceabc.com/wp-content/uploads/2016/07/Captcha-ex.jpg");
            imagesLink.Add(2, "https://cdn.neow.in/news/images/uploaded/captcha-racer_funny_captcha.gif");
            imagesLink.Add(3, "http://www.robindavid.fr/images/opencv-tutorial/captcha/Captcha.png");
            imagesLink.Add(4, "https://www.technotification.com/wp-content/uploads/2014/12/captcha.jpg");

            imagesSolution.Add(1, "smwm");
            imagesSolution.Add(2, "CAPTCHA");
            imagesSolution.Add(3, "P4A2H");
            imagesSolution.Add(4, "qGphJD");

            InitializeComponent();

            doReconnection = _doReconnection;

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {

            if (LoginPasswordField.Text != "" && LoginUsernameField.Text != "")
            {

                if (LoginCaptchaField.Text != currentSolution)
                {
                    MessageBox.Show("Wrong Captacha");
                    reloadCaptcha();
                }
                else
                {

                    this.Enabled = false;
                    Login();
                    this.Enabled = true;
                }
            }
            else {


                MessageBox.Show("Please Fill All information");
            }

            

        }


        public void Reconnect() {

            if (Settings.Default["LoggedUser"].ToString() != "")
            {

                try
                {

                    CustomClasses.UserCredentialObject t_package = new CustomClasses.UserCredentialObject();

                    //   string cmdtext = "SELECT * FROM CREDENTIALS WHERE username = '" + Settings.Default["LoggedUsername"] + "' and password = '" + Settings.Default["LoggedUserPassword"] + "';";

                    string cmdtext = $"[dbo].[get_User] '{Settings.Default["LoggedUsername"]}';";


                    SqlCommand cmd = new SqlCommand(cmdtext, SQLconnecter.sqlConnection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            t_package.u_id = Int16.Parse(reader["u_id"].ToString());
                            t_package.username = reader["username"].ToString();
                            t_package.password = reader["password"].ToString();
                            t_package.name = reader["name"].ToString();
                        }
                    }

                    if (t_package.name == null)
                    {
                        MessageBox.Show("Invalid Login");
                        Settings.Default.Reset();
                    }
                    else
                    {
                        MessageBox.Show("Relogged Successfully");
                        /*MyProfile profileUI = new MyProfile();

                        profileUI.Show();


                        profileUI.connection = SQLconnecter.sqlConnection;
                        */
                        HomePage home = new HomePage();

                        home.connection = SQLconnecter.sqlConnection;

                        home.Show();


                        this.Close();
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }

        }

        public void Login() {
            // Function to Manage Logins

            CustomClasses.UserCredentialObject t_package = new CustomClasses.UserCredentialObject();

            //string cmdtext = $"SELECT * FROM CREDENTIALS WHERE username = '{LoginUsernameField.Text}' AND password = '{LoginPasswordField.Text}';";
            string cmdtext = $"[dbo].[get_User] '{LoginUsernameField.Text}';"; 
            SqlCommand cmd = new SqlCommand(cmdtext, SQLconnecter.sqlConnection);

            using (SqlDataReader reader = cmd.ExecuteReader()) {

                while (reader.Read())
                {

                    t_package.u_id = Int16.Parse(reader["u_id"].ToString());
                    t_package.username = reader["username"].ToString();
                    t_package.password = reader["password"].ToString();
                    t_package.name = reader["name"].ToString();
                }

                if (t_package.name == null) {
                    MessageBox.Show("Wrong Credentials");
                }
            }

            if (t_package.username == LoginUsernameField.Text) {
                if (t_package.password == LoginPasswordField.Text) {



                    Settings.Default["LoggedUser"] = t_package.name;
                    Settings.Default["LoggedUsername"] = t_package.username;
                    Settings.Default["LoggedUserID"] = t_package.u_id;
                    Settings.Default["LoggedUserPassword"] = t_package.password;
                    Settings.Default.Save();


                    /*MyProfile profileUI = new MyProfile();
                    profileUI.connection = SQLconnecter.sqlConnection;

                    profileUI.Show();*/

                    HomePage home = new HomePage();

                    home.connection = SQLconnecter.sqlConnection;

                    home.Show();

                    this.Close();
                }
            }
        }

        public void reloadCaptcha() {

            

            Random r = new Random();

            int value = r.Next(1, 4);

            currentImageLink = imagesLink[value];
            currentSolution = imagesSolution[value];

                picture.ImageLocation = currentImageLink;


            picture.LoadAsync();



        }


        private void newHereButton_Click(object sender, EventArgs e)
        {
            signupForm.connection = SQLconnecter.sqlConnection;
            signupForm.Show();
            this.Close();
        }

        private void TroubleLoggingButton_Click(object sender, EventArgs e)
        {
            forgotUI.connection = SQLconnecter.sqlConnection;
            forgotUI.Show();

            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SQLconnecter.Connect();   // Connects to server

            reloadCaptcha();

            if (doReconnection)
            {
                Reconnect();
            }


            if (Settings.Default["LoggedUser"].ToString() != "")
            {
                // User is There 
            }
            else
            {
                // User is not Present
            }
        }
    }
}
