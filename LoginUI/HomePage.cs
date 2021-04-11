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
    public partial class HomePage : Form
    {


        MyProfile profileUI = new MyProfile();


        DataSet ds = new DataSet();

        public SqlConnection connection = new SqlConnection();
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string cmdtext = "SELECT* FROM test_Restaurant";
            SqlCommand cmd = new SqlCommand(cmdtext, connection);

            using (
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
            {

                dataAdapter.Fill(ds);
                Show_restaurants_table.DataSource = ds.Tables[0];

            }

            DataGridViewButtonColumn btn_cell = new DataGridViewButtonColumn();

            btn_cell.HeaderText = "Visit Hotel";
            btn_cell.Name = "buttonCell";
            btn_cell.Text = "Open";

            btn_cell.UseColumnTextForButtonValue = true;

            Show_restaurants_table.Columns.Add(btn_cell);


        }

        private void LoadProfileButton_Click(object sender, EventArgs e)
        {

            if (profileUI.IsDisposed)
            {
                profileUI = new MyProfile();
            }

            profileUI.Show();


            profileUI.connection = connection;
        }

        private void Show_restaurants_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                DataRow messageText = ds.Tables[0].Rows[e.RowIndex];

                MessageBox.Show(messageText[0].ToString());

                RestaurantView restaurantView = new RestaurantView(messageText[0].ToString());

                restaurantView.connection = connection;

                restaurantView.Show();
            }
        }
    }
}
