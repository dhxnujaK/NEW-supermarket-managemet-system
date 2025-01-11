namespace DataBase_System1
{
    partial class MangeUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangeUsers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label9 = new Label();
            Uname = new TextBox();
            label3 = new Label();
            Ufullname = new TextBox();
            label4 = new Label();
            Upassword = new TextBox();
            label5 = new Label();
            Uphone = new TextBox();
            label6 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            UsersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button3 = new Button();
            label8 = new Label();
            button2 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 169);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(829, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "Managing Users";
            label1.Click += label1_Click;
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
            label7.Click += label9_Click;
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
            // Uname
            // 
            Uname.Location = new Point(277, 265);
            Uname.Margin = new Padding(5, 4, 5, 4);
            Uname.Name = "Uname";
            Uname.Size = new Size(373, 36);
            Uname.TabIndex = 1;
            Uname.TextChanged += Uname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 269);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 27);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // Ufullname
            // 
            Ufullname.Location = new Point(277, 333);
            Ufullname.Margin = new Padding(5, 4, 5, 4);
            Ufullname.Name = "Ufullname";
            Ufullname.Size = new Size(373, 36);
            Ufullname.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 338);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 2;
            label4.Text = "FullName:";
            // 
            // Upassword
            // 
            Upassword.Location = new Point(277, 402);
            Upassword.Margin = new Padding(5, 4, 5, 4);
            Upassword.Name = "Upassword";
            Upassword.Size = new Size(373, 36);
            Upassword.TabIndex = 1;
            Upassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 406);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(121, 27);
            label5.TabIndex = 2;
            label5.Text = "Password:";
            // 
            // Uphone
            // 
            Uphone.Location = new Point(277, 468);
            Uphone.Margin = new Padding(5, 4, 5, 4);
            Uphone.Name = "Uphone";
            Uphone.Size = new Size(373, 36);
            Uphone.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 472);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 27);
            label6.TabIndex = 2;
            label6.Text = "Telephone:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(488, 555);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 39);
            button1.TabIndex = 3;
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
            panel2.TabIndex = 1;
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UsersGV.ColumnHeadersHeight = 25;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
            UsersGV.GridColor = Color.FromArgb(231, 229, 255);
            UsersGV.Location = new Point(675, 269);
            UsersGV.Margin = new Padding(5, 4, 5, 4);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersVisible = false;
            UsersGV.RowHeadersWidth = 51;
            UsersGV.RowTemplate.Height = 30;
            UsersGV.Size = new Size(1235, 639);
            UsersGV.TabIndex = 7;
            UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UsersGV.ThemeStyle.BackColor = Color.White;
            UsersGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            UsersGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UsersGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UsersGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsersGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UsersGV.ThemeStyle.HeaderStyle.Height = 25;
            UsersGV.ThemeStyle.ReadOnly = false;
            UsersGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UsersGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UsersGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            UsersGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UsersGV.ThemeStyle.RowsStyle.Height = 30;
            UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UsersGV.CellContentClick += UsersGV_CellContentClick_2;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(68, 555);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(165, 39);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1226, 219);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 9;
            label8.Text = "Users List";
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(241, 555);
            button2.Name = "button2";
            button2.Size = new Size(171, 39);
            button2.TabIndex = 10;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(68, 636);
            button5.Margin = new Padding(5, 4, 5, 4);
            button5.Name = "button5";
            button5.Size = new Size(585, 39);
            button5.TabIndex = 29;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MangeUsers
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 949);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(UsersGV);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Uphone);
            Controls.Add(Upassword);
            Controls.Add(Ufullname);
            Controls.Add(Uname);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "MangeUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MangeUsers";
            Load += MangeUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox Uname;
        private Label label3;
        private TextBox Ufullname;
        private Label label4;
        private TextBox Upassword;
        private Label label5;
        private TextBox Uphone;
        private Label label6;
        private Button button1;
        private Panel panel2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView UsersGV;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label1;
        private Button button2;
        private Button button5;
    }
}