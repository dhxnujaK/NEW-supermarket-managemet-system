namespace DataBase_System1
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            CategorynameLabel = new Label();
            CategoryIDLabel = new Label();
            Categoryname = new TextBox();
            Categoryid = new TextBox();
            label8 = new Label();
            CategoriesGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).BeginInit();
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
            label1.Size = new Size(311, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
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
            // CategorynameLabel
            // 
            CategorynameLabel.AutoSize = true;
            CategorynameLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategorynameLabel.Location = new Point(62, 361);
            CategorynameLabel.Margin = new Padding(5, 0, 5, 0);
            CategorynameLabel.Name = "CategorynameLabel";
            CategorynameLabel.Size = new Size(192, 27);
            CategorynameLabel.TabIndex = 11;
            CategorynameLabel.Text = "CategoryName:";
            // 
            // CategoryIDLabel
            // 
            CategoryIDLabel.AutoSize = true;
            CategoryIDLabel.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryIDLabel.Location = new Point(62, 292);
            CategoryIDLabel.Margin = new Padding(5, 0, 5, 0);
            CategoryIDLabel.Name = "CategoryIDLabel";
            CategoryIDLabel.Size = new Size(145, 27);
            CategoryIDLabel.TabIndex = 12;
            CategoryIDLabel.Text = "CategoryID:";
            // 
            // Categoryname
            // 
            Categoryname.Location = new Point(286, 361);
            Categoryname.Margin = new Padding(5, 4, 5, 4);
            Categoryname.Name = "Categoryname";
            Categoryname.Size = new Size(361, 27);
            Categoryname.TabIndex = 9;
            // 
            // Categoryid
            // 
            Categoryid.Location = new Point(286, 293);
            Categoryid.Margin = new Padding(5, 4, 5, 4);
            Categoryid.Name = "Categoryid";
            Categoryid.Size = new Size(361, 27);
            Categoryid.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1241, 243);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 27);
            label8.TabIndex = 14;
            label8.Text = "Categories List";
            // 
            // CategoriesGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CategoriesGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoriesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoriesGV.ColumnHeadersHeight = 30;
            CategoriesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CategoriesGV.DefaultCellStyle = dataGridViewCellStyle3;
            CategoriesGV.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesGV.Location = new Point(681, 293);
            CategoriesGV.Margin = new Padding(5, 4, 5, 4);
            CategoriesGV.Name = "CategoriesGV";
            CategoriesGV.RowHeadersVisible = false;
            CategoriesGV.RowHeadersWidth = 51;
            CategoriesGV.RowTemplate.Height = 30;
            CategoriesGV.Size = new Size(1220, 605);
            CategoriesGV.TabIndex = 13;
            CategoriesGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CategoriesGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CategoriesGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CategoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CategoriesGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CategoriesGV.ThemeStyle.BackColor = Color.White;
            CategoriesGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CategoriesGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CategoriesGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CategoriesGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CategoriesGV.ThemeStyle.HeaderStyle.Height = 30;
            CategoriesGV.ThemeStyle.ReadOnly = false;
            CategoriesGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CategoriesGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoriesGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CategoriesGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CategoriesGV.ThemeStyle.RowsStyle.Height = 30;
            CategoriesGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CategoriesGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CategoriesGV.CellContentClick += CategoriesGV_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(235, 461);
            button2.Name = "button2";
            button2.Size = new Size(171, 39);
            button2.TabIndex = 18;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(62, 461);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(165, 39);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(62, 540);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(585, 39);
            button4.TabIndex = 15;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(482, 461);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 16;
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
            panel2.Location = new Point(0, 931);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 18);
            panel2.TabIndex = 19;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 949);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(CategoriesGV);
            Controls.Add(CategorynameLabel);
            Controls.Add(CategoryIDLabel);
            Controls.Add(Categoryname);
            Controls.Add(Categoryid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            Text = "ManageCategories";
            Load += ManageCategories_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label CategorynameLabel;
        private Label CategoryIDLabel;
        private TextBox Categoryname;
        private TextBox Categoryid;
        private Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesGV;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Panel panel2;
    }
}