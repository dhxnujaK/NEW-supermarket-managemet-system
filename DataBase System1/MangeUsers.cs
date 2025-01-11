using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace DataBase_System1
{
    public partial class MangeUsers : Form
    {
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString);
        public MangeUsers()
        {
            InitializeComponent();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("insert into UserTable values('" + Uname.Text + "', '" + Ufullname.Text + "', '" + Upassword.Text + "', '" + Uphone.Text + "' )", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Uphone.Text == "")
            {
                MessageBox.Show("Enter The Users Phone Number");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTable where Uphone='" + Uphone.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MangeUsers_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form is loading...");
            populate();
        }
        private void UsersGV_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            Uname.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            Ufullname.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            Upassword.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            Uphone.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                SqlCommand cmd = new SqlCommand("update UserTable set Uname = '" + Uname.Text + "',Ufullname = '" + Ufullname.Text + "', Upassword = '" + Upassword.Text + "' where Uphone = '" + Uphone.Text + "' ", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
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
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
