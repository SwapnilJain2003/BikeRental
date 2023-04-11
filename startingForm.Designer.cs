namespace BikeRental
{
    partial class startingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startingForm));
            this.LoginOrRegisterPanel = new System.Windows.Forms.Panel();
            this.RegisterRadioButton = new System.Windows.Forms.RadioButton();
            this.LoginRadioButton = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.passwordLoginTB = new System.Windows.Forms.TextBox();
            this.usernameLoginTB = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.savePdf = new System.Windows.Forms.LinkLabel();
            this.RegisterResult = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.TnCLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.agreeTnC = new System.Windows.Forms.CheckBox();
            this.confirmPassTB = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.Label();
            this.passwordRegisterTB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.gender = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.Label();
            this.usernameRegisterTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.usernameReg = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.registerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loginBtn = new BikeRental.ButtonCode();
            this.registerBtn = new BikeRental.ButtonCode();
            this.LoginOrRegisterPanel.SuspendLayout();
            this.RegisterGroupBox.SuspendLayout();
            this.genderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginOrRegisterPanel
            // 
            this.LoginOrRegisterPanel.Controls.Add(this.RegisterRadioButton);
            this.LoginOrRegisterPanel.Controls.Add(this.LoginRadioButton);
            this.LoginOrRegisterPanel.Location = new System.Drawing.Point(272, 109);
            this.LoginOrRegisterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginOrRegisterPanel.Name = "LoginOrRegisterPanel";
            this.LoginOrRegisterPanel.Size = new System.Drawing.Size(178, 32);
            this.LoginOrRegisterPanel.TabIndex = 1;
            // 
            // RegisterRadioButton
            // 
            this.RegisterRadioButton.AutoSize = true;
            this.RegisterRadioButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterRadioButton.Location = new System.Drawing.Point(93, 5);
            this.RegisterRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterRadioButton.Name = "RegisterRadioButton";
            this.RegisterRadioButton.Size = new System.Drawing.Size(81, 22);
            this.RegisterRadioButton.TabIndex = 2;
            this.RegisterRadioButton.TabStop = true;
            this.RegisterRadioButton.Text = "Register";
            this.RegisterRadioButton.UseVisualStyleBackColor = true;
            this.RegisterRadioButton.CheckedChanged += new System.EventHandler(this.RegisterRadioButton_CheckedChanged);
            // 
            // LoginRadioButton
            // 
            this.LoginRadioButton.AutoSize = true;
            this.LoginRadioButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginRadioButton.Location = new System.Drawing.Point(6, 5);
            this.LoginRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginRadioButton.Name = "LoginRadioButton";
            this.LoginRadioButton.Size = new System.Drawing.Size(63, 22);
            this.LoginRadioButton.TabIndex = 1;
            this.LoginRadioButton.TabStop = true;
            this.LoginRadioButton.Text = "Login";
            this.LoginRadioButton.UseVisualStyleBackColor = true;
            this.LoginRadioButton.CheckedChanged += new System.EventHandler(this.LoginRadioButton_CheckedChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(312, 144);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(11, 18);
            this.result.TabIndex = 0;
            this.result.Text = ".";
            // 
            // passwordLoginTB
            // 
            this.passwordLoginTB.Location = new System.Drawing.Point(315, 106);
            this.passwordLoginTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLoginTB.Name = "passwordLoginTB";
            this.passwordLoginTB.Size = new System.Drawing.Size(172, 32);
            this.passwordLoginTB.TabIndex = 4;
            this.passwordLoginTB.TextChanged += new System.EventHandler(this.passwordLoginTB_TextChanged);
            // 
            // usernameLoginTB
            // 
            this.usernameLoginTB.Location = new System.Drawing.Point(315, 72);
            this.usernameLoginTB.Margin = new System.Windows.Forms.Padding(2);
            this.usernameLoginTB.Name = "usernameLoginTB";
            this.usernameLoginTB.Size = new System.Drawing.Size(172, 32);
            this.usernameLoginTB.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(198, 106);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 25);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            this.password.Click += new System.EventHandler(this.label2_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(198, 72);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(106, 25);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RegisterGroupBox.Controls.Add(this.savePdf);
            this.RegisterGroupBox.Controls.Add(this.RegisterResult);
            this.RegisterGroupBox.Controls.Add(this.registerBtn);
            this.RegisterGroupBox.Controls.Add(this.userComboBox);
            this.RegisterGroupBox.Controls.Add(this.TnCLink);
            this.RegisterGroupBox.Controls.Add(this.label1);
            this.RegisterGroupBox.Controls.Add(this.agreeTnC);
            this.RegisterGroupBox.Controls.Add(this.confirmPassTB);
            this.RegisterGroupBox.Controls.Add(this.confirmPass);
            this.RegisterGroupBox.Controls.Add(this.passwordRegisterTB);
            this.RegisterGroupBox.Controls.Add(this.passwordLabel);
            this.RegisterGroupBox.Controls.Add(this.user);
            this.RegisterGroupBox.Controls.Add(this.genderPanel);
            this.RegisterGroupBox.Controls.Add(this.gender);
            this.RegisterGroupBox.Controls.Add(this.emailTB);
            this.RegisterGroupBox.Controls.Add(this.email);
            this.RegisterGroupBox.Controls.Add(this.dobPicker);
            this.RegisterGroupBox.Controls.Add(this.DOB);
            this.RegisterGroupBox.Controls.Add(this.usernameRegisterTB);
            this.RegisterGroupBox.Controls.Add(this.nameTB);
            this.RegisterGroupBox.Controls.Add(this.usernameReg);
            this.RegisterGroupBox.Controls.Add(this.name);
            this.RegisterGroupBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGroupBox.Location = new System.Drawing.Point(33, 508);
            this.RegisterGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RegisterGroupBox.Size = new System.Drawing.Size(664, 307);
            this.RegisterGroupBox.TabIndex = 4;
            this.RegisterGroupBox.TabStop = false;
            this.RegisterGroupBox.Text = "Register";
            // 
            // savePdf
            // 
            this.savePdf.AutoSize = true;
            this.savePdf.Location = new System.Drawing.Point(446, 220);
            this.savePdf.Name = "savePdf";
            this.savePdf.Size = new System.Drawing.Size(96, 21);
            this.savePdf.TabIndex = 24;
            this.savePdf.TabStop = true;
            this.savePdf.Text = "Save as Pdf";
            this.savePdf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.savePdf_LinkClicked);
            // 
            // RegisterResult
            // 
            this.RegisterResult.AutoSize = true;
            this.RegisterResult.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterResult.Location = new System.Drawing.Point(448, 208);
            this.RegisterResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegisterResult.Name = "RegisterResult";
            this.RegisterResult.Size = new System.Drawing.Size(11, 18);
            this.RegisterResult.TabIndex = 23;
            this.RegisterResult.Text = ".";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Items.AddRange(new object[] {
            "Buyer",
            "Seller"});
            this.userComboBox.Location = new System.Drawing.Point(450, 137);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(200, 29);
            this.userComboBox.TabIndex = 21;
            // 
            // TnCLink
            // 
            this.TnCLink.AutoSize = true;
            this.TnCLink.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TnCLink.Location = new System.Drawing.Point(132, 220);
            this.TnCLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TnCLink.Name = "TnCLink";
            this.TnCLink.Size = new System.Drawing.Size(142, 18);
            this.TnCLink.TabIndex = 20;
            this.TnCLink.TabStop = true;
            this.TnCLink.Text = "Terms and Conditions";
            this.TnCLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TnCLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "I agree to the";
            // 
            // agreeTnC
            // 
            this.agreeTnC.AutoSize = true;
            this.agreeTnC.Location = new System.Drawing.Point(31, 223);
            this.agreeTnC.Margin = new System.Windows.Forms.Padding(2);
            this.agreeTnC.Name = "agreeTnC";
            this.agreeTnC.Size = new System.Drawing.Size(15, 14);
            this.agreeTnC.TabIndex = 18;
            this.agreeTnC.UseVisualStyleBackColor = true;
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Location = new System.Drawing.Point(450, 179);
            this.confirmPassTB.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.Size = new System.Drawing.Size(200, 28);
            this.confirmPassTB.TabIndex = 17;
            this.confirmPassTB.TextChanged += new System.EventHandler(this.confirmPassTB_TextChanged);
            // 
            // confirmPass
            // 
            this.confirmPass.AutoSize = true;
            this.confirmPass.Location = new System.Drawing.Point(289, 182);
            this.confirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.Size = new System.Drawing.Size(152, 21);
            this.confirmPass.TabIndex = 16;
            this.confirmPass.Text = "Confirm Password:";
            // 
            // passwordRegisterTB
            // 
            this.passwordRegisterTB.Location = new System.Drawing.Point(112, 179);
            this.passwordRegisterTB.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegisterTB.Name = "passwordRegisterTB";
            this.passwordRegisterTB.Size = new System.Drawing.Size(172, 28);
            this.passwordRegisterTB.TabIndex = 15;
            this.passwordRegisterTB.TextChanged += new System.EventHandler(this.passwordRegisterTB_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(23, 181);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 21);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(352, 139);
            this.user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(89, 21);
            this.user.TabIndex = 12;
            this.user.Text = "User Type:";
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.otherRadioButton);
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(112, 139);
            this.genderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(167, 29);
            this.genderPanel.TabIndex = 11;
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRadioButton.Location = new System.Drawing.Point(110, 5);
            this.otherRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(54, 19);
            this.otherRadioButton.TabIndex = 14;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(51, 5);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(63, 19);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "FeMale";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(2, 5);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(51, 19);
            this.maleRadioButton.TabIndex = 12;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(39, 139);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(69, 21);
            this.gender.TabIndex = 10;
            this.gender.Text = "Gender:";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(450, 91);
            this.emailTB.Margin = new System.Windows.Forms.Padding(2);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(200, 28);
            this.emailTB.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(384, 91);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 21);
            this.email.TabIndex = 8;
            this.email.Text = "Email:";
            // 
            // dobPicker
            // 
            this.dobPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobPicker.Location = new System.Drawing.Point(112, 93);
            this.dobPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dobPicker.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.dobPicker.MinDate = new System.DateTime(1933, 1, 1, 0, 0, 0, 0);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(172, 28);
            this.dobPicker.TabIndex = 7;
            this.dobPicker.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(58, 99);
            this.DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(48, 21);
            this.DOB.TabIndex = 6;
            this.DOB.Text = "DOB:";
            // 
            // usernameRegisterTB
            // 
            this.usernameRegisterTB.Location = new System.Drawing.Point(450, 49);
            this.usernameRegisterTB.Margin = new System.Windows.Forms.Padding(2);
            this.usernameRegisterTB.Name = "usernameRegisterTB";
            this.usernameRegisterTB.Size = new System.Drawing.Size(200, 28);
            this.usernameRegisterTB.TabIndex = 5;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(112, 49);
            this.nameTB.Margin = new System.Windows.Forms.Padding(2);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(172, 28);
            this.nameTB.TabIndex = 4;
            // 
            // usernameReg
            // 
            this.usernameReg.AutoSize = true;
            this.usernameReg.Location = new System.Drawing.Point(352, 49);
            this.usernameReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameReg.Name = "usernameReg";
            this.usernameReg.Size = new System.Drawing.Size(91, 21);
            this.usernameReg.TabIndex = 1;
            this.usernameReg.Text = "Username:";
            this.usernameReg.Click += new System.EventHandler(this.usernameReg_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(48, 49);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 21);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(718, 98);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.LoginGroupBox.Controls.Add(this.passwordLoginTB);
            this.LoginGroupBox.Controls.Add(this.loginBtn);
            this.LoginGroupBox.Controls.Add(this.usernameLoginTB);
            this.LoginGroupBox.Controls.Add(this.result);
            this.LoginGroupBox.Controls.Add(this.username);
            this.LoginGroupBox.Controls.Add(this.password);
            this.LoginGroupBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(33, 146);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(664, 307);
            this.LoginGroupBox.TabIndex = 7;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 459);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(639, 37);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // loginToolTip
            // 
            this.loginToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.loginToolTip_Popup);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.loginBtn.Location = new System.Drawing.Point(241, 165);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(150, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click_1);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave_1);
            this.loginBtn.MouseHover += new System.EventHandler(this.loginBtn_MouseHover_1);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.ForeColor = System.Drawing.Color.Transparent;
            this.registerBtn.Location = new System.Drawing.Point(245, 252);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(133, 37);
            this.registerBtn.TabIndex = 22;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            this.registerBtn.MouseLeave += new System.EventHandler(this.registerBtn_MouseLeave);
            this.registerBtn.MouseHover += new System.EventHandler(this.registerBtn_MouseHover);
            // 
            // startingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(737, 505);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RegisterGroupBox);
            this.Controls.Add(this.LoginOrRegisterPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "startingForm";
            this.Text = "Bike Rental - Start";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.startingForm_FormClosed);
            this.Load += new System.EventHandler(this.startingForm_Load);
            this.LoginOrRegisterPanel.ResumeLayout(false);
            this.LoginOrRegisterPanel.PerformLayout();
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LoginOrRegisterPanel;
        private System.Windows.Forms.RadioButton RegisterRadioButton;
        private System.Windows.Forms.RadioButton LoginRadioButton;
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox passwordLoginTB;
        private System.Windows.Forms.TextBox usernameLoginTB;
        private System.Windows.Forms.Label usernameReg;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.TextBox usernameRegisterTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox confirmPassTB;
        private System.Windows.Forms.Label confirmPass;
        private System.Windows.Forms.TextBox passwordRegisterTB;
        private System.Windows.Forms.LinkLabel TnCLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox agreeTnC;
        private System.Windows.Forms.ComboBox userComboBox;
        private ButtonCode registerBtn;
        private System.Windows.Forms.Label RegisterResult;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ButtonCode loginBtn;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip loginToolTip;
        private System.Windows.Forms.ToolTip registerToolTip;
        private System.Windows.Forms.LinkLabel savePdf;
    }
}

