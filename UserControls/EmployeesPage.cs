using Calculadora_Areas_Perimetros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntuApp.Helpers;

namespace PuntuApp.UserControls
{
    partial class EmployeesPage : UserControl
    {
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);
        private NavigationControl navigationControl;
        private DatabaseHelper databaseHelper;
        public EmployeesPage(NavigationControl navigationControl, string connectionString)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
            this.databaseHelper = new DatabaseHelper(connectionString);
            LoadEmployees();
            HighlightButton(btnID);
            btnID.Click += (s, e) => OrdenarColumna("ID");
            btnNombre.Click += (s, e) => OrdenarColumna("name");
            btnEstado.Click += (s, e) => OrdenarColumna("Username");
            btnEntrada.Click += (s, e) => OrdenarColumna("lastEntry");
            btnSalida.Click += (s, e) => OrdenarColumna("lastExit");
            //AddTestRowsToDataGridView();
        }
        private void OrdenarColumna(string columnName)
        {
            try
            {
                // Verificar si la columna existe en el DataGridView
                if (dataGridView1.Columns[columnName] != null)
                {
                    // Alternar entre Ascendente y Descendente si ya está ordenada
                    var sortDirection = dataGridView1.SortOrder == SortOrder.Ascending ?
                        System.ComponentModel.ListSortDirection.Descending :
                        System.ComponentModel.ListSortDirection.Ascending;

                    dataGridView1.Sort(dataGridView1.Columns[columnName], sortDirection);
                }
                else
                {
                    MessageBox.Show($"La columna '{columnName}' no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al ordenar la columna '{columnName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);
        }

        private void HighlightButton(Button clickedButton)
        {
            btnSalida.BackColor = btnDefaultColor;
            btnEntrada.BackColor = btnDefaultColor;
            btnEstado.BackColor = btnDefaultColor;
            btnNombre.BackColor = btnDefaultColor;
            btnID.BackColor = btnDefaultColor;
            clickedButton.BackColor = btnSelectedtColor;
        }
        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            // Cambiar el color de la fuente del DataGridView a negro
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }
        private void AddTestRowsToDataGridView()
        {
            try
            {
                // Crear un nuevo DataTable con las columnas correctas
                DataTable testDataTable = new DataTable();
                testDataTable.Columns.Add("ID", typeof(int));
                testDataTable.Columns.Add("name", typeof(string));
                testDataTable.Columns.Add("Username", typeof(string));
                testDataTable.Columns.Add("lastEntry", typeof(DateTime));
                testDataTable.Columns.Add("lastExit", typeof(DateTime));
                testDataTable.Columns.Add("Estado", typeof(string));
                // Crear filas de ejemplo
                DataRow row1 = testDataTable.NewRow();
                row1["ID"] = 1;
                row1["name"] = "Juan Pérez";
                row1["Username"] = "juanperez";
                row1["lastEntry"] = DateTime.Now.AddMinutes(-30);
                row1["lastExit"] = DateTime.Now.AddMinutes(-10);
                row1["Estado"] = "Activo";
                testDataTable.Rows.Add(row1);

                DataRow row2 = testDataTable.NewRow();
                row2["ID"] = 2;
                row2["name"] = "María López";
                row2["Username"] = "marialopez";
                row2["lastEntry"] = DateTime.Now.AddHours(-2);
                row2["lastExit"] = DateTime.Now.AddHours(-1);
                row2["Estado"] = "Offline";
                testDataTable.Rows.Add(row2);

                DataRow row3 = testDataTable.NewRow();
                row3["ID"] = 3;
                row3["name"] = "Carlos Ruiz";
                row3["Username"] = "carlosruiz";
                row3["lastEntry"] = DateTime.Now.AddMinutes(-60);
                row3["lastExit"] = DBNull.Value;
                row3["Estado"] = "Activo";
                testDataTable.Rows.Add(row3);

                // Asignar el DataTable de prueba al DataGridView
                dataGridView1.DataSource = testDataTable;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir filas de prueba: " + ex.Message);
            }
        }
        public void LoadEmployees()
        {
            try
            {
                // Obtener datos de empleados desde la base de datos
                DataTable employeesData = databaseHelper.GetUsersWithAttendance();

                // Agregar la columna "Estado" calculada al DataTable
                employeesData.Columns.Add("Estado", typeof(string));

                foreach (DataRow row in employeesData.Rows)
                {
                    DateTime? lastEntry = row["lastEntry"] != DBNull.Value ? (DateTime?)row["lastEntry"] : null;
                    DateTime? lastExit = row["lastExit"] != DBNull.Value ? (DateTime?)row["lastExit"] : null;

                    // Determinar el estado en función de la última entrada y salida
                    string state = (lastEntry.HasValue && (!lastExit.HasValue || lastEntry > lastExit)) ? "Activo" : "Offline";
                    row["Estado"] = state;
                }

                // Configurar las columnas del DataGridView
                dataGridView1.DataSource = employeesData;
                dataGridView1.Columns["ID"].HeaderText = "ID";
                dataGridView1.Columns["name"].HeaderText = "Nombre";
                dataGridView1.Columns["Username"].HeaderText = "Nombre de Usuario";
                dataGridView1.Columns["Estado"].HeaderText = "Estado";
                dataGridView1.Columns["lastEntry"].HeaderText = "Última Entrada";
                dataGridView1.Columns["lastExit"].HeaderText = "Última Salida";

                // Ajustar ancho de las columnas
                dataGridView1.Columns["ID"].FillWeight = 4f;
                dataGridView1.Columns["name"].FillWeight = 26f;
                dataGridView1.Columns["Username"].FillWeight = 17f;
                dataGridView1.Columns["lastEntry"].FillWeight = 18f;
                dataGridView1.Columns["lastExit"].FillWeight = 18f;
                dataGridView1.Columns["Estado"].FillWeight = 10f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los empleados: " + ex.Message);
            }
        }

    }
}
