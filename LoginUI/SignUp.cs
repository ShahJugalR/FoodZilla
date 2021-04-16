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
    public partial class SignUpForm : Form
    {


        Dictionary<int, string> imagesLink =
new Dictionary<int, string>();

        Dictionary<int, string> imagesSolution =
new Dictionary<int, string>();

        string currentSolution;
        string currentImageLink;

        public SqlConnection connection;

        public SignUpForm()
        {
            InitializeComponent();
            imagesLink.Add(1, "https://www.scienceabc.com/wp-content/uploads/2016/07/Captcha-ex.jpg");
            imagesLink.Add(2, "https://cdn.neow.in/news/images/uploaded/captcha-racer_funny_captcha.gif");
            imagesLink.Add(3, "http://www.robindavid.fr/images/opencv-tutorial/captcha/Captcha.png");
            imagesLink.Add(4, "https://www.technotification.com/wp-content/uploads/2014/12/captcha.jpg");

            imagesSolution.Add(1, "smwm");
            imagesSolution.Add(2, "CAPTCHA");
            imagesSolution.Add(3, "P4A2H");
            imagesSolution.Add(4, "qGphJD");

            reloadCaptcha();
        }

        private void ExistingUserButton_Click(object sender, EventArgs e)
        {

            LoginForm form = new LoginForm(false);
            form.Show();
            this.Close();
        }
        public void reloadCaptcha()
        {



            Random r = new Random();

            int value = r.Next(1, 4);

            currentImageLink = imagesLink[value];
            currentSolution = imagesSolution[value];

            picture.ImageLocation = currentImageLink;


            picture.LoadAsync();



        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            LoginButton.Enabled = false;

            if (LoginUsernameField.Text != "" && LoginPasswordField1.Text != "" && LoginPasswordField2.Text != "" && LoginNameField.Text != "" && LoginCaptchaField.Text != "")
            {
                if (LoginCaptchaField.Text == currentSolution)
                {
                    if (LoginPasswordField1.Text == LoginPasswordField2.Text)
                    {
                        this.Enabled = false;
                        SignUp();
                        this.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Both Passwords must be same");
                        reloadCaptcha();
                    }

                }
                else {
                    MessageBox.Show("Wrong Captcha");
                    reloadCaptcha();
                }
            }
            else {
                MessageBox.Show("Pls Fill All information");
                
                    reloadCaptcha();
;            }


            LoginButton.Enabled = true;
        }

        private void SignUp()
        {
            //string cmdText = $"INSERT INTO CREDENTIALS(username, name, password) VALUES('{LoginUsernameField.Text}', '{LoginNameField.Text}', '{LoginPasswordField1.Text}'); ";

            string cmdText = $"[dbo].[Create_User] '{LoginUsernameField.Text}', '{LoginNameField.Text}', '{LoginPasswordField1.Text}'; ";

            SqlCommand cmd = new SqlCommand(cmdText, connection);



            AccountVerify VerifyUI = new AccountVerify(LoginUsernameField.Text);

            VerifyUI.connection = connection;



            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("UserCreated Successfully");
                VerifyUI.Show();
                this.Hide();
            }
            catch (SqlException eror)
            {
                MessageBox.Show(eror.Errors[1].Message);
            }


        }
    }
}
