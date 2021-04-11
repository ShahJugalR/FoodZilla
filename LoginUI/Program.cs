using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodZilla.Properties;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace LoginUI
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm form = new LoginForm(true);


            form.Show();

            Application.Run();
        }

    }
}
