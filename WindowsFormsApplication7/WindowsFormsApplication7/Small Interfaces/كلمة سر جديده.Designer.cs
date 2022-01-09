namespace WindowsFormsApplication7.Small_Interfaces
{
    partial class FirstTimeNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeNewPassword));
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NewPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ConfirmPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 20;
            this.button1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ActiveForecolor = System.Drawing.Color.Black;
            this.button1.ActiveLineColor = System.Drawing.Color.SkyBlue;
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "تثبيت";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 20;
            this.button1.IdleFillColor = System.Drawing.SystemColors.Window;
            this.button1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.button1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(150, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 142;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPw
            // 
            this.NewPw.BackColor = System.Drawing.Color.White;
            this.NewPw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.NewPw.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.NewPw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.NewPw.BorderThickness = 1;
            this.NewPw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NewPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NewPw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewPw.isPassword = false;
            this.NewPw.Location = new System.Drawing.Point(44, 82);
            this.NewPw.Margin = new System.Windows.Forms.Padding(4);
            this.NewPw.Name = "NewPw";
            this.NewPw.Size = new System.Drawing.Size(264, 33);
            this.NewPw.TabIndex = 155;
            this.NewPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ConfirmPw
            // 
            this.ConfirmPw.BackColor = System.Drawing.Color.White;
            this.ConfirmPw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.ConfirmPw.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.ConfirmPw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.ConfirmPw.BorderThickness = 1;
            this.ConfirmPw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConfirmPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ConfirmPw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConfirmPw.isPassword = false;
            this.ConfirmPw.Location = new System.Drawing.Point(44, 137);
            this.ConfirmPw.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPw.Name = "ConfirmPw";
            this.ConfirmPw.Size = new System.Drawing.Size(264, 33);
            this.ConfirmPw.TabIndex = 156;
            this.ConfirmPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(315, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 158;
            this.label8.Text = "كلمة السر الجديدة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(315, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 157;
            this.label4.Text = "تأكيد كلمة السر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 159;
            this.label1.Text = "تثبيت كلمة سر";
            // 
            // FirstTimeNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(447, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmPw);
            this.Controls.Add(this.NewPw);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstTimeNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كلمة سر جديده";
            this.Load += new System.EventHandler(this.FirstTimeNewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox NewPw;
        private Bunifu.Framework.UI.BunifuMetroTextbox ConfirmPw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}