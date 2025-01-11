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
using System.Configuration;

namespace DataBase_System1
{
    public partial class ManageProducts : Form
    {

        public ManageProducts()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageProducts_Load);
        }
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
        void fillcategory()
        {
            string query = "select * from CategoryTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Catname", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                Catcombo.ValueMember = "Catname";
                Catcombo.DataSource = dt;
                Searchcombo.ValueMember = "Catname";
                Searchcombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTable";
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
        void filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTable where ProdCat = '" + Searchcombo.SelectedValue.ToString() + "'";
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into ProductTable values('" + Productid.Text + "', '" + Productname.Text + "', '" + Productqty.Text + "', '" + Productprice.Text + "', '" + Catcombo.SelectedValue.ToString() + "' )", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Productid.Text == "")
            {
                MessageBox.Show("Enter The Customers  ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTable where ProdId='" + Productid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Productid.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            Productname.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            Productqty.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            Productprice.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            Catcombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("update ProductTable set Prodname = '" + Productname.Text + "', ProdQty = '" + Productqty.Text + "', ProdPrice = '" + Productprice.Text + "', ProdCat = '" + Catcombo.SelectedValue.ToString() + "' where ProdId = " + Productid.Text + " ", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
