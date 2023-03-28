using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRental
{
    public partial class mainApp : Form
    {
        Image file;
        public mainApp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Padding = new System.Windows.Forms.Padding(10);
        }

        private void myGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void mainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var startingForm = new startingForm();
            startingForm.Show();
            this.Hide();
        }

        private void mainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }

        private void mainApp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG (*.JPG)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(fileDialog.FileName);
                licenseFrontPictureBox.Image = file;
            }
        }

        private void licenseUpload_Click(object sender, EventArgs e)
        {

        }

        private void fileOpen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG (*.JPG)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(fileDialog.FileName);
                licenseBackPictureBox.Image = file;
            }
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
