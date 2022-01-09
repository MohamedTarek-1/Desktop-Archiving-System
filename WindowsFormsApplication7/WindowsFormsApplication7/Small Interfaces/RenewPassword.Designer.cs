namespace WindowsFormsApplication7.Small_Interfaces
{
    partial class RenewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewPassword));
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NewPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ConfirmPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.oldPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sakkal Majalla", 13.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(298, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 24);
            this.label10.TabIndex = 129;
            this.label10.Text = "كلمة السر";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 13.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 130;
            this.label1.Text = "تأكيد كلمة السر";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 13.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(298, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 131;
            this.label2.Text = "كلمة السر الجديدة";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 13.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 132;
            this.label3.Text = "تغيير كلمة السر";
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
            this.button1.ButtonText = "تغيير";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 40;
            this.button1.IdleFillColor = System.Drawing.SystemColors.Window;
            this.button1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.button1.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(114, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
            this.button1.TabIndex = 182;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewPw
            // 
            this.NewPw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPw.BackColor = System.Drawing.Color.White;
            this.NewPw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.NewPw.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.NewPw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.NewPw.BorderThickness = 1;
            this.NewPw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NewPw.Font = new System.Drawing.Font("Sakkal Majalla", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPw.ForeColor = System.Drawing.Color.Black;
            this.NewPw.isPassword = false;
            this.NewPw.Location = new System.Drawing.Point(29, 111);
            this.NewPw.Margin = new System.Windows.Forms.Padding(4);
            this.NewPw.Name = "NewPw";
            this.NewPw.Size = new System.Drawing.Size(246, 24);
            this.NewPw.TabIndex = 183;
            this.NewPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ConfirmPw
            // 
            this.ConfirmPw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPw.BackColor = System.Drawing.Color.White;
            this.ConfirmPw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.ConfirmPw.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.ConfirmPw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.ConfirmPw.BorderThickness = 1;
            this.ConfirmPw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConfirmPw.Font = new System.Drawing.Font("Sakkal Majalla", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPw.ForeColor = System.Drawing.Color.Black;
            this.ConfirmPw.isPassword = false;
            this.ConfirmPw.Location = new System.Drawing.Point(29, 152);
            this.ConfirmPw.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPw.Name = "ConfirmPw";
            this.ConfirmPw.Size = new System.Drawing.Size(246, 24);
            this.ConfirmPw.TabIndex = 184;
            this.ConfirmPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // oldPw
            // 
            this.oldPw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPw.BackColor = System.Drawing.Color.White;
            this.oldPw.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.oldPw.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.oldPw.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.oldPw.BorderThickness = 1;
            this.oldPw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.oldPw.Font = new System.Drawing.Font("Sakkal Majalla", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPw.ForeColor = System.Drawing.Color.Black;
            this.oldPw.isPassword = false;
            this.oldPw.Location = new System.Drawing.Point(29, 69);
            this.oldPw.Margin = new System.Windows.Forms.Padding(4);
            this.oldPw.Name = "oldPw";
            this.oldPw.Size = new System.Drawing.Size(246, 24);
            this.oldPw.TabIndex = 185;
            this.oldPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RenewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 250);
            this.Controls.Add(this.oldPw);
            this.Controls.Add(this.ConfirmPw);
            this.Controls.Add(this.NewPw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(633, 384);
            this.MinimumSize = new System.Drawing.Size(424, 289);
            this.Name = "RenewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewPassword";
            this.Load += new System.EventHandler(this.RenewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox NewPw;
        private Bunifu.Framework.UI.BunifuMetroTextbox ConfirmPw;
        private Bunifu.Framework.UI.BunifuMetroTextbox oldPw;
    }
}