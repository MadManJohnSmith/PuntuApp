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
    public partial class addUserPage : UserControl
    {
        public addUserPage()
        {
            InitializeComponent();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Display image in PictureBox
                    pbPhoto.BackgroundImage = Image.FromFile(filePath);
                    pbPhoto.BackgroundImageLayout = ImageLayout.Zoom; // Adjust layout as needed
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }
    }
}
