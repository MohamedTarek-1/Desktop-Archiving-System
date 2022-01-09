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
    public partial class FirstTimeNewPassword : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlCommand cmd;

        public FirstTimeNewPassword()
        {
            InitializeComponent();
            NewPw.isPassword = true;
            ConfirmPw.isPassword = true;

        }

        private void FirstTimeNewPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((NewPw.Text == "") || (ConfirmPw.Text == ""))
            {
                MessageBox.Show("الرجاء إكمال المربعات الفارغة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (NewPw.Text == ConfirmPw.Text)
            {
                SetNewPw();
                MessageBox.Show("تم تثبيت كلمة السر", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PasswordLink openform = new PasswordLink();
                openform.Show();


            }



        }

        public void SetNewPw()
        {
      
                cmd = new SqlCommand(" INSERT INTO Password_TBL Values (@Password)", con);

                con.Open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@Password", SqlDbType.NVarChar);

                try
                {
                    param[0].Value = NewPw.Text;
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception exception)
                {
                    MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            this.Close();
        }

    }
}