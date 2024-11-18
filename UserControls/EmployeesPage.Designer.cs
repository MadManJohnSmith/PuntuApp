namespace PuntuApp.UserControls
{
    partial class EmployeesPage
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            searchBar = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            FilterSelection = new ComboBox();
            label1 = new Label();
            txtFilter = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAddUser = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            btnID = new Button();
            btnNombre = new Button();
            btnEstado = new Button();
            btnEntrada = new Button();
            btnSalida = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 482);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(695, 482);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(689, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel4.Controls.Add(searchBar, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 50);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(683, 41);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Font = new Font("Segoe UI", 12F);
            searchBar.Location = new Point(486, 3);
            searchBar.Multiline = true;
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Buscar: ";
            searchBar.Size = new Size(194, 35);
            searchBar.TabIndex = 0;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(FilterSelection, 1, 0);
            tableLayoutPanel6.Controls.Add(label1);
            tableLayoutPanel6.Controls.Add(txtFilter, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(477, 35);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // FilterSelection
            // 
            FilterSelection.Dock = DockStyle.Fill;
            FilterSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterSelection.FormattingEnabled = true;
            FilterSelection.Items.AddRange(new object[] { "Nombre", "Nombre de Usuario", "Estado" });
            FilterSelection.Location = new Point(60, 0);
            FilterSelection.Margin = new Padding(0);
            FilterSelection.Name = "FilterSelection";
            FilterSelection.Size = new Size(150, 23);
            FilterSelection.TabIndex = 0;
            FilterSelection.SelectedIndexChanged += FilterSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 35);
            label1.TabIndex = 0;
            label1.Text = "Filtrar Por:";
            // 
            // txtFilter
            // 
            txtFilter.Dock = DockStyle.Left;
            txtFilter.Location = new Point(210, 0);
            txtFilter.Margin = new Padding(0);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Ingresa texto...";
            txtFilter.Size = new Size(150, 23);
            txtFilter.TabIndex = 1;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.Controls.Add(btnAddUser, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(683, 41);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Dock = DockStyle.Fill;
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddUser.Location = new Point(486, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(194, 35);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "+Anadir Usuario";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Controls.Add(btnID, 1, 0);
            tableLayoutPanel5.Controls.Add(btnNombre, 2, 0);
            tableLayoutPanel5.Controls.Add(btnEstado, 3, 0);
            tableLayoutPanel5.Controls.Add(btnEntrada, 4, 0);
            tableLayoutPanel5.Controls.Add(btnSalida, 5, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(477, 35);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 35);
            label2.TabIndex = 0;
            label2.Text = "Ordenar Por:";
            // 
            // btnID
            // 
            btnID.Dock = DockStyle.Fill;
            btnID.FlatAppearance.BorderSize = 0;
            btnID.FlatStyle = FlatStyle.Flat;
            btnID.Location = new Point(63, 3);
            btnID.Name = "btnID";
            btnID.Size = new Size(34, 29);
            btnID.TabIndex = 1;
            btnID.Text = "ID";
            btnID.UseVisualStyleBackColor = true;
            btnID.Click += btnID_Click;
            // 
            // btnNombre
            // 
            btnNombre.Dock = DockStyle.Fill;
            btnNombre.FlatAppearance.BorderSize = 0;
            btnNombre.FlatStyle = FlatStyle.Flat;
            btnNombre.Location = new Point(103, 3);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(74, 29);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnEstado
            // 
            btnEstado.Dock = DockStyle.Fill;
            btnEstado.FlatAppearance.BorderSize = 0;
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.Location = new Point(183, 3);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(74, 29);
            btnEstado.TabIndex = 3;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.Dock = DockStyle.Fill;
            btnEntrada.FlatAppearance.BorderSize = 0;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Location = new Point(263, 3);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(102, 29);
            btnEntrada.TabIndex = 4;
            btnEntrada.Text = "Hora de Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSalida
            // 
            btnSalida.Dock = DockStyle.Fill;
            btnSalida.FlatAppearance.BorderSize = 0;
            btnSalida.FlatStyle = FlatStyle.Flat;
            btnSalida.Location = new Point(371, 3);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(103, 29);
            btnSalida.TabIndex = 5;
            btnSalida.Text = "Hora de Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft YaHei", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(689, 376);
            dataGridView1.TabIndex = 1;
            // 
            // EmployeesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 224);
            Controls.Add(panel1);
            Name = "EmployeesPage";
            Size = new Size(695, 482);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox searchBar;
        private Button btnAddUser;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox FilterSelection;
        private TextBox txtFilter;
        private Label label2;
        private Button btnID;
        private Button btnNombre;
        private Button btnEstado;
        private Button btnEntrada;
        private Button btnSalida;
    }
}
