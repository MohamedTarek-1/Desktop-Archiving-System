using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication7.Small_Interfaces
{
    public partial class Passwordss : Form
    {

        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;

        public Passwordss()
        {
            InitializeComponent();
           // PasswordText.PasswordChar = '*';
        }

        public void readFromTable()
        {

            ////GRANTING ACCESS AFTER PASSWORD
            con.Close();

            cmd = new SqlCommand("SELECT * FROM Password_TBL WHERE Password =  '" + PasswordText.Text + "'", con);
            con.Open();

            cmd.ExecuteNonQuery();


            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                ///if Reads From Table 

                string Name = (string)dr["Password"].ToString();


                MessageBox.Show("Access Granted", "Access!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //this.Close();

                //OPEN FORM
                PasswordLink openform = new PasswordLink();
                openform.Show();


            }

            else
            {

                //IF THERE IS NO MATCH IN THE TABLE
                MessageBox.Show("Wrong Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            readFromTable();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RenewPassword openit = new RenewPassword();
            openit.Show();
        }


        private void Passwordss_Load(object sender, EventArgs e)
        {

        }

        private void Passwordss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}