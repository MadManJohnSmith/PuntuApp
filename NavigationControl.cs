using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntuApp
{
    public class NavigationControl
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
        public void SetUserControls(List<UserControl> userControls)
        {
            this.userControlList = userControls;
            AddUserControls();
        }
        public void Display(int index)
        {
            if (index < 0 || index >= userControlList.Count)
            {
                MessageBox.Show($"Índice fuera de rango: {index}. Total de controles: {userControlList.Count}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var userControl in userControlList)
            {
                userControl.Visible = false;
            }

            userControlList[index].Visible = true;
            userControlList[index].BringToFront();
        }

    }
}