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

namespace LoginUI
{
    public partial class RestaurantView : Form
    {


        MyProfile profileUI = new MyProfile();


        DataSet ds = new DataSet();

        public SqlConnection connection = new SqlConnection();

        string res_name;
        int res_id;
        
        public RestaurantView(string restaurant_name,int id)
        {
            InitializeComponent();
            res_name = restaurant_name;

            Restaurant_name.Text = res_name;
            res_id = id;

            if (connection.State == ConnectionState.Closed)
            {
                connection.OpenAsync();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.OpenAsync();
            }

            string cmdtext = "";

            if (ITEMField.Text == "")
            {
                cmdtext = $"[dbo].[show_items_of_restaurnat] {res_id}";
            }

            else
            {
                cmdtext = $"[dbo].[show_items_of_restaurnat_by_search] {res_id}, '{ITEMField.Text}'";
            }

            SqlCommand cmd = new SqlCommand(cmdtext, connection);

            using (
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
            {

                dataAdapter.Fill(ds);
                Show_items_table.DataSource = ds.Tables[0];

            }


            DataGridViewButtonColumn btn_cell = new DataGridViewButtonColumn();


            btn_cell.HeaderText = "Add to Cart";
            btn_cell.Name = "buttonCell";
            btn_cell.Text = "add";

            btn_cell.UseColumnTextForButtonValue = true;

            Show_items_table.Columns.Add(btn_cell);


        }


        private void Show_restaurants_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                DataRow messageText = ds.Tables[0].Rows[e.RowIndex];

                MessageBox.Show(messageText[0].ToString());

                try
                {
                    string cmdtext = $"[dbo].[Create_order] 1,1, 500,1,500,8";

                    SqlCommand cmd = new SqlCommand(cmdtext, connection);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ordered Successfully");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
