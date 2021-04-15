/*
 *      Shah Jugal R
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace LoginUI.CustomClasses
{
    class SQLConnectorClass
    {

        public string sqlConnectionString = @"Data Source=DBMS-hotelDB.mssql.somee.com;Initial Catalog=DBMS-hotelDB;Persist Security Info=True;User ID=shahjugalr_SQLLogin_1;Password=akhqbsikty";
        public SqlConnection sqlConnection = new SqlConnection();


        public void Connect() {

            sqlConnection.ConnectionString = sqlConnectionString;

            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
