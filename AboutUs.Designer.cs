namespace BikeRental
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.customPanel1 = new BikeRental.customPanel();
            this.aboutUsText = new System.Windows.Forms.TextBox();
            this.aboutUsLabel = new System.Windows.Forms.Label();
            this.buttonCode1 = new BikeRental.ButtonCode();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Controls.Add(this.aboutUsText);
            this.customPanel1.Location = new System.Drawing.Point(2, 46);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(807, 433);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // aboutUsText
            // 
            this.aboutUsText.BackColor = System.Drawing.Color.Lavender;
            this.aboutUsText.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutUsText.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsText.Location = new System.Drawing.Point(30, 28);
            this.aboutUsText.Multiline = true;
            this.aboutUsText.Name = "aboutUsText";
            this.aboutUsText.Size = new System.Drawing.Size(728, 338);
            this.aboutUsText.TabIndex = 0;
            this.aboutUsText.Text = resources.GetString("aboutUsText.Text");
            this.aboutUsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aboutUsText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aboutUsLabel
            // 
            this.aboutUsLabel.AutoSize = true;
            this.aboutUsLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutUsLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsLabel.ForeColor = System.Drawing.Color.White;
            this.aboutUsLabel.Location = new System.Drawing.Point(300, 11);
            this.aboutUsLabel.Name = "aboutUsLabel";
            this.aboutUsLabel.Size = new System.Drawing.Size(183, 32);
            this.aboutUsLabel.TabIndex = 3;
            this.aboutUsLabel.Text = "About Us Page";
            // 
            // buttonCode1
            // 
            this.buttonCode1.BackColor = System.Drawing.Color.Lavender;
            this.buttonCode1.FlatAppearance.BorderSize = 0;
            this.buttonCode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCode1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCode1.ForeColor = System.Drawing.Color.Black;
            this.buttonCode1.Location = new System.Drawing.Point(12, 9);
            this.buttonCode1.Name = "buttonCode1";
            this.buttonCode1.Size = new System.Drawing.Size(121, 41);
            this.buttonCode1.TabIndex = 4;
            this.buttonCode1.Text = "Back";
            this.buttonCode1.UseVisualStyleBackColor = false;
            this.buttonCode1.Click += new System.EventHandler(this.buttonCode1_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCode1);
            this.Controls.Add(this.aboutUsLabel);
            this.Controls.Add(this.customPanel1);
            this.Name = "AboutUs";
            this.Text = "About Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutUs_FormClosing);
            this.Load += new System.EventHandler(this.AboutUs_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customPanel customPanel1;
        private System.Windows.Forms.TextBox aboutUsText;
        private System.Windows.Forms.Label aboutUsLabel;
        private ButtonCode buttonCode1;
    }
}