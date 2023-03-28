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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            aboutUsText.ReadOnly = true;
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void buttonCode1_Click(object sender, EventArgs e)
        {
            mainApp app = new mainApp();
            app.Show();
            this.Hide();
        }

        private void AboutUs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
