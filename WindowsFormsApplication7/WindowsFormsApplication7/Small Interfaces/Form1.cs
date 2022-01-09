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
    public partial class DeptBtn : Form
    {


        //SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        // SqlConnection con = new SqlConnection(@"Server=TYRIEL-PC\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        DataSet ds = new DataSet();
        السحب load = (السحب)Application.OpenForms["السحب"];
        public DeptBtn()
        {
            InitializeComponent();
        }

        private void DeptBtn_Load(object sender, EventArgs e)
        {
            loadingnormaltable();
            loadingcombobox();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {

                MessageBox.Show("الرجاء التأكد من مليءالخانة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {

                cmd2 = new SqlCommand("SELECT * FROM TBL_DEPT where Name = '" + textBox1.Text + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show("هذا القسم موجود بالفعل", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {

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
            }

        }



        private void Refresh()
        {


            con.Open();

            cmd = new SqlCommand(" SELECT Name,ID FROM TBL_DEPT ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            con.Close();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletevalues();
            Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void loadingcombobox()
        {



            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name,ID From TBL_DEPT";
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


        public void loadingnormaltable()
        {

            con.Open();

            cmd2 = new SqlCommand(" SELECT ID,Name FROM TBL_DEPT ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(ds2);
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = ds2.Tables[0].ToString();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            comboBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[0].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd3 = new SqlCommand("UPDATE  TBL_DEPT set Name = '" + textBox2.Text + "' Where ID = '" + textBox3.Text + "' ", con);
            cmd3.ExecuteNonQuery();
            con.Close();
            Refresh();
            loadingcombobox();
            textBox2.Text = " ";
            comboBox1.Text = " ";

            load.maincombobox();
        }


    }

}
