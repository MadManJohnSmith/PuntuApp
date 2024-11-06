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
            textBox1 = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            btnID = new Button();
            btnNombre = new Button();
            btnEstado = new Button();
            btnEntrada = new Button();
            btnSalida = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            state = new DataGridViewTextBoxColumn();
            lastEntry = new DataGridViewTextBoxColumn();
            lastExit = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 50);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(683, 41);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(486, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar: ";
            textBox1.Size = new Size(194, 35);
            textBox1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel6.Controls.Add(label1);
            tableLayoutPanel6.Controls.Add(textBox2, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(477, 35);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nombre", "Nombre de Usuario", "Estado" });
            comboBox1.Location = new Point(60, 0);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.Dock = DockStyle.Left;
            textBox2.Location = new Point(210, 0);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "...";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.Controls.Add(button1, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(683, 41);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(486, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 35);
            button1.TabIndex = 0;
            button1.Text = "+Anadir Usuario";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, Username, state, lastEntry, lastExit });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(689, 376);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 30;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // name
            // 
            name.FillWeight = 89.54315F;
            name.HeaderText = "Nombre";
            name.MinimumWidth = 160;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Username
            // 
            Username.FillWeight = 89.54315F;
            Username.HeaderText = "Nombre de Usuario";
            Username.MinimumWidth = 121;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // state
            // 
            state.FillWeight = 89.54315F;
            state.HeaderText = "Estado";
            state.MinimumWidth = 80;
            state.Name = "state";
            state.ReadOnly = true;
            // 
            // lastEntry
            // 
            lastEntry.FillWeight = 89.54315F;
            lastEntry.HeaderText = "Ultima Entrada";
            lastEntry.MinimumWidth = 130;
            lastEntry.Name = "lastEntry";
            lastEntry.ReadOnly = true;
            // 
            // lastExit
            // 
            lastExit.FillWeight = 89.54315F;
            lastExit.HeaderText = "Ultima Salida";
            lastExit.MinimumWidth = 130;
            lastExit.Name = "lastExit";
            lastExit.ReadOnly = true;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn lastEntry;
        private DataGridViewTextBoxColumn lastExit;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label2;
        private Button btnID;
        private Button btnNombre;
        private Button btnEstado;
        private Button btnEntrada;
        private Button btnSalida;
    }
}
