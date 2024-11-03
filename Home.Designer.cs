namespace PuntuApp
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            Logo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            lblHome = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Controls.Add(Logo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Location = new Point(2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(901, 563);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Logo.ForeColor = Color.FromArgb(238, 238, 238);
            Logo.Location = new Point(3, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(194, 75);
            Logo.TabIndex = 0;
            Logo.Text = "PunctuApp";
            Logo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(lblHome, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Location = new Point(3, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 482);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(194, 50);
            label2.TabIndex = 2;
            label2.Text = "To determine";
            // 
            // lblHome
            // 
            lblHome.Font = new Font("Segoe UI", 14F);
            lblHome.ForeColor = Color.FromArgb(238, 238, 238);
            lblHome.Location = new Point(3, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(194, 50);
            lblHome.TabIndex = 1;
            lblHome.Text = "Home";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(238, 238, 238);
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(194, 75);
            label3.TabIndex = 3;
            label3.Text = "To determine";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Location = new Point(203, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(695, 69);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.person_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            pictureBox1.Location = new Point(626, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(313, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 7, 2, 2);
            label1.Size = new Size(313, 69);
            label1.TabIndex = 1;
            label1.Text = "UserName:\r\nID:\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(238, 238, 238);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(307, 69);
            label4.TabIndex = 2;
            label4.Text = "Status: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 25, 37);
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(920, 600);
            MinimumSize = new Size(920, 600);
            Name = "Home";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntuApp";
            Load += Home_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Logo;
        private Label lblHome;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
    }
}
