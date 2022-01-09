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
    public partial class PasswordLink : Form
    {

        //SqlConnection con = new SqlConnection(@"Server=REGOOO-PC\SQLEXPRESS;Database=DB_BARCODE;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmdfind;
        DataTable dt2 = new DataTable();

        public PasswordLink()
        {
            InitializeComponent();
        }

        private void ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditIn openit = new EditIn();
            openit.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditExist openit = new EditExist();
            openit.Show();
            this.Close();
        }

        private void PasswordLink_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
