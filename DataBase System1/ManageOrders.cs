using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace DataBase_System1
{
    public partial class ManageOrders : Form
    {
        // Connection string fetched dynamically from App.config
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

        private DataTable table = new DataTable(); // Declare and initialize DataTable

        public ManageOrders()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageOrders_Load);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Populate Customer Data
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM CustomerTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Populate Product Data
        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM ProductTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Fill Category ComboBox
        void fillcategory()
        {
            string query = "SELECT * FROM CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Catname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Searchcombo.ValueMember = "Catname";
                Searchcombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Update Product Quantity in Database
        void updateproduct(int productId, int newQty)
        {
            try
            {
                string query = "UPDATE ProductTable SET ProdQty = @newQty WHERE ProdId = @productId";
                SqlCommand cmd = new SqlCommand(query, Con);
                if (newQty < 0)
                    MessageBox.Show("Operation Failed");
                else
                {
                    Con.Open();
                    cmd.Parameters.AddWithValue("@newQty", newQty);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    populateproducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillcategory();
            if (table.Columns.Count == 0)
            {
                table.Columns.Add("Num", typeof(int));          // Serial number
                table.Columns.Add("Product", typeof(string));  // Product name
                table.Columns.Add("Quantity", typeof(int));    // Quantity
                table.Columns.Add("UPrice", typeof(int));      // Unit price
                table.Columns.Add("TotPrice", typeof(int));    // Total price
                table.Columns.Add("ProdId", typeof(int));      // Product ID
            }

            OrderGV.DataSource = table;
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customerid.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            Customername.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Searchcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM ProductTable WHERE ProdCat = '" + Searchcombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        int flag = 0;
        int stock;

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            int selectedProductId = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            flag = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implementation remains unchanged
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Implementation remains unchanged
        }

        private void Placeorder_Click(object sender, EventArgs e)
        {
            // Implementation remains unchanged
        }

        private void Vieworder_Click(object sender, EventArgs e)
        {
            // Implementation remains unchanged
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Implementation remains unchanged
        }
    }
}
