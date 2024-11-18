namespace PuntuApp.UserControls
{
    partial class editUserPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEliminar = new Button();
            pbPhoto = new PictureBox();
            btnPhoto = new Button();
            btnCancelar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label1 = new Label();
            txtName = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            cbUserType = new ComboBox();
            label7 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            label5 = new Label();
            txtPassword = new TextBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            label6 = new Label();
            txtPassVeri = new TextBox();
            btnAddUser = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(695, 482);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AllowDrop = true;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel2.Controls.Add(pbPhoto, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPhoto, 1, 0);
            tableLayoutPanel2.Controls.Add(btnCancelar, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(689, 138);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.White;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(372, 94);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 41);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pbPhoto
            // 
            pbPhoto.BackgroundImage = Properties.Resources.account_circle_24dp_1B1925_FILL0_wght400_GRAD0_opsz241;
            pbPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            pbPhoto.Dock = DockStyle.Fill;
            pbPhoto.Location = new Point(3, 3);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(132, 132);
            pbPhoto.TabIndex = 0;
            pbPhoto.TabStop = false;
            // 
            // btnPhoto
            // 
            btnPhoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPhoto.Location = new Point(141, 94);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(123, 41);
            btnPhoto.TabIndex = 1;
            btnPhoto.Text = "Cambiar Foto de Perfil";
            btnPhoto.UseVisualStyleBackColor = true;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(563, 94);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 41);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(btnAddUser, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 147);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(689, 332);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(683, 77);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label1, 0, 0);
            tableLayoutPanel7.Controls.Add(txtName, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel7.Size = new Size(677, 71);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(671, 42);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(3, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(671, 23);
            txtName.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.50307F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.496933F));
            tableLayoutPanel5.Controls.Add(cbUserType, 1, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 86);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(683, 77);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // cbUserType
            // 
            cbUserType.Dock = DockStyle.Fill;
            cbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUserType.FormattingEnabled = true;
            cbUserType.Items.AddRange(new object[] { "Empleado", "Administrador" });
            cbUserType.Location = new Point(256, 38);
            cbUserType.Margin = new Padding(0);
            cbUserType.Name = "cbUserType";
            cbUserType.Size = new Size(427, 23);
            cbUserType.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            label7.Location = new Point(3, 38);
            label7.Name = "label7";
            label7.Size = new Size(250, 39);
            label7.TabIndex = 2;
            label7.Text = "Tipo de Usuario";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 38);
            label4.TabIndex = 0;
            label4.Text = "Nombre de Usuario:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Top;
            txtUsername.Location = new Point(259, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(421, 23);
            txtUsername.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel10, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel11, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 169);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(683, 77);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(label5, 0, 0);
            tableLayoutPanel10.Controls.Add(txtPassword, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.Size = new Size(335, 71);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(329, 42);
            label5.TabIndex = 0;
            label5.Text = "Contraseña:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(3, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 23);
            txtPassword.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Controls.Add(label6, 0, 0);
            tableLayoutPanel11.Controls.Add(txtPassVeri, 0, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(344, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel11.Size = new Size(336, 71);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("PT Sans", 11.9999981F, FontStyle.Bold);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(330, 42);
            label6.TabIndex = 0;
            label6.Text = "Repetir Contraseña:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPassVeri
            // 
            txtPassVeri.Dock = DockStyle.Fill;
            txtPassVeri.Location = new Point(3, 45);
            txtPassVeri.Name = "txtPassVeri";
            txtPassVeri.Size = new Size(330, 23);
            txtPassVeri.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.Dock = DockStyle.Bottom;
            btnAddUser.Location = new Point(3, 306);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(683, 23);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Guardar Cambios";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // editUserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 224);
            Controls.Add(tableLayoutPanel1);
            Name = "editUserPage";
            Size = new Size(695, 482);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCancelar;
        private PictureBox pbPhoto;
        private Button btnPhoto;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private TextBox txtName;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox cbUserType;
        private Label label7;
        private Label label4;
        private TextBox txtUsername;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label5;
        private TextBox txtPassword;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label6;
        private TextBox txtPassVeri;
        private Button btnAddUser;
        private Button btnEliminar;
    }
}
