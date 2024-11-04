namespace PuntuApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnLogin = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            txtUsername = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel2 = new Panel();
            txtPassword = new TextBox();
            btnExit = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 62, 135);
            label1.Location = new Point(73, 87);
            label1.Name = "label1";
            label1.Size = new Size(146, 44);
            label1.TabIndex = 0;
            label1.Text = "PuntuApp";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 1);
            tableLayoutPanel2.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(73, 292);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.1875F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.8125F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(146, 59);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(19, 62, 135);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.HighlightText;
            btnLogin.Location = new Point(3, 27);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "INICIAR SESIÓN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(19, 62, 135);
            btnClear.Location = new Point(52, 0);
            btnClear.Margin = new Padding(0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 24);
            btnClear.TabIndex = 1;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(28, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(19, 62, 135);
            label2.Location = new Point(73, 131);
            label2.Name = "label2";
            label2.Size = new Size(146, 44);
            label2.TabIndex = 1;
            label2.Text = "Inicio de Sesión";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(label2, 2, 3);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 7);
            tableLayoutPanel1.Controls.Add(label1, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 2, 6);
            tableLayoutPanel1.Controls.Add(btnExit, 2, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2983856F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.298378F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1913872F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.5250435F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6868F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(292, 447);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(28, 247);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel1, 0, 1);
            tableLayoutPanel3.Controls.Add(txtUsername, 0, 0);
            tableLayoutPanel3.Location = new Point(73, 202);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48718F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5128212F));
            tableLayoutPanel3.Size = new Size(146, 39);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 62, 135);
            panel1.Location = new Point(3, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 1);
            panel1.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(238, 238, 238);
            txtUsername.Dock = DockStyle.Bottom;
            txtUsername.Location = new Point(3, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Usuario";
            txtUsername.Size = new Size(140, 23);
            txtUsername.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel2, 0, 1);
            tableLayoutPanel4.Controls.Add(txtPassword, 0, 0);
            tableLayoutPanel4.Location = new Point(73, 247);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 79.48718F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5128212F));
            tableLayoutPanel4.Size = new Size(146, 39);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 62, 135);
            panel2.Location = new Point(3, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 1);
            panel2.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(238, 238, 238);
            txtPassword.Dock = DockStyle.Bottom;
            txtPassword.Location = new Point(3, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(140, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(19, 62, 135);
            btnExit.Location = new Point(73, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(146, 23);
            btnExit.TabIndex = 11;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginPage
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 224);
            ClientSize = new Size(292, 447);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnLogin;
        private Button btnClear;
        private PictureBox pictureBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnExit;
    }
}