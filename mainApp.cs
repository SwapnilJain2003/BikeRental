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
            homePanel.Visible = false;
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
            AboutUs app = new AboutUs();
            app.Show();
            this.Hide();
        }

        private void licenseFrontPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var app = new startingForm();
            app.Show();
            this.Hide();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                licenseUpload.Font = fontDialog1.Font;
                label1.Font = fontDialog1.Font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accountInfo_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            accountPanel.Visible = true;
            accountPanel.Location = new Point(195, 24);
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    result.Text = "Activa is Selected for";
                    break;

                case 1:
                    result.Text = "Bike is Selected for";
                    break;

                case 2:
                    result.Text = "Electric Bike is Selected for";
                    break;

                case 3:
                    result.Text = "Electric Scooty is Selected for";
                    break;

                case 4:
                    result.Text = "Cycle is Selected for";
                    break;

                case 5:
                    result.Text = "Electric Cycle is Selected for";
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int number = ((int)((int)numericUpDown1.Value * 300 * .05));
            int hours = (int)(numericUpDown1.Value);
            label2.Text = numericUpDown1.Value.ToString() + " Hours";
            label17.Text = numericUpDown1.Value.ToString();
            label18.Text = number.ToString();
            label20.Text = (300*hours+number - 10).ToString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            String dateSelected = monthCalendar2.SelectionRange.Start.ToString("dd MM yyyy");
            Console.WriteLine(dateSelected);
            label5.Text = "on " + dateSelected;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            accountPanel.Visible = false;
            homePanel.Location = new Point(195, 24);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
