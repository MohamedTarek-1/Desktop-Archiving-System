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
    public partial class form800 : Form
    {



        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");


        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        إضافة_خارج load = (إضافة_خارج)Application.OpenForms["إضافة_خارج"];



        public form800()
        {
            InitializeComponent();
        }

        private void form800_Load(object sender, EventArgs e)
        {


            loadingnormaltable();
            loadingcombobox();

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }



        public void loadingnormaltable()
        {

            con.Open();

            cmd2 = new SqlCommand(" SELECT Name FROM TBL_DEPT ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(ds2);
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = ds2.Tables[0].ToString();

            con.Close();
        }


        public void loadingcombobox()
        {



            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name From TBL_DEPT";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {

                comboBox1.Items.Add(dr["Name"].ToString());

            };
            con.Close();

        }


        public void deletevalues()
        {

            con.Open();
            cmd3 = new SqlCommand("DELETE FROM TBL_DEPT WHERE Name = '" + comboBox1.Text + "' ;", con);
            cmd3.ExecuteNonQuery();
            con.Close();
            Refresh();
            loadingcombobox();
            comboBox1.Text = " ";
            load.maincombobox();


        }

        private void Refresh()
        {


            con.Open();

            cmd = new SqlCommand(" SELECT Name FROM TBL_DEPT ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            con.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                MessageBox.Show("الرجاء التأكد من مليءالخانة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

                cmd2 = new SqlCommand(" INSERT INTO TBL_DEPT Values (@Name)", con);
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            param[0].Value = textBox1.Text;

            con.Open();
            cmd2.Parameters.AddRange(param);
            cmd2.ExecuteNonQuery();
            con.Close();

            Refresh();
            loadingcombobox();
            load.maincombobox();


            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletevalues();
            Refresh();
        }


    }


}
