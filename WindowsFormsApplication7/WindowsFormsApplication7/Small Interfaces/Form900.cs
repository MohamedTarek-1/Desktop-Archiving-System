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
    public partial class Form900 : Form
    {

       // إضافة_خارج load = (إضافة_خارج)Application.OpenForms["إضافة_خارج"];

        //SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        الإضافة obj = (الإضافة)Application.OpenForms["الإضافة"];

        public Form900()
        {
            InitializeComponent();
        }

        private void Form900_Load(object sender, EventArgs e)
        {

            loadingnormaltable();
            loadingcombobox();
        }


        #region MethodsRelatedToThisOnly
        private void Refresh()
        {


            con.Open();

            cmd = new SqlCommand(" SELECT ID,Name FROM TBL_PRD2 ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            con.Close();


        }

        public void loadingcombobox()
        {



            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select ID,Name From TBL_PRD2";
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

            cmd2 = new SqlCommand(" SELECT ID,Name FROM TBL_PRD2 ", con);
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
            cmd3 = new SqlCommand("DELETE FROM TBL_PRD2 WHERE Name = '" + comboBox1.Text + "' ;", con);
            cmd3.ExecuteNonQuery();
            con.Close();

            comboBox1.Text = " ";

            Refresh();

            loadingcombobox();
            obj.fillingComboBox();

            /* try
             {
                 load.fillingComboBox();

             }
             catch (Exception ex) { }*/
            textBox1.Clear();
            textBox2.Text = " ";
            textBox3.Text = " ";

            // load2.fillingComboBox();
            //   load2.maincombobox();
            //
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            comboBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[0].Value.ToString();

        }

        #endregion

        #region ClickListeners
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {

                MessageBox.Show("الرجاء التأكد من مليءالخانة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

                cmd2 = new SqlCommand(" INSERT INTO TBL_PRD2 Values (@Name)", con);
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            param[0].Value = textBox1.Text;

            con.Open();
            cmd2.Parameters.AddRange(param);
            cmd2.ExecuteNonQuery();
            con.Close();
            Refresh();
            loadingcombobox();
            obj.fillingComboBox();
            /*
            try
            {
                load.fillingComboBox();

            }
            catch (Exception ex) { }*/
            textBox1.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletevalues();
            Refresh();
            loadingcombobox();
            obj.fillingComboBox();

            /*  try
              {
                  load.fillingComboBox();

              }
              catch (Exception ex) { }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd3 = new SqlCommand("UPDATE  TBL_PRD2 set Name = '" + textBox2.Text + "' Where ID = '" + textBox3.Text + "' ", con);
            cmd3.ExecuteNonQuery();
            con.Close();

            Refresh();
            loadingcombobox();
            obj.fillingComboBox();
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";

            /*try
            {
                load.fillingComboBox();

            }
            catch (Exception ex) { }*/
            textBox1.Clear();

        }
        #endregion
    }
}
