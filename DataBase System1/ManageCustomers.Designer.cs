namespace DataBase_System1
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            CustomerPhoneLabel = new Label();
            CustomerNameLabel = new Label();
            CustomerIdLabel = new Label();
            Customerphone = new TextBox();
            Customername = new TextBox();
            Customerid = new TextBox();
            label8 = new Label();
            CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            Orderlabel = new Label();
            label3 = new Label();
            panel4 = new Panel();
            Amountlabel = new Label();
            label6 = new Label();
            panel5 = new Panel();
            Datelabel = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(818, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
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
            // CustomerPhoneLabel
            // 
            CustomerPhoneLabel.AutoSize = true;
            CustomerPhoneLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneLabel.Location = new Point(57, 420);
            CustomerPhoneLabel.Margin = new Padding(5, 0, 5, 0);
            CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            CustomerPhoneLabel.Size = new Size(197, 27);
            CustomerPhoneLabel.TabIndex = 6;
            CustomerPhoneLabel.Text = "CustomerPhone:";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.Location = new Point(57, 352);
            CustomerNameLabel.Margin = new Padding(5, 0, 5, 0);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(195, 27);
            CustomerNameLabel.TabIndex = 7;
            CustomerNameLabel.Text = "CustomerName:";
            // 
            // CustomerIdLabel
            // 
            CustomerIdLabel.AutoSize = true;
            CustomerIdLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerIdLabel.Location = new Point(57, 283);
            CustomerIdLabel.Margin = new Padding(5, 0, 5, 0);
            CustomerIdLabel.Name = "CustomerIdLabel";
            CustomerIdLabel.Size = new Size(138, 27);
            CustomerIdLabel.TabIndex = 8;
            CustomerIdLabel.Text = "CutomerID:";
            // 
            // Customerphone
            // 
            Customerphone.Location = new Point(289, 420);
            Customerphone.Margin = new Padding(5, 4, 5, 4);
            Customerphone.Name = "Customerphone";
            Customerphone.Size = new Size(353, 27);
            Customerphone.TabIndex = 3;
            // 
            // Customername
            // 
            Customername.Location = new Point(289, 351);
            Customername.Margin = new Padding(5, 4, 5, 4);
            Customername.Name = "Customername";
            Customername.Size = new Size(353, 27);
            Customername.TabIndex = 4;
            Customername.TextChanged += Customername_TextChanged;
            // 
            // Customerid
            // 
            Customerid.Location = new Point(289, 283);
            Customerid.Margin = new Padding(5, 4, 5, 4);
            Customerid.Name = "Customerid";
            Customerid.Size = new Size(353, 27);
            Customerid.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1198, 234);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(169, 27);
            label8.TabIndex = 11;
            label8.Text = "Customers List";
            // 
            // CustomersGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersGV.ColumnHeadersHeight = 30;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomersGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomersGV.GridColor = Color.FromArgb(231, 229, 255);
            CustomersGV.Location = new Point(669, 283);
            CustomersGV.Margin = new Padding(5, 4, 5, 4);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.RowHeadersVisible = false;
            CustomersGV.RowHeadersWidth = 51;
            CustomersGV.RowTemplate.Height = 30;
            CustomersGV.Size = new Size(1220, 447);
            CustomersGV.TabIndex = 10;
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
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(230, 537);
            button2.Name = "button2";
            button2.Size = new Size(171, 39);
            button2.TabIndex = 15;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(57, 537);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(165, 39);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(57, 616);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(585, 39);
            button4.TabIndex = 12;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(477, 537);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panel2.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(Orderlabel);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(57, 775);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 17;
            // 
            // Orderlabel
            // 
            Orderlabel.AutoSize = true;
            Orderlabel.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Orderlabel.ForeColor = Color.White;
            Orderlabel.Location = new Point(41, 48);
            Orderlabel.Name = "Orderlabel";
            Orderlabel.Size = new Size(175, 57);
            Orderlabel.TabIndex = 18;
            Orderlabel.Text = "Orders";
            Orderlabel.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(10, 9);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 27);
            label3.TabIndex = 18;
            label3.Text = "Orders Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Lime;
            panel4.Controls.Add(Amountlabel);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(402, 775);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 18;
            // 
            // Amountlabel
            // 
            Amountlabel.AutoSize = true;
            Amountlabel.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amountlabel.ForeColor = Color.White;
            Amountlabel.Location = new Point(20, 48);
            Amountlabel.Name = "Amountlabel";
            Amountlabel.Size = new Size(207, 57);
            Amountlabel.TabIndex = 18;
            Amountlabel.Text = "Amount";
            Amountlabel.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(35, 9);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 27);
            label6.TabIndex = 18;
            label6.Text = "Orders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.Controls.Add(Datelabel);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(746, 775);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 125);
            panel5.TabIndex = 19;
            // 
            // Datelabel
            // 
            Datelabel.Anchor = AnchorStyles.Left;
            Datelabel.AutoSize = true;
            Datelabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Datelabel.ForeColor = Color.White;
            Datelabel.Location = new Point(3, 65);
            Datelabel.Name = "Datelabel";
            Datelabel.Size = new Size(0, 23);
            Datelabel.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(35, 9);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(182, 27);
            label11.TabIndex = 18;
            label11.Text = "Last Order Date";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 940);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(CustomersGV);
            Controls.Add(CustomerPhoneLabel);
            Controls.Add(CustomerNameLabel);
            Controls.Add(CustomerIdLabel);
            Controls.Add(Customerphone);
            Controls.Add(Customername);
            Controls.Add(Customerid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label CustomerPhoneLabel;
        private Label CustomerNameLabel;
        private Label CustomerIdLabel;
        private TextBox Customerphone;
        private TextBox Customername;
        private TextBox Customerid;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label Orderlabel;
        private Panel panel4;
        private Label Amountlabel;
        private Label label6;
        private Panel panel5;
        private Label Datelabel;
        private Label label11;
    }
}