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
        }
        private void LoadEmployees()
        {

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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }
    }
}
