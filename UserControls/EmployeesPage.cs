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

namespace PuntuApp.UserControls
{
    partial class EmployeesPage : UserControl
    {
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);
        private NavigationControl navigationControl;
        public EmployeesPage(NavigationControl navigationControl)
        {
            InitializeComponent();
            this.navigationControl = navigationControl;
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
            // Reset all buttons to default color
            btnSalida.BackColor = btnDefaultColor;
            btnEntrada.BackColor = btnDefaultColor;
            btnEstado.BackColor = btnDefaultColor;
            btnNombre.BackColor = btnDefaultColor;
            btnID.BackColor = btnDefaultColor;

            // Set the clicked button to the selected color
            clickedButton.BackColor = btnSelectedtColor;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
        }

        private void FilterSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
