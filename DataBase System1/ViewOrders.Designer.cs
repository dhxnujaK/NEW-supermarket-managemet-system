namespace DataBase_System1
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            OrdersviewGV = new Guna.UI2.WinForms.Guna2DataGridView();
            Vieworder = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersviewGV).BeginInit();
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
            panel1.TabIndex = 3;
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
            label1.Location = new Point(878, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 0;
            label1.Text = "View Orders";
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
            // OrdersviewGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            OrdersviewGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OrdersviewGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrdersviewGV.ColumnHeadersHeight = 30;
            OrdersviewGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrdersviewGV.DefaultCellStyle = dataGridViewCellStyle3;
            OrdersviewGV.GridColor = Color.FromArgb(231, 229, 255);
            OrdersviewGV.Location = new Point(62, 241);
            OrdersviewGV.Margin = new Padding(5, 4, 5, 4);
            OrdersviewGV.Name = "OrdersviewGV";
            OrdersviewGV.RowHeadersVisible = false;
            OrdersviewGV.RowHeadersWidth = 51;
            OrdersviewGV.RowTemplate.Height = 30;
            OrdersviewGV.Size = new Size(1809, 585);
            OrdersviewGV.TabIndex = 41;
            OrdersviewGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            OrdersviewGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            OrdersviewGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            OrdersviewGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            OrdersviewGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            OrdersviewGV.ThemeStyle.BackColor = Color.White;
            OrdersviewGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            OrdersviewGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            OrdersviewGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            OrdersviewGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdersviewGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            OrdersviewGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            OrdersviewGV.ThemeStyle.HeaderStyle.Height = 30;
            OrdersviewGV.ThemeStyle.ReadOnly = false;
            OrdersviewGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            OrdersviewGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrdersviewGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            OrdersviewGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            OrdersviewGV.ThemeStyle.RowsStyle.Height = 30;
            OrdersviewGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            OrdersviewGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            OrdersviewGV.CellContentClick += OrdersviewGV_CellContentClick;
            // 
            // Vieworder
            // 
            Vieworder.BackColor = SystemColors.ActiveCaption;
            Vieworder.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vieworder.Location = new Point(905, 852);
            Vieworder.Margin = new Padding(5, 4, 5, 4);
            Vieworder.Name = "Vieworder";
            Vieworder.Size = new Size(165, 39);
            Vieworder.TabIndex = 47;
            Vieworder.Text = "Go Back";
            Vieworder.UseVisualStyleBackColor = false;
            Vieworder.Click += Vieworder_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 940);
            Controls.Add(Vieworder);
            Controls.Add(OrdersviewGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersviewGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView OrdersviewGV;
        private Button Vieworder;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}