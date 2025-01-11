namespace DataBase_System1
{
    partial class ManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Productprice = new TextBox();
            Productqty = new TextBox();
            Productname = new TextBox();
            Productid = new TextBox();
            label8 = new Label();
            Catcombo = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            label10 = new Label();
            ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Searchcombo = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 169);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1877, 0);
            label9.Name = "label9";
            label9.Size = new Size(47, 47);
            label9.TabIndex = 1;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(824, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(622, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(687, 47);
            label2.TabIndex = 0;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(2005, 0);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 40);
            label7.TabIndex = 0;
            label7.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 922);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 18);
            panel2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label6.Location = new Point(82, 485);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 27);
            label6.TabIndex = 18;
            label6.Text = "ProductPrice:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.Location = new Point(82, 419);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 27);
            label5.TabIndex = 19;
            label5.Text = "ProductQty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label4.Location = new Point(82, 351);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 27);
            label4.TabIndex = 20;
            label4.Text = "ProductName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(82, 282);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 21;
            label3.Text = "ProductID:";
            // 
            // Productprice
            // 
            Productprice.Location = new Point(282, 488);
            Productprice.Margin = new Padding(5, 4, 5, 4);
            Productprice.Name = "Productprice";
            Productprice.Size = new Size(389, 27);
            Productprice.TabIndex = 22;
            // 
            // Productqty
            // 
            Productqty.Location = new Point(282, 422);
            Productqty.Margin = new Padding(5, 4, 5, 4);
            Productqty.Name = "Productqty";
            Productqty.Size = new Size(389, 27);
            Productqty.TabIndex = 23;
            // 
            // Productname
            // 
            Productname.Location = new Point(282, 353);
            Productname.Margin = new Padding(5, 4, 5, 4);
            Productname.Name = "Productname";
            Productname.Size = new Size(389, 27);
            Productname.TabIndex = 24;
            // 
            // Productid
            // 
            Productid.Location = new Point(282, 285);
            Productid.Margin = new Padding(5, 4, 5, 4);
            Productid.Name = "Productid";
            Productid.Size = new Size(389, 27);
            Productid.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label8.Location = new Point(82, 555);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(144, 27);
            label8.TabIndex = 26;
            label8.Text = "Description:";
            // 
            // Catcombo
            // 
            Catcombo.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Catcombo.FormattingEnabled = true;
            Catcombo.Location = new Point(282, 554);
            Catcombo.Name = "Catcombo";
            Catcombo.Size = new Size(237, 29);
            Catcombo.TabIndex = 27;
            Catcombo.Text = "Product Category";
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(259, 648);
            button2.Name = "button2";
            button2.Size = new Size(171, 39);
            button2.TabIndex = 31;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(82, 648);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(169, 39);
            button3.TabIndex = 30;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(82, 727);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(589, 39);
            button4.TabIndex = 28;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(506, 648);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 29;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(1213, 214);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(147, 27);
            label10.TabIndex = 33;
            label10.Text = "Products List";
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductsGV.ColumnHeadersHeight = 30;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductsGV.DefaultCellStyle = dataGridViewCellStyle3;
            ProductsGV.GridColor = Color.FromArgb(231, 229, 255);
            ProductsGV.Location = new Point(708, 319);
            ProductsGV.Margin = new Padding(5, 4, 5, 4);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersVisible = false;
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.RowTemplate.Height = 30;
            ProductsGV.Size = new Size(1202, 595);
            ProductsGV.TabIndex = 32;
            ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductsGV.ThemeStyle.BackColor = Color.White;
            ProductsGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProductsGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductsGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductsGV.ThemeStyle.HeaderStyle.Height = 30;
            ProductsGV.ThemeStyle.ReadOnly = false;
            ProductsGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProductsGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductsGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ProductsGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProductsGV.ThemeStyle.RowsStyle.Height = 30;
            ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProductsGV.CellContentClick += ProductsGV_CellContentClick;
            // 
            // Searchcombo
            // 
            Searchcombo.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Searchcombo.FormattingEnabled = true;
            Searchcombo.Location = new Point(1174, 259);
            Searchcombo.Name = "Searchcombo";
            Searchcombo.Size = new Size(237, 29);
            Searchcombo.TabIndex = 34;
            Searchcombo.Text = "Select Category";
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSeaGreen;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1419, 253);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(165, 39);
            button5.TabIndex = 35;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSeaGreen;
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1583, 253);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(165, 39);
            button6.TabIndex = 36;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 940);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(Searchcombo);
            Controls.Add(label10);
            Controls.Add(ProductsGV);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(Catcombo);
            Controls.Add(label8);
            Controls.Add(Productprice);
            Controls.Add(Productqty);
            Controls.Add(Productname);
            Controls.Add(Productid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label7;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Productprice;
        private TextBox Productqty;
        private TextBox Productname;
        private TextBox Productid;
        private Label label8;
        private ComboBox Catcombo;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private ComboBox Searchcombo;
        private Button button5;
        private Button button6;
    }
}