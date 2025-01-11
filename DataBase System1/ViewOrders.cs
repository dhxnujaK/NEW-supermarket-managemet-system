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
using Microsoft.Data.SqlClient;

namespace DataBase_System1
{
    public partial class ViewOrders : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ranuga\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30;");
        public ViewOrders()
        {
            InitializeComponent();
        }
        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT * FROM OrdersTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersviewGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Vieworder_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void OrdersviewGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(290,50));
            e.Graphics.DrawString("Order ID: "+OrdersviewGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("Customer ID: " + OrdersviewGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(50, 180));
            e.Graphics.DrawString("Customer Name: " + OrdersviewGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(50, 210));
            e.Graphics.DrawString("Order Date: " + OrdersviewGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(50, 240));
            e.Graphics.DrawString("Total Amount: " + OrdersviewGV.SelectedRows[0].Cells[4].Value.ToString() + "/=", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString("PoweredByCodeBreakers ", new Font("Century", 15, FontStyle.Bold), Brushes.Red, new Point(300, 350));

        }
    }
}
