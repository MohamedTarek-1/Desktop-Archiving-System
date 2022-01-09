namespace WindowsFormsApplication7.Small_Interfaces
{
    partial class Passwordss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passwordss));
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 13.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(256, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "أدخل كلمة السر";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(450, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 24);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "تغيير كلمة السر";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(196, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordText.BackColor = System.Drawing.Color.White;
            this.PasswordText.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.PasswordText.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.PasswordText.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.PasswordText.BorderThickness = 1;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PasswordText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordText.isPassword = true;
            this.PasswordText.Location = new System.Drawing.Point(175, 101);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(212, 27);
            this.PasswordText.TabIndex = 185;
            this.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passwordss_KeyDown);
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 40;
            this.button1.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.button1.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.button1.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "دخول";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 30;
            this.button1.IdleFillColor = System.Drawing.SystemColors.Window;
            this.button1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.button1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(196, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 50, 10, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 42);
            this.button1.TabIndex = 186;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwordss
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Passwordss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Passwordss_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Passwordss_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox PasswordText;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
    }
}