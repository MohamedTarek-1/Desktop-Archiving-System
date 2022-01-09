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
    public partial class Form2 : Form


    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            الإضافة aa = new الإضافة();
            aa.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4open = new Form4();
            form4open.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            الإستردادات form3 = new الإستردادات();
            form3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            السحب form5open = new السحب();
            form5open.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
