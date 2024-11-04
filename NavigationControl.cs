using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntuApp
{
    internal class NavigationControl
    {
        private List<UserControl> userControlList = new List<UserControl>();
        private Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            // Agrega cada UserControl al panel y lo oculta
            foreach (var userControl in userControlList)
            {
                userControl.Dock = DockStyle.Fill;
                panel.Controls.Add(userControl);
                userControl.Visible = false; // Asegura que estén ocultos inicialmente
            }
        }

        public void Display(int index)
        {
            // Asegúrate de que el índice sea válido
            if (index < 0 || index >= userControlList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango.");
            }

            // Oculta todos los UserControls
            foreach (var userControl in userControlList)
            {
                userControl.Visible = false; // Oculta todos
            }

            // Muestra solo el UserControl seleccionado
            userControlList[index].Visible = true;
            userControlList[index].BringToFront(); // Lleva al frente el UserControl visible
        }
    }
}