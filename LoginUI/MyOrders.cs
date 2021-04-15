/*
 *      Shah Jugal R
 * 
 * 
 */

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
    public partial class MyOrders : Form
    {


        DataSet ds = new DataSet();

        public SqlConnection connection = new SqlConnection();

        
        public MyOrders()
        {
            InitializeComponent();


            Restaurant_name.Text = "My Orders";

        }

        private void LoadData() {
            int rowCount = Show_items_table.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (Show_items_table.Rows[0].IsNewRow == false)
                    Show_items_table.Rows.RemoveAt(0);
            }

            Show_items_table.Refresh();


            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            string cmdtext = $"[dbo].[My_order] {Settings.Default["LoggedUserID"]}";

            SqlCommand cmd = new SqlCommand(cmdtext, connection);

            using (
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
            {

                dataAdapter.Fill(ds);
                Show_items_table.DataSource = ds.Tables[0];

            }
          /*  try
            {
                MessageBox.Show(ds.Tables[0].Rows[1][1].ToString());
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            } */


            DataGridViewButtonColumn btn_cell = new DataGridViewButtonColumn();


            btn_cell.HeaderText = "Cancel Order";
            btn_cell.Name = "buttonCell";
            btn_cell.Text = "X";

            btn_cell.UseColumnTextForButtonValue = true;

            Show_items_table.Columns.Add(btn_cell);

        }


        private void Show_restaurants_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                DataRow messageText = ds.Tables[0].Rows[e.RowIndex];


                string cmdtext = $"[dbo].[CancelOrder] {messageText[0].ToString()}";

                SqlCommand cmd = new SqlCommand(cmdtext, connection);

                try
                {

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order Cancelled");

                }
                catch (Exception eg) {
                    MessageBox.Show(eg.Message);
                }
            }
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
