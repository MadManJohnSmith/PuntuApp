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
        NavigationButtons navButtons;
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.FromArgb(203, 220, 235);
        public EmployeesPage()
        {
            InitializeComponent();
            InitializeNavigationButtons();
        }
        private void InitializeNavigationButtons()
        {
            List<Button> buttons = new List<Button>()
            { btnID, btnNombre, btnEstado, btnEntrada, btnSalida};
            navButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            navButtons.Highlight(btnID);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            navButtons.Highlight(btnNombre);
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            navButtons.Highlight(btnEstado);
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            navButtons.Highlight(btnEntrada);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            navButtons.Highlight(btnSalida);
        }

        internal class NavigationButtons
        {
            private List<Button> buttons;
            private Color defaultColor;
            private Color selectedColor;

            public NavigationButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
            {
                this.buttons = buttons;
                this.defaultColor = defaultColor;
                this.selectedColor = selectedColor;
                SetButtonColor();
            }

            private void SetButtonColor()
            {
                foreach (Button button in buttons)
                {
                    button.BackColor = defaultColor;
                }
            }

            public void Highlight(Button selectedButton)
            {
                foreach (Button button in buttons)
                {
                    if (button == selectedButton)
                    {
                        selectedButton.BackColor = selectedColor;
                    }
                    else
                    {
                        button.BackColor = defaultColor;
                    }
                }
            }
        }



    }
}


