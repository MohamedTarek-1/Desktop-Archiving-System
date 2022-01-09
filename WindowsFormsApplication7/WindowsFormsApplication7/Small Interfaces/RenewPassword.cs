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

namespace WindowsFormsApplication7.Small_Interfaces
{

    public partial class RenewPassword : Form
    {
        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;


        public RenewPassword()
        {
            InitializeComponent();
            NewPw.isPassword = true;
            oldPw.isPassword = true; 
            ConfirmPw.isPassword = true;

        }

        private void RenewPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NewPw.Text ==ConfirmPw.Text)
            {

                readFromTable();
            }
            else
            {
                MessageBox.Show("تأكد من تطابق كلمة السر الجديدة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void readFromTable()
        {
            con.Close();

            cmd = new SqlCommand("SELECT * FROM Password_TBL WHERE Password =  '" + oldPw.Text + "'", con);
            con.Open();

            cmd.ExecuteNonQuery();


            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                ///if Reads From Table 

                string Name = (string)dr["Password"].ToString();

                cmd = new SqlCommand(" UPDATE   Password_TBL set Password ='" + NewPw.Text + "' Where Password = '" + oldPw.Text + "' ", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("تم تغيير كلمة السر", "تم بنجاح!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //OPEN FORM

            }

            else
            {

                //IF THERE IS NO MATCH IN THE TABLE
                MessageBox.Show("كلمة السر ليست صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }
    }
}
