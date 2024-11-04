namespace PuntuApp
{
    partial class MainPage
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
            btnUsuario = new Button();
            btnHome = new Button();
            btnEmpleados = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
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
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
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
            Logo.ForeColor = Color.FromArgb(19, 62, 135);
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
            tableLayoutPanel2.Controls.Add(btnUsuario, 0, 2);
            tableLayoutPanel2.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEmpleados, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 78);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(194, 154);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUsuario
            // 
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUsuario.ForeColor = Color.FromArgb(19, 62, 135);
            btnUsuario.Location = new Point(3, 103);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(188, 48);
            btnUsuario.TabIndex = 2;
            btnUsuario.Text = "Mi Información";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(19, 62, 135);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 44);
            btnHome.TabIndex = 0;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.FromArgb(19, 62, 135);
            btnEmpleados.Location = new Point(3, 53);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(188, 44);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel3.Controls.Add(pictureBox1, 2, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
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
            pictureBox1.ErrorImage = Properties.Resources.account_circle_24dp_E8EAED_FILL0_wght400_GRAD0_opsz24;
            pictureBox1.Image = Properties.Resources._481862_zCYAMdv1;
            pictureBox1.Location = new Point(626, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(19, 62, 135);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(307, 69);
            label4.TabIndex = 2;
            label4.Text = "Estado: Activo";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(313, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(2, 7, 2, 2);
            label1.Size = new Size(313, 69);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Usuario: MadManJohnSmith\r\nID: 00000001\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(203, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 482);
            panel1.TabIndex = 4;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 224);
            ClientSize = new Size(904, 561);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(920, 600);
            MinimumSize = new Size(920, 600);
            Name = "MainPage";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntuApp";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Logo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Button btnHome;
        private Button btnEmpleados;
        private Button btnUsuario;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
