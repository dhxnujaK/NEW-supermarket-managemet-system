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
    public partial class ManageCustomers : Form
    {
        // Fetch connection string from App.config
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

        public ManageCustomers()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTable";
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into CustomerTable values('" + Customerid.Text + "', '" + Customername.Text + "', '" + Customerphone.Text + "' )", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form is loading...");
            populate();
        }
        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customerid.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            Customername.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            Customerphone.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from OrdersTable where CustId = " + Customerid.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Orderlabel.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("Select Sum(TotalAmt) from OrdersTable where CustId = " + Customerid.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Amountlabel.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select Max(OrderDate) from OrdersTable where CustId = " + Customerid.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            Datelabel.Text = dt2.Rows[0][0].ToString();

            Con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("update CustomerTable set Custname = '" + Customername.Text + "', Custphone = '" + Customerphone.Text + "' where Custid = '" + Customerid.Text + "' ", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
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
            if (Customerid.Text == "")
            {
                MessageBox.Show("Enter The Customers  ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTable where Custid='" + Customerid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Customername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageCustomers_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
