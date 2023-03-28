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
            this.homePanel = new BikeRental.customPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.licenseBackPictureBox = new System.Windows.Forms.PictureBox();
            this.fileOpen2 = new System.Windows.Forms.Button();
            this.licenseUpload = new System.Windows.Forms.Label();
            this.licenseFrontPictureBox = new System.Windows.Forms.PictureBox();
            this.fileOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseFrontPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.licenseBackPictureBox);
            this.homePanel.Controls.Add(this.fileOpen2);
            this.homePanel.Controls.Add(this.licenseUpload);
            this.homePanel.Controls.Add(this.licenseFrontPictureBox);
            this.homePanel.Controls.Add(this.fileOpen);
            this.homePanel.Location = new System.Drawing.Point(195, 25);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(787, 626);
            this.homePanel.TabIndex = 1;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.loginPageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
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
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(982, 604);
            this.Controls.Add(this.homePanel);
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
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseFrontPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.Button wishlistBtn;
        private System.Windows.Forms.Button homeBtn;
        private customPanel homePanel;
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
    }
}