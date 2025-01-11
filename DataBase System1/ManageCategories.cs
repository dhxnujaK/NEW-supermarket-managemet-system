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
    public partial class ManageCategories : Form
    {
        // Fetch connection string from App.config
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public ManageCategories()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ManageCategories_Load);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into CategoryTable values('" + Categoryid.Text + "', '" + Categoryname.Text + "' )", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form is loading...");
            populate();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Categoryid.Text == "")
            {
                MessageBox.Show("Enter The Category ID");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTable where Catid='" + Categoryid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("update CategoryTable set Catname = '" + Categoryname.Text + "' where Catid = '" + Categoryid.Text + "' ", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                populate();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageCategories_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoryid.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            Categoryname.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
