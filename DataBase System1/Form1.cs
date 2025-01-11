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
    public partial class Form1 : Form
    {
        private const string CorrectUsername = "Ranuga";
        private const string CorrectPassword = "password123";

        // Declare the connection object
        private SqlConnection Con;

        public Form1()
        {
            InitializeComponent();

            // Initialize the connection in the constructor
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            Con = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Load logic here (if needed)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Use parameterized query to prevent SQL injection
                string query = "Select Count(*) from UserTable where Uname = @Uname and Upassword = @Upassword";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Uname", Username.Text);
                cmd.Parameters.AddWithValue("@Upassword", Password.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    SplashForm splash = new SplashForm();
                    splash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
