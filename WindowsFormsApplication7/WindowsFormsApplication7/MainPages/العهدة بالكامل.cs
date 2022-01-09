using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        //SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        DataTable dt2 = new DataTable();
        int panelWidth;
        bool hidden;
        public Form4()
        {
            InitializeComponent();
            customizeDesign();
            panelWidth = panelSideMenu.Width;
            hidden = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        #region exiting
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region cellFormatCode  //if needed
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView1 = sender as DataGridView;
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }
        #endregion
        #region keyDowns

        /*
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Exist.PerformClick();
                SearchButton_Click(type1, e);

            }
        }
        
        private void textBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Exist.PerformClick();
                SearchButton_Click(type1, e);

            }
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Exist.PerformClick();
                SearchButton_Click(type1, e);

            }
        }

        private void receiver2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // SearchButton.PerformClick();
                SearchButton_Click(type1, e);

            }
        }

        private void dept2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Exist.PerformClick();
                SearchButton_Click(type1, e);

            }
        }

        private void name1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //  existsSrchButton.PerformClick();
                existsSrchButton_Click(type1, e);

            }

        }

        private void type1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                existsSrchButton_Click(type1, e);

            }


        }

        private void serial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //existsSrchButton.PerformClick();
                existsSrchButton_Click(type1, e);

            }
        }
        */
        #endregion

        #region subMenus
        private void customizeDesign()
        {
            firstPanel.Visible = false;
        }


        private Form activeForm = null;

        private void openCloseSubMenu(object sender, EventArgs e)
        {
            if (firstPanel.Visible == false)
            {
                firstPanel.Visible = true;
               // pictureBox3.Visible = false;

            }
            else if (firstPanel.Visible == true)
            {
                pictureBox3.Visible = true;
                firstPanel.Visible = false;
            }
        }

        #endregion

        #region subMenusClicks

        private void existingFormBtnClick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            openChildform(new MainPages.existingForm());
            ForeColorAll();
            InSubButton.IdleForecolor=Color.SteelBlue;
        
        }
        private void outSubFormBtn_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            openChildform(new MainPages.outSubForm());
            ForeColorAll();

            OutSubButton.IdleForecolor = Color.SteelBlue;

        }
        private void ReturnedBtn_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            openChildform(new MainPages.returnedInfoForm());
            ForeColorAll();

            returnSubButton.IdleForecolor = Color.SteelBlue;

        }
        private void OriginalQtySub_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            openChildform(new MainPages.OriginalSubForm());
            ForeColorAll();

            OriginalSubButton.IdleForecolor = Color.SteelBlue;

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            if (firstPanel.Visible == true)
            {
                firstPanel.Visible = false;
            }
            openChildform(new PrintButtons());
            ForeColorAll();

        }
        private void ChangeData_Click(object sender, EventArgs e)
        {

            pictureBox3.Visible = false;
            if (firstPanel.Visible == true)
            {
                pictureBox3.Visible = false;
                firstPanel.Visible = false;
            }

                openChildform(new Small_Interfaces.Passwordss());
                ForeColorAll();
            
        }

       #endregion
        #region Functions
        private void ForeColorAll()
        {
            returnSubButton.IdleForecolor = Color.Black;
            OutSubButton.IdleForecolor = Color.Black;
            InSubButton.IdleForecolor = Color.Black;
            OriginalSubButton.IdleForecolor = Color.Black;

        }
        private void openChildform(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            panelChildForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion



        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }


        private void Arrow_Button_Click(object sender, EventArgs e)
        {
            if (hidden)
            { 
                panelSideMenu.Show();
                hidden = false;
                ArrowButton.ButtonText = "<";

            }
            else
            {

                panelSideMenu.Hide();
                hidden = true;
                ArrowButton.ButtonText = ">";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(hidden)
            {
                panelSideMenu.Width = 183;
                if(panelSideMenu.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSideMenu.Width = 0;
                if (panelSideMenu.Width <= 5 )
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
                else
                {

                }

            }

        }
    }

}