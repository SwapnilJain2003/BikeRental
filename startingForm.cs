using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
/*using iTextSharp.text;
using iTextSharp.text.pdf;*/
using iTextSharp.text;

namespace BikeRental
{
    public partial class startingForm : Form
    {
        public startingForm()
        {
            InitializeComponent();
 
        }

        private void LoginRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoginGroupBox.Visible = true;
            RegisterGroupBox.Visible = false;
            LoginGroupBox.Location = new Point(33, 144);
            

        }

        private void RegisterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RegisterGroupBox.Visible = true;
            LoginGroupBox.Visible = false;
            RegisterGroupBox.Location = new Point(33, 144);
            
        }

        private void LoginGroupBox_Enter(object sender, EventArgs e)
        {
         
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void usernameReg_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void TnCLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterResult.Text = " ";
            String gender = "N/A", user = "N/A";
            int gflag = 0, uflag = 0;
            if (maleRadioButton.Checked)
            {
                gender = "Male";
            }
            else if (femaleRadioButton.Checked)
            {
                gender = "Female";
            }else if (otherRadioButton.Checked)
            {
                gender = "Other";
            }
            else
            {
                gflag = 1;
            }

            if(userComboBox.SelectedIndex == -1)
            {
                uflag= 1;
            }
            else if(userComboBox.SelectedIndex == 0)
            {
                user = "Buyer";
            }else if(userComboBox.SelectedIndex == 1)
            {
                user = "Seller";
            }

            if (nameTB.TextLength == 0 || emailTB.TextLength == 0 || usernameRegisterTB.TextLength == 0 || passwordRegisterTB.TextLength == 0 || confirmPassTB.TextLength == 0 || gflag == 1 || uflag == 1)
            {
                MessageBox.Show("All Details should be filled", "Error!");
                Console.WriteLine("Successful 1");
            }
            else
            {
                String name = nameTB.Text;
                String user_name = usernameRegisterTB.Text;
                String email = emailTB.Text;
                bool emailFlag = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool unameFlag = Regex.IsMatch(user_name, "^(?=.{3,32}$)(?!.*[._-]{2})(?!.*[0-9]{5,})[a-z](?:[\\w]*|[a-z\\d\\.]*|[a-z\\d-]*)[a-z0-9]$", RegexOptions.IgnoreCase);
                if (!emailFlag)
                {
                    MessageBox.Show("Email is not valid");
                    Console.WriteLine("Successful 2");
                }
                else
                {
                    emailFlag = true;
                }
                if (!unameFlag)
                {
                    MessageBox.Show("Enter Valid Username!!");
                    Console.WriteLine("Successful 3");
                }
                else
                {
                    unameFlag = true;
                }
                if (unameFlag == true && emailFlag == true)
                {
                    Console.WriteLine("Successful 4");
                    if (passwordRegisterTB.Text == confirmPassTB.Text)
                    {

                        if (agreeTnC.Checked)
                        {
                            Console.WriteLine("Successful 5");
                            MessageBox.Show("Account Created successfully");
                            RegisterResult.Text = "Name : " + name + "\nUsername : " + user_name + "\nEmail : " + email + "\nGender : " + gender + "\nUser Type : " + user;
                            progressBar1.Visible = true;
                            timer1.Enabled = true;
                            timer1.Start();
                            timer1.Interval = 10;
                            progressBar1.Maximum = 100;
                            timer1.Tick += new EventHandler(timer1_Tick);
                        }
                        else
                        {
                            MessageBox.Show("Terms & Conditions should be accepted!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                       
                        /*var home = new home();
                        home.Visible = true; ;
                        this.Hide();*/
                    }
                    else
                    {
                        Console.WriteLine("Successful 6");
                        MessageBox.Show("Password is not Matching!", "Error!");
                        result.Text = "Password is not Matching!";
                    }
                }

            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void passwordLoginTB_TextChanged(object sender, EventArgs e)
        {
            passwordLoginTB.PasswordChar = '●';
        }

        private void passwordRegisterTB_TextChanged(object sender, EventArgs e)
        {
            passwordRegisterTB.PasswordChar = '●';
        }

        private void confirmPassTB_TextChanged(object sender, EventArgs e)
        {
            confirmPassTB.PasswordChar = '●';
        }

        private void startingForm_Load(object sender, EventArgs e)
        {
            loginToolTip.UseFading = true;
            loginToolTip.UseAnimation = true;
            loginToolTip.IsBalloon = true;
            loginToolTip.ShowAlways = true;
            loginToolTip.AutoPopDelay = 5000;
            loginToolTip.InitialDelay = 100;
            loginToolTip.ReshowDelay = 500;
            loginToolTip.SetToolTip(loginBtn, "Click me to login");
            registerToolTip.UseFading = true;
            registerToolTip.UseAnimation = true;
            registerToolTip.IsBalloon = true;
            registerToolTip.ShowAlways = true;
            registerToolTip.AutoPopDelay = 5000;
            registerToolTip.InitialDelay = 100;
            registerToolTip.ReshowDelay = 500;
            registerToolTip.SetToolTip(registerBtn, "Click me to Register");
            progressBar1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_MouseHover(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Green;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void registerBtn_MouseHover(object sender, EventArgs e)
        {
            registerBtn.BackColor = Color.RoyalBlue;
        }

        private void registerBtn_MouseLeave(object sender, EventArgs e)
        {
            registerBtn.BackColor= Color.MidnightBlue;
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {

            String username = "username";
            String password = "password";

            if (usernameLoginTB.Text == username && passwordLoginTB.Text == password)
            {
                progressBar1.Value = 0;
                result.ForeColor = Color.CornflowerBlue;
                result.Text = "Credentials Ok!!";
                progressBar1.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 10;
                progressBar1.Maximum = 100;
                timer1.Tick += new EventHandler(timer1_Tick);
                
            }
            else
            {

                result.ForeColor = Color.Red;
                result.Text = "Wrong Credentials!!";
            }
        }

        private void loginBtn_MouseHover_1(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.RoyalBlue;
        }

        private void loginBtn_MouseLeave_1(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.MidnightBlue;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                var app = new mainApp();
                app.Show();
                this.Hide();
            }
        }

        private void loginToolTip_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void startingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void savePdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF Files|*.pdf";
            saveFileDialog1.Title = "Save as Text";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    PdfWriter writer = new PdfWriter(saveFileDialog1.FileName);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Registration Information\n\n")
                        .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                        .SetFontSize(16));
                    document.Add(new Paragraph($"Name: {nameTB.Text}"));
                    document.Add(new Paragraph($"Email: {emailTB.Text}"));
                    document.Add(new Paragraph($"Username: {usernameRegisterTB.Text}"));
                    document.Add(new Paragraph($"Password: {passwordRegisterTB.Text}"));
                    document.Close();
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            //}
        }
    }
}
