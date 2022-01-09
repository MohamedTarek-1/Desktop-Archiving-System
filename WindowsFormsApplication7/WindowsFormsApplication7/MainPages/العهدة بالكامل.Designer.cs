namespace WindowsFormsApplication7
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlideArrow = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.firstPanel = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.ArrowButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PrintButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ChangeData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OriginalSubButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.returnSubButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.OutSubButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InSubButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.firstButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlideArrow.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.firstPanel.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSlideArrow
            // 
            this.panelSlideArrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSlideArrow.Controls.Add(this.ArrowButton);
            this.panelSlideArrow.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSlideArrow.Location = new System.Drawing.Point(690, 0);
            this.panelSlideArrow.Name = "panelSlideArrow";
            this.panelSlideArrow.Size = new System.Drawing.Size(19, 426);
            this.panelSlideArrow.TabIndex = 173;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.panelSlideArrow);
            this.panelChildForm.Controls.Add(this.pictureBox3);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(709, 426);
            this.panelChildForm.TabIndex = 175;
            // 
            // panelLabel
            // 
            this.panelLabel.AutoSize = true;
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLabel.Location = new System.Drawing.Point(0, 10);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(181, 0);
            this.panelLabel.TabIndex = 158;
            // 
            // firstPanel
            // 
            this.firstPanel.AutoScroll = true;
            this.firstPanel.BackColor = System.Drawing.Color.White;
            this.firstPanel.Controls.Add(this.OriginalSubButton);
            this.firstPanel.Controls.Add(this.returnSubButton);
            this.firstPanel.Controls.Add(this.OutSubButton);
            this.firstPanel.Controls.Add(this.InSubButton);
            this.firstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstPanel.Location = new System.Drawing.Point(0, 108);
            this.firstPanel.Name = "firstPanel";
            this.firstPanel.Size = new System.Drawing.Size(181, 142);
            this.firstPanel.TabIndex = 173;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.MintCream;
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideMenu.Controls.Add(this.ExitButton);
            this.panelSideMenu.Controls.Add(this.PrintButton);
            this.panelSideMenu.Controls.Add(this.ChangeData);
            this.panelSideMenu.Controls.Add(this.firstPanel);
            this.panelSideMenu.Controls.Add(this.firstButton);
            this.panelSideMenu.Controls.Add(this.pictureBox2);
            this.panelSideMenu.Controls.Add(this.panelLabel);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideMenu.Location = new System.Drawing.Point(709, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelSideMenu.Size = new System.Drawing.Size(183, 426);
            this.panelSideMenu.TabIndex = 174;
            // 
            // ArrowButton
            // 
            this.ArrowButton.ActiveBorderThickness = 1;
            this.ArrowButton.ActiveCornerRadius = 40;
            this.ArrowButton.ActiveFillColor = System.Drawing.Color.Silver;
            this.ArrowButton.ActiveForecolor = System.Drawing.Color.Black;
            this.ArrowButton.ActiveLineColor = System.Drawing.Color.DarkSlateGray;
            this.ArrowButton.BackColor = System.Drawing.Color.White;
            this.ArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArrowButton.BackgroundImage")));
            this.ArrowButton.ButtonText = "<";
            this.ArrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrowButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArrowButton.Font = new System.Drawing.Font("Vladimir Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrowButton.ForeColor = System.Drawing.Color.Teal;
            this.ArrowButton.IdleBorderThickness = 1;
            this.ArrowButton.IdleCornerRadius = 40;
            this.ArrowButton.IdleFillColor = System.Drawing.SystemColors.Window;
            this.ArrowButton.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.ArrowButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.ArrowButton.Location = new System.Drawing.Point(0, 0);
            this.ArrowButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ArrowButton.Name = "ArrowButton";
            this.ArrowButton.Size = new System.Drawing.Size(17, 424);
            this.ArrowButton.TabIndex = 182;
            this.ArrowButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ArrowButton.Click += new System.EventHandler(this.Arrow_Button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.ErrorImage = global::WindowsFormsApplication7.Resources.IMC;
            this.pictureBox3.Image = global::WindowsFormsApplication7.Resources.Copy_of_Grain_logo_icon___Made_with_PosterMyWall;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(709, 426);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 172;
            this.pictureBox3.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.ActiveBorderThickness = 1;
            this.ExitButton.ActiveCornerRadius = 40;
            this.ExitButton.ActiveFillColor = System.Drawing.Color.Salmon;
            this.ExitButton.ActiveForecolor = System.Drawing.Color.White;
            this.ExitButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.ExitButton.BackColor = System.Drawing.Color.MintCream;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.ButtonText = "خروج";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitButton.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Teal;
            this.ExitButton.IdleBorderThickness = 1;
            this.ExitButton.IdleCornerRadius = 40;
            this.ExitButton.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.ExitButton.IdleLineColor = System.Drawing.Color.Teal;
            this.ExitButton.Location = new System.Drawing.Point(0, 358);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(181, 54);
            this.ExitButton.TabIndex = 200;
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.ActiveBorderThickness = 1;
            this.PrintButton.ActiveCornerRadius = 40;
            this.PrintButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.PrintButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.PrintButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.PrintButton.BackColor = System.Drawing.Color.MintCream;
            this.PrintButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintButton.BackgroundImage")));
            this.PrintButton.ButtonText = "طباعة";
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintButton.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.Teal;
            this.PrintButton.IdleBorderThickness = 1;
            this.PrintButton.IdleCornerRadius = 40;
            this.PrintButton.IdleFillColor = System.Drawing.SystemColors.Window;
            this.PrintButton.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.PrintButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.PrintButton.Location = new System.Drawing.Point(0, 304);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(181, 54);
            this.PrintButton.TabIndex = 199;
            this.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ChangeData
            // 
            this.ChangeData.ActiveBorderThickness = 1;
            this.ChangeData.ActiveCornerRadius = 40;
            this.ChangeData.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.ChangeData.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.ChangeData.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.ChangeData.BackColor = System.Drawing.Color.MintCream;
            this.ChangeData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeData.BackgroundImage")));
            this.ChangeData.ButtonText = "تغيير بيانات";
            this.ChangeData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeData.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeData.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeData.ForeColor = System.Drawing.Color.Teal;
            this.ChangeData.IdleBorderThickness = 1;
            this.ChangeData.IdleCornerRadius = 40;
            this.ChangeData.IdleFillColor = System.Drawing.SystemColors.Window;
            this.ChangeData.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.ChangeData.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.ChangeData.Location = new System.Drawing.Point(0, 250);
            this.ChangeData.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ChangeData.Name = "ChangeData";
            this.ChangeData.Size = new System.Drawing.Size(181, 54);
            this.ChangeData.TabIndex = 197;
            this.ChangeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeData.Click += new System.EventHandler(this.ChangeData_Click);
            // 
            // OriginalSubButton
            // 
            this.OriginalSubButton.ActiveBorderThickness = 1;
            this.OriginalSubButton.ActiveCornerRadius = 25;
            this.OriginalSubButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.OriginalSubButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.OriginalSubButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.OriginalSubButton.BackColor = System.Drawing.Color.White;
            this.OriginalSubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OriginalSubButton.BackgroundImage")));
            this.OriginalSubButton.ButtonText = "كميات عند الدخول";
            this.OriginalSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OriginalSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OriginalSubButton.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.OriginalSubButton.ForeColor = System.Drawing.Color.Teal;
            this.OriginalSubButton.IdleBorderThickness = 1;
            this.OriginalSubButton.IdleCornerRadius = 25;
            this.OriginalSubButton.IdleFillColor = System.Drawing.Color.SeaShell;
            this.OriginalSubButton.IdleForecolor = System.Drawing.Color.Black;
            this.OriginalSubButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.OriginalSubButton.Location = new System.Drawing.Point(0, 105);
            this.OriginalSubButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OriginalSubButton.Name = "OriginalSubButton";
            this.OriginalSubButton.Size = new System.Drawing.Size(181, 35);
            this.OriginalSubButton.TabIndex = 198;
            this.OriginalSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OriginalSubButton.Click += new System.EventHandler(this.OriginalQtySub_Click);
            // 
            // returnSubButton
            // 
            this.returnSubButton.ActiveBorderThickness = 1;
            this.returnSubButton.ActiveCornerRadius = 25;
            this.returnSubButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.returnSubButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.returnSubButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.returnSubButton.BackColor = System.Drawing.Color.White;
            this.returnSubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnSubButton.BackgroundImage")));
            this.returnSubButton.ButtonText = "مستردات";
            this.returnSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnSubButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnSubButton.ForeColor = System.Drawing.Color.Teal;
            this.returnSubButton.IdleBorderThickness = 1;
            this.returnSubButton.IdleCornerRadius = 25;
            this.returnSubButton.IdleFillColor = System.Drawing.Color.SeaShell;
            this.returnSubButton.IdleForecolor = System.Drawing.Color.Black;
            this.returnSubButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.returnSubButton.Location = new System.Drawing.Point(0, 70);
            this.returnSubButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.returnSubButton.Name = "returnSubButton";
            this.returnSubButton.Size = new System.Drawing.Size(181, 35);
            this.returnSubButton.TabIndex = 197;
            this.returnSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnSubButton.Click += new System.EventHandler(this.ReturnedBtn_Click);
            // 
            // OutSubButton
            // 
            this.OutSubButton.ActiveBorderThickness = 1;
            this.OutSubButton.ActiveCornerRadius = 25;
            this.OutSubButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.OutSubButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.OutSubButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.OutSubButton.BackColor = System.Drawing.Color.White;
            this.OutSubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OutSubButton.BackgroundImage")));
            this.OutSubButton.ButtonText = "خارج";
            this.OutSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutSubButton.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.OutSubButton.ForeColor = System.Drawing.Color.Teal;
            this.OutSubButton.IdleBorderThickness = 1;
            this.OutSubButton.IdleCornerRadius = 25;
            this.OutSubButton.IdleFillColor = System.Drawing.Color.SeaShell;
            this.OutSubButton.IdleForecolor = System.Drawing.Color.Black;
            this.OutSubButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.OutSubButton.Location = new System.Drawing.Point(0, 35);
            this.OutSubButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.OutSubButton.Name = "OutSubButton";
            this.OutSubButton.Size = new System.Drawing.Size(181, 35);
            this.OutSubButton.TabIndex = 196;
            this.OutSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutSubButton.Click += new System.EventHandler(this.outSubFormBtn_Click);
            // 
            // InSubButton
            // 
            this.InSubButton.ActiveBorderThickness = 1;
            this.InSubButton.ActiveCornerRadius = 25;
            this.InSubButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.InSubButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.InSubButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.InSubButton.BackColor = System.Drawing.Color.White;
            this.InSubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InSubButton.BackgroundImage")));
            this.InSubButton.ButtonText = "موجود";
            this.InSubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InSubButton.Font = new System.Drawing.Font("Sakkal Majalla", 13F, System.Drawing.FontStyle.Bold);
            this.InSubButton.ForeColor = System.Drawing.Color.Teal;
            this.InSubButton.IdleBorderThickness = 1;
            this.InSubButton.IdleCornerRadius = 25;
            this.InSubButton.IdleFillColor = System.Drawing.Color.SeaShell;
            this.InSubButton.IdleForecolor = System.Drawing.Color.Black;
            this.InSubButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.InSubButton.Location = new System.Drawing.Point(0, 0);
            this.InSubButton.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.InSubButton.Name = "InSubButton";
            this.InSubButton.Size = new System.Drawing.Size(181, 35);
            this.InSubButton.TabIndex = 195;
            this.InSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InSubButton.Click += new System.EventHandler(this.existingFormBtnClick);
            // 
            // firstButton
            // 
            this.firstButton.ActiveBorderThickness = 1;
            this.firstButton.ActiveCornerRadius = 40;
            this.firstButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.firstButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.firstButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.firstButton.BackColor = System.Drawing.Color.MintCream;
            this.firstButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstButton.BackgroundImage")));
            this.firstButton.ButtonText = "العهدة";
            this.firstButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstButton.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.ForeColor = System.Drawing.Color.Teal;
            this.firstButton.IdleBorderThickness = 1;
            this.firstButton.IdleCornerRadius = 40;
            this.firstButton.IdleFillColor = System.Drawing.SystemColors.Window;
            this.firstButton.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.firstButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.firstButton.Location = new System.Drawing.Point(0, 54);
            this.firstButton.Margin = new System.Windows.Forms.Padding(5);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(181, 54);
            this.firstButton.TabIndex = 180;
            this.firstButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstButton.Click += new System.EventHandler(this.openCloseSubMenu);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.ErrorImage = global::WindowsFormsApplication7.Resources.IMC;
            this.pictureBox2.Image = global::WindowsFormsApplication7.Resources.Copy_of_Grain_logo_icon___Made_with_PosterMyWall;
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1429, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 426);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 465);
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العهدة بالكامل";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelSlideArrow.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.firstPanel.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelSlideArrow;
        private System.Windows.Forms.Panel panelChildForm;
        private Bunifu.Framework.UI.BunifuThinButton2 ArrowButton;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 firstButton;
        private System.Windows.Forms.Panel firstPanel;
        private System.Windows.Forms.Panel panelSideMenu;
        private Bunifu.Framework.UI.BunifuThinButton2 OriginalSubButton;
        private Bunifu.Framework.UI.BunifuThinButton2 returnSubButton;
        private Bunifu.Framework.UI.BunifuThinButton2 OutSubButton;
        private Bunifu.Framework.UI.BunifuThinButton2 InSubButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ChangeData;
        private Bunifu.Framework.UI.BunifuThinButton2 ExitButton;
        private Bunifu.Framework.UI.BunifuThinButton2 PrintButton;
    }
}