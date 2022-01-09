using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class PrintButtons : Form
    {
        public PrintButtons()
        {
            InitializeComponent();
        }

        private void PrintButtons_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InMilitary militaryin = new InMilitary();
            militaryin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InOuter InOuter = new InOuter();
            InOuter.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            In allin = new In();
            allin.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Out outall = new Out();
            outall.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OutMilitary outmil = new OutMilitary();
            outmil.Show();
        }


        private void button4_Click_2(object sender, EventArgs e)
        {
            OuterOut outouter = new OuterOut();
            outouter.Show();

        }
    }
}
