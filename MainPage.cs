using Calculadora_Areas_Perimetros;
using PuntuApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PuntuApp
{
    public partial class MainPage : Form
    {
        private bool isClosing = false;

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);

        public MainPage()
        {
            InitializeComponent();
            InitializeNavigationButtons();
            InitializeNavigationControl();

        }
        private void InitializeNavigationControl()
        {
            // Create NavigationControl
            navigationControl = new NavigationControl(new List<UserControl>(), panel1);

            // Create UserControls with the initialized NavigationControl
            List<UserControl> userControls = new List<UserControl>()
            {
                new HomePage(),//0
                new EmployeesPage(navigationControl),//1
                new UserPage(),//2
                new addUserPage(navigationControl)//3
            };

            // Set the user controls to the navigation control
            navigationControl.SetUserControls(userControls); // Método nuevo para actualizar la lista

            navigationControl.Display(0);
            navigationButtons.Highlight(btnHome);
        }

        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnHome, btnEmpleados, btnUsuario};
            navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (navigationControl != null)
            {
                navigationControl.Display(0);
                navigationButtons.Highlight(btnHome);
            }
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (navigationControl != null)
            {
                navigationControl.Display(1);
                navigationButtons.Highlight(btnEmpleados);
            }
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (navigationControl != null)
            {
                navigationControl.Display(2);
                navigationButtons.Highlight(btnUsuario);
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (isClosing) return; // Evitar múltiples ejecuciones

            isClosing = true; // Marcar como en proceso de cierre

            // Confirmar si el usuario quiere cerrar
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    isClosing = false; // Restablecer el estado si se cancela el cierre
                    break;
                default:
                    break;
            }
        }
    }
}
