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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.wishlistBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.homePanel = new BikeRental.customPanel();
            this.accountInfo = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
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
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(196, 807);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.Location = new System.Drawing.Point(0, 693);
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
            this.homePanel.Location = new System.Drawing.Point(196, 0);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(805, 839);
            this.homePanel.TabIndex = 1;
            // 
            // accountInfo
            // 
            this.accountInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.accountInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accountInfo.Location = new System.Drawing.Point(0, 750);
            this.accountInfo.Name = "accountInfo";
            this.accountInfo.Size = new System.Drawing.Size(196, 57);
            this.accountInfo.TabIndex = 4;
            this.accountInfo.Text = "Account";
            this.accountInfo.UseVisualStyleBackColor = false;
            // 
            // mainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(999, 805);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainApp";
            this.Text = "Bike Rental - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainApp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainApp_FormClosed);
            this.Load += new System.EventHandler(this.mainApp_Load);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}