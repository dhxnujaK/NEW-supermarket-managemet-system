namespace DataBase_System1
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Orderid = new TextBox();
            label3 = new Label();
            Customerid = new TextBox();
            label4 = new Label();
            Orderdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label5 = new Label();
            Searchcombo = new ComboBox();
            ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Quantitytext = new TextBox();
            label6 = new Label();
            button1 = new Button();
            OrderGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Customername = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Placeorder = new Button();
            Vieworder = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
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
            label1.Location = new Point(843, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(306, 202);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 27);
            label8.TabIndex = 12;
            label8.Text = "Customers List";
            // 
            // CustomersGV
            // 
            dataGridViewCellStyle19.BackColor = Color.White;
            CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle20.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            CustomersGV.ColumnHeadersHeight = 30;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.White;
            dataGridViewCellStyle21.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle21.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle21.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.False;
            CustomersGV.DefaultCellStyle = dataGridViewCellStyle21;
            CustomersGV.GridColor = Color.FromArgb(231, 229, 255);
            CustomersGV.Location = new Point(67, 249);
            CustomersGV.Margin = new Padding(5, 4, 5, 4);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersVisible = false;
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.RowTemplate.Height = 30;
            CustomersGV.Size = new Size(624, 298);
            CustomersGV.TabIndex = 13;
            CustomersGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomersGV.ThemeStyle.BackColor = Color.White;
            CustomersGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomersGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomersGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomersGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomersGV.ThemeStyle.HeaderStyle.Height = 30;
            CustomersGV.ThemeStyle.ReadOnly = false;
            CustomersGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomersGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomersGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CustomersGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomersGV.ThemeStyle.RowsStyle.Height = 30;
            CustomersGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomersGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            // 
            // Orderid
            // 
            Orderid.Location = new Point(292, 577);
            Orderid.Margin = new Padding(5, 4, 5, 4);
            Orderid.Name = "Orderid";
            Orderid.Size = new Size(399, 27);
            Orderid.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label3.Location = new Point(65, 577);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 26;
            label3.Text = "OrderID:";
            // 
            // Customerid
            // 
            Customerid.Location = new Point(292, 632);
            Customerid.Margin = new Padding(5, 4, 5, 4);
            Customerid.Name = "Customerid";
            Customerid.Size = new Size(399, 27);
            Customerid.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label4.Location = new Point(65, 632);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 27);
            label4.TabIndex = 28;
            label4.Text = "CustomerID:";
            // 
            // Orderdate
            // 
            Orderdate.Checked = true;
            Orderdate.CustomizableEdges = customizableEdges5;
            Orderdate.FillColor = Color.DarkTurquoise;
            Orderdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orderdate.Format = DateTimePickerFormat.Long;
            Orderdate.Location = new Point(431, 748);
            Orderdate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            Orderdate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            Orderdate.Name = "Orderdate";
            Orderdate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Orderdate.Size = new Size(260, 31);
            Orderdate.TabIndex = 30;
            Orderdate.Value = new DateTime(2025, 1, 4, 15, 30, 25, 588);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label5.Location = new Point(270, 752);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 27);
            label5.TabIndex = 31;
            label5.Text = "Order Date:";
            // 
            // Searchcombo
            // 
            Searchcombo.Font = new Font("Adobe Gothic Std B", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            Searchcombo.FormattingEnabled = true;
            Searchcombo.Location = new Point(762, 205);
            Searchcombo.Name = "Searchcombo";
            Searchcombo.Size = new Size(246, 29);
            Searchcombo.TabIndex = 36;
            Searchcombo.Text = "Select Category";
            Searchcombo.SelectionChangeCommitted += Searchcombo_SelectionChangeCommitted;
            // 
            // ProductsGV
            // 
            dataGridViewCellStyle22.BackColor = Color.White;
            ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle23.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle23.ForeColor = Color.White;
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.True;
            ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            ProductsGV.ColumnHeadersHeight = 30;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = Color.White;
            dataGridViewCellStyle24.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle24.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle24.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle24.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.False;
            ProductsGV.DefaultCellStyle = dataGridViewCellStyle24;
            ProductsGV.GridColor = Color.FromArgb(231, 229, 255);
            ProductsGV.Location = new Point(762, 249);
            ProductsGV.Margin = new Padding(5, 4, 5, 4);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.RowHeadersVisible = false;
            ProductsGV.RowHeadersWidth = 51;
            ProductsGV.RowTemplate.Height = 30;
            ProductsGV.Size = new Size(1132, 298);
            ProductsGV.TabIndex = 35;
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
            // Quantitytext
            // 
            Quantitytext.Location = new Point(890, 576);
            Quantitytext.Margin = new Padding(5, 4, 5, 4);
            Quantitytext.Name = "Quantitytext";
            Quantitytext.Size = new Size(214, 27);
            Quantitytext.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label6.Location = new Point(767, 576);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 27);
            label6.TabIndex = 37;
            label6.Text = "Quantity:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1114, 570);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 39;
            button1.Text = "Add To Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // OrderGV
            // 
            dataGridViewCellStyle25.BackColor = Color.White;
            OrderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle26.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle26.ForeColor = Color.White;
            dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = DataGridViewTriState.True;
            OrderGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            OrderGV.ColumnHeadersHeight = 30;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = Color.White;
            dataGridViewCellStyle27.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle27.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle27.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle27.WrapMode = DataGridViewTriState.False;
            OrderGV.DefaultCellStyle = dataGridViewCellStyle27;
            OrderGV.GridColor = Color.FromArgb(231, 229, 255);
            OrderGV.Location = new Point(767, 617);
            OrderGV.Margin = new Padding(5, 4, 5, 4);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersVisible = false;
            OrderGV.RowHeadersWidth = 51;
            OrderGV.RowTemplate.Height = 30;
            OrderGV.Size = new Size(1127, 269);
            OrderGV.TabIndex = 40;
            OrderGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrderGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrderGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrderGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrderGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrderGV.ThemeStyle.BackColor = Color.White;
            OrderGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrderGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OrderGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrderGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrderGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrderGV.ThemeStyle.HeaderStyle.Height = 30;
            OrderGV.ThemeStyle.ReadOnly = false;
            OrderGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrderGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrderGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            OrderGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrderGV.ThemeStyle.RowsStyle.Height = 30;
            OrderGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrderGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Customername
            // 
            Customername.Location = new Point(292, 690);
            Customername.Margin = new Padding(5, 4, 5, 4);
            Customername.Name = "Customername";
            Customername.Size = new Size(399, 27);
            Customername.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold);
            label10.Location = new Point(65, 690);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(195, 27);
            label10.TabIndex = 41;
            label10.Text = "CustomerName:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(1282, 893);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(166, 27);
            label11.TabIndex = 43;
            label11.Text = "Total Amount ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(1444, 888);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(57, 34);
            label12.TabIndex = 44;
            label12.Text = "Rs";
            // 
            // Placeorder
            // 
            Placeorder.BackColor = Color.Crimson;
            Placeorder.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Placeorder.ForeColor = Color.White;
            Placeorder.Location = new Point(70, 826);
            Placeorder.Margin = new Padding(5, 4, 5, 4);
            Placeorder.Name = "Placeorder";
            Placeorder.Size = new Size(165, 39);
            Placeorder.TabIndex = 45;
            Placeorder.Text = "Place Order";
            Placeorder.UseVisualStyleBackColor = false;
            Placeorder.Click += Placeorder_Click;
            // 
            // Vieworder
            // 
            Vieworder.BackColor = SystemColors.ActiveCaption;
            Vieworder.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vieworder.Location = new Point(245, 826);
            Vieworder.Margin = new Padding(5, 4, 5, 4);
            Vieworder.Name = "Vieworder";
            Vieworder.Size = new Size(165, 39);
            Vieworder.TabIndex = 46;
            Vieworder.Text = "View Orders";
            Vieworder.UseVisualStyleBackColor = false;
            Vieworder.Click += Vieworder_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(526, 826);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(165, 39);
            button2.TabIndex = 47;
            button2.Text = "Cancel Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(70, 881);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(621, 39);
            button3.TabIndex = 48;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 940);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Vieworder);
            Controls.Add(Placeorder);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(Customername);
            Controls.Add(label10);
            Controls.Add(OrderGV);
            Controls.Add(button1);
            Controls.Add(Quantitytext);
            Controls.Add(label6);
            Controls.Add(Searchcombo);
            Controls.Add(ProductsGV);
            Controls.Add(label5);
            Controls.Add(Orderdate);
            Controls.Add(Customerid);
            Controls.Add(label4);
            Controls.Add(Orderid);
            Controls.Add(label3);
            Controls.Add(CustomersGV);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
        private TextBox Orderid;
        private Label label3;
        private TextBox Customerid;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker Orderdate;
        private Label label5;
        private ComboBox Searchcombo;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private TextBox Quantitytext;
        private Label label6;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView OrderGV;
        private TextBox Customername;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button Placeorder;
        private Button Vieworder;
        private Button button2;
        private Button button3;
    }
}