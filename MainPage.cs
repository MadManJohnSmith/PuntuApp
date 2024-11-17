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

        private string connectionString;
        public MainPage(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            InitializeNavigationButtons();
            InitializeNavigationControl();

        }
        private void InitializeNavigationControl()
        {

            navigationControl = new NavigationControl(new List<UserControl>(), panel1);

            List<UserControl> userControls = new List<UserControl>()
            {
                new HomePage(),//0
                new EmployeesPage(navigationControl, connectionString),//1
                new UserPage(),//2
                new addUserPage(navigationControl, connectionString)//3
            };


            navigationControl.SetUserControls(userControls);

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

            if (isClosing) return;

            isClosing = true;

            switch (MessageBox.Show(this, "¿Seguro que quieres salir?", "Cerrando...", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    isClosing = false;
                    break;
                default:
                    break;
            }
        }
    }
}
