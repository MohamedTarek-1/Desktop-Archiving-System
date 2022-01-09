namespace WindowsFormsApplication7.MainPages
{
    partial class existingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(existingForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.type1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.serial1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView111 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.existsSrchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.existsSrchButton);
            this.groupBox2.Controls.Add(this.serial1);
            this.groupBox2.Controls.Add(this.type1);
            this.groupBox2.Controls.Add(this.name1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(0, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 104);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(221, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "السيريال";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(407, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 76;
            this.label8.Text = "الصنف";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(594, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "الأسم";
            // 
            // name1
            // 
            this.name1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name1.BackColor = System.Drawing.Color.White;
            this.name1.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.name1.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.name1.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.name1.BorderThickness = 1;
            this.name1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name1.Font = new System.Drawing.Font("Sakkal Majalla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.ForeColor = System.Drawing.Color.Black;
            this.name1.isPassword = false;
            this.name1.Location = new System.Drawing.Point(482, 19);
            this.name1.Margin = new System.Windows.Forms.Padding(4);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(105, 24);
            this.name1.TabIndex = 172;
            this.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // type1
            // 
            this.type1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type1.BackColor = System.Drawing.Color.White;
            this.type1.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.type1.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.type1.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.type1.BorderThickness = 1;
            this.type1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.type1.Font = new System.Drawing.Font("Sakkal Majalla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type1.ForeColor = System.Drawing.Color.Black;
            this.type1.isPassword = false;
            this.type1.Location = new System.Drawing.Point(295, 19);
            this.type1.Margin = new System.Windows.Forms.Padding(4);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(105, 24);
            this.type1.TabIndex = 173;
            this.type1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // serial1
            // 
            this.serial1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serial1.BackColor = System.Drawing.Color.White;
            this.serial1.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.serial1.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.serial1.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.serial1.BorderThickness = 1;
            this.serial1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.serial1.Font = new System.Drawing.Font("Sakkal Majalla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial1.ForeColor = System.Drawing.Color.Black;
            this.serial1.isPassword = false;
            this.serial1.Location = new System.Drawing.Point(109, 19);
            this.serial1.Margin = new System.Windows.Forms.Padding(4);
            this.serial1.Name = "serial1";
            this.serial1.Size = new System.Drawing.Size(105, 24);
            this.serial1.TabIndex = 174;
            this.serial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView111
            // 
            this.dataGridView111.AllowUserToAddRows = false;
            this.dataGridView111.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dataGridView111.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView111.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView111.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView111.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView111.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView111.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView111.ColumnHeadersHeight = 29;
            this.dataGridView111.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView111.DoubleBuffered = true;
            this.dataGridView111.EnableHeadersVisualStyles = false;
            this.dataGridView111.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView111.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.dataGridView111.HeaderForeColor = System.Drawing.SystemColors.Menu;
            this.dataGridView111.Location = new System.Drawing.Point(0, 0);
            this.dataGridView111.Name = "dataGridView111";
            this.dataGridView111.ReadOnly = true;
            this.dataGridView111.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView111.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView111.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView111.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView111.Size = new System.Drawing.Size(658, 398);
            this.dataGridView111.TabIndex = 141;
            // 
            // existsSrchButton
            // 
            this.existsSrchButton.ActiveBorderThickness = 1;
            this.existsSrchButton.ActiveCornerRadius = 20;
            this.existsSrchButton.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.existsSrchButton.ActiveForecolor = System.Drawing.Color.WhiteSmoke;
            this.existsSrchButton.ActiveLineColor = System.Drawing.Color.PowderBlue;
            this.existsSrchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existsSrchButton.BackColor = System.Drawing.Color.White;
            this.existsSrchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("existsSrchButton.BackgroundImage")));
            this.existsSrchButton.ButtonText = "بحث";
            this.existsSrchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.existsSrchButton.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existsSrchButton.ForeColor = System.Drawing.Color.Teal;
            this.existsSrchButton.IdleBorderThickness = 1;
            this.existsSrchButton.IdleCornerRadius = 20;
            this.existsSrchButton.IdleFillColor = System.Drawing.SystemColors.Window;
            this.existsSrchButton.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.existsSrchButton.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.existsSrchButton.Location = new System.Drawing.Point(265, 58);
            this.existsSrchButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.existsSrchButton.Name = "existsSrchButton";
            this.existsSrchButton.Size = new System.Drawing.Size(144, 37);
            this.existsSrchButton.TabIndex = 185;
            this.existsSrchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.existsSrchButton.Click += new System.EventHandler(this.existsSrchButton_Click);
            // 
            // existingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 502);
            this.Controls.Add(this.dataGridView111);
            this.Controls.Add(this.groupBox2);
            this.Name = "existingForm";
            this.Text = "existingForm";
            this.Load += new System.EventHandler(this.existingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView111)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox serial1;
        private Bunifu.Framework.UI.BunifuMetroTextbox type1;
        private Bunifu.Framework.UI.BunifuMetroTextbox name1;
        private Bunifu.Framework.UI.BunifuThinButton2 existsSrchButton;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView111;
    }
}