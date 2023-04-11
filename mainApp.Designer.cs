namespace BikeRental
{
    partial class mainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainApp));
            this.menu = new System.Windows.Forms.Panel();
            this.accountInfo = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.wishlistBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.homePanel = new BikeRental.customPanel();
            this.accountPanel = new BikeRental.customPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseBackPictureBox = new System.Windows.Forms.PictureBox();
            this.fileOpen2 = new System.Windows.Forms.Button();
            this.licenseUpload = new System.Windows.Forms.Label();
            this.licenseFrontPictureBox = new System.Windows.Forms.PictureBox();
            this.fileOpen = new System.Windows.Forms.Button();
            this.billing = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseFrontPictureBox)).BeginInit();
            this.billing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.menu.Controls.Add(this.accountInfo);
            this.menu.Controls.Add(this.logoutBtn);
            this.menu.Controls.Add(this.cartBtn);
            this.menu.Controls.Add(this.addressBtn);
            this.menu.Controls.Add(this.wishlistBtn);
            this.menu.Controls.Add(this.homeBtn);
            this.menu.Location = new System.Drawing.Point(0, 24);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(196, 586);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // accountInfo
            // 
            this.accountInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.accountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accountInfo.Location = new System.Drawing.Point(0, 528);
            this.accountInfo.Name = "accountInfo";
            this.accountInfo.Size = new System.Drawing.Size(196, 57);
            this.accountInfo.TabIndex = 4;
            this.accountInfo.Text = "Account";
            this.accountInfo.UseVisualStyleBackColor = false;
            this.accountInfo.Click += new System.EventHandler(this.accountInfo_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.Location = new System.Drawing.Point(0, 475);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(196, 57);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "    Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cartBtn.Location = new System.Drawing.Point(0, 149);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(196, 57);
            this.cartBtn.TabIndex = 2;
            this.cartBtn.Text = "Cart";
            this.cartBtn.UseVisualStyleBackColor = false;
            // 
            // addressBtn
            // 
            this.addressBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.addressBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addressBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addressBtn.Location = new System.Drawing.Point(0, 99);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(196, 53);
            this.addressBtn.TabIndex = 1;
            this.addressBtn.Text = "Addresses";
            this.addressBtn.UseVisualStyleBackColor = false;
            // 
            // wishlistBtn
            // 
            this.wishlistBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.wishlistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wishlistBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wishlistBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.wishlistBtn.Location = new System.Drawing.Point(0, 48);
            this.wishlistBtn.Name = "wishlistBtn";
            this.wishlistBtn.Size = new System.Drawing.Size(196, 53);
            this.wishlistBtn.TabIndex = 1;
            this.wishlistBtn.Text = "Wishlist";
            this.wishlistBtn.UseVisualStyleBackColor = false;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(196, 50);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.loginPageToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loginPageToolStripMenuItem
            // 
            this.loginPageToolStripMenuItem.Name = "loginPageToolStripMenuItem";
            this.loginPageToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.loginPageToolStripMenuItem.Text = "Login Page";
            this.loginPageToolStripMenuItem.Click += new System.EventHandler(this.loginPageToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.fontToolStripMenuItem.Text = "Change Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.billing);
            this.homePanel.Controls.Add(this.label5);
            this.homePanel.Controls.Add(this.label4);
            this.homePanel.Controls.Add(this.label3);
            this.homePanel.Controls.Add(this.numericUpDown1);
            this.homePanel.Controls.Add(this.monthCalendar2);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.result);
            this.homePanel.Controls.Add(this.label10);
            this.homePanel.Controls.Add(this.listBox1);
            this.homePanel.Location = new System.Drawing.Point(1024, 30);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(787, 626);
            this.homePanel.TabIndex = 6;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // accountPanel
            // 
            this.accountPanel.Controls.Add(this.label1);
            this.accountPanel.Controls.Add(this.licenseBackPictureBox);
            this.accountPanel.Controls.Add(this.fileOpen2);
            this.accountPanel.Controls.Add(this.licenseUpload);
            this.accountPanel.Controls.Add(this.licenseFrontPictureBox);
            this.accountPanel.Controls.Add(this.fileOpen);
            this.accountPanel.Location = new System.Drawing.Point(195, 24);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(787, 626);
            this.accountPanel.TabIndex = 1;
            this.accountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upload License Back Page";
            // 
            // licenseBackPictureBox
            // 
            this.licenseBackPictureBox.Location = new System.Drawing.Point(35, 329);
            this.licenseBackPictureBox.Name = "licenseBackPictureBox";
            this.licenseBackPictureBox.Size = new System.Drawing.Size(353, 176);
            this.licenseBackPictureBox.TabIndex = 4;
            this.licenseBackPictureBox.TabStop = false;
            // 
            // fileOpen2
            // 
            this.fileOpen2.Location = new System.Drawing.Point(420, 345);
            this.fileOpen2.Name = "fileOpen2";
            this.fileOpen2.Size = new System.Drawing.Size(82, 31);
            this.fileOpen2.TabIndex = 3;
            this.fileOpen2.Text = "Select";
            this.fileOpen2.UseVisualStyleBackColor = true;
            this.fileOpen2.Click += new System.EventHandler(this.fileOpen2_Click);
            // 
            // licenseUpload
            // 
            this.licenseUpload.AutoSize = true;
            this.licenseUpload.BackColor = System.Drawing.Color.Transparent;
            this.licenseUpload.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseUpload.Location = new System.Drawing.Point(221, 18);
            this.licenseUpload.Name = "licenseUpload";
            this.licenseUpload.Size = new System.Drawing.Size(317, 32);
            this.licenseUpload.TabIndex = 2;
            this.licenseUpload.Text = "Upload License Front Page";
            this.licenseUpload.Click += new System.EventHandler(this.licenseUpload_Click);
            // 
            // licenseFrontPictureBox
            // 
            this.licenseFrontPictureBox.Location = new System.Drawing.Point(35, 71);
            this.licenseFrontPictureBox.Name = "licenseFrontPictureBox";
            this.licenseFrontPictureBox.Size = new System.Drawing.Size(353, 176);
            this.licenseFrontPictureBox.TabIndex = 1;
            this.licenseFrontPictureBox.TabStop = false;
            this.licenseFrontPictureBox.Click += new System.EventHandler(this.licenseFrontPictureBox_Click);
            // 
            // fileOpen
            // 
            this.fileOpen.Location = new System.Drawing.Point(420, 87);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(82, 31);
            this.fileOpen.TabIndex = 0;
            this.fileOpen.Text = "Select";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // billing
            // 
            this.billing.BackColor = System.Drawing.Color.Transparent;
            this.billing.Controls.Add(this.label20);
            this.billing.Controls.Add(this.label19);
            this.billing.Controls.Add(this.label18);
            this.billing.Controls.Add(this.label17);
            this.billing.Controls.Add(this.label16);
            this.billing.Controls.Add(this.label15);
            this.billing.Controls.Add(this.label14);
            this.billing.Controls.Add(this.label13);
            this.billing.Controls.Add(this.label12);
            this.billing.Controls.Add(this.label11);
            this.billing.Controls.Add(this.label9);
            this.billing.Controls.Add(this.label8);
            this.billing.Controls.Add(this.label7);
            this.billing.Controls.Add(this.label6);
            this.billing.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billing.Location = new System.Drawing.Point(79, 299);
            this.billing.Margin = new System.Windows.Forms.Padding(2);
            this.billing.Name = "billing";
            this.billing.Padding = new System.Windows.Forms.Padding(2);
            this.billing.Size = new System.Drawing.Size(611, 244);
            this.billing.TabIndex = 38;
            this.billing.TabStop = false;
            this.billing.Text = "Total Bill";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Discount: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "GST(5%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Base Amount: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Select Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Hours:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(292, 68);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(433, 68);
            this.monthCalendar2.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar2.MaxDate = new System.DateTime(2023, 5, 31, 0, 0, 0, 0);
            this.monthCalendar2.MinDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 33;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = ".";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(75, 136);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(12, 19);
            this.result.TabIndex = 31;
            this.result.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Select Type of Vehicle you want:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Activa",
            "Bike",
            "Electric Bike",
            "Electric Scooty",
            "Cycle",
            "Electric Cycle"});
            this.listBox1.Location = new System.Drawing.Point(50, 68);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 30);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hours:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "300";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "--------------------------------";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(266, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "--------------------------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(266, 23);
            this.label15.TabIndex = 8;
            this.label15.Text = "--------------------------------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(266, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "--------------------------------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(498, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "300";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(498, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "300";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(498, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 19);
            this.label19.TabIndex = 12;
            this.label19.Text = "10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(498, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 19);
            this.label20.TabIndex = 13;
            this.label20.Text = "300";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(965, 608);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainApp";
            this.Text = "Bike Rental - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainApp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainApp_FormClosed);
            this.Load += new System.EventHandler(this.mainApp_Load);
            this.menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseFrontPictureBox)).EndInit();
            this.billing.ResumeLayout(false);
            this.billing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.Button wishlistBtn;
        private System.Windows.Forms.Button homeBtn;
        private customPanel accountPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button accountInfo;
        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.PictureBox licenseFrontPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginPageToolStripMenuItem;
        private System.Windows.Forms.Label licenseUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox licenseBackPictureBox;
        private System.Windows.Forms.Button fileOpen2;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private customPanel homePanel;
        private System.Windows.Forms.GroupBox billing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}