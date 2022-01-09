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
    public partial class معلومات_مستردات : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        DataSet datasetcustody = new DataSet();
        SqlCommand cmd;


        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=newData;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        public معلومات_مستردات()
        {
            InitializeComponent();
        }

        private void معلومات_مستردات_Load(object sender, EventArgs e)
        {

            tableload();
        }





        //LOADING TABLE

        private void tableload()
        {

            //con.Open();

            cmd = new SqlCommand(" SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الإسترداد,ID FROM TBL_RETURNED ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الإسترداد,ID  FROM TBL_RETURNED WHERE السيريال LIKE  '%"
            + textBox1.Text + "%' AND الأسم like '%" + textBox2.Text + "%' AND الصنف like '%" + textBox3.Text + "%' AND القسم_المستلم like '%" + dept2.Text + "%' AND المستلم like '%" + receiver2.Text + "%'";
            SqlDataAdapter da2 = new SqlDataAdapter(query, con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            txtSerial.Text = row.Cells[1].Value.ToString();
            txtType.Text = row.Cells[2].Value.ToString();
            txtDept.Text = row.Cells[5].Value.ToString();
            txtCustomer.Text = row.Cells[6].Value.ToString();
            custodytxt.Text = row.Cells[4].Value.ToString();
            Nametxt.Text = row.Cells[0].Value.ToString();
            textBox5.Text = row.Cells[8].Value.ToString();
            textBox6.Text = row.Cells[3].Value.ToString();
            datetxt.Text = row.Cells[7].Value.ToString();

            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[7].Value);
           // dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
           // dateTimePicker1.Value = DateTime.ParseExact(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
           // "dd-MM-yyyy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);


        }

        private void ExcutingButton_Click(object sender, EventArgs e)
        {
            con.Open();
           // string date = dateTimePicker1.Text;
            cmd = new SqlCommand(" UPDATE  TBL_RETURNED set السيريال ='" + txtSerial.Text +
                "' , الأسم = '" + Nametxt.Text +
                "' , الصنف = '" + txtType.Text +
                "' , العهدة = '" + custodytxt.Text +
                "' , القسم_المستلم = '" + txtDept.Text +
                "' , المستلم = '" + txtCustomer.Text +
                "' , العدد = '" + textBox6.Text +
                "' , تاريخ_الإسترداد = '" + datetxt.Text +
                "' Where ID = '" + textBox5.Text + "' ", con);
            cmd.ExecuteNonQuery();

            tableload();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show(" Are you sure you want to Delete This Record?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand(" DELETE  FROM TBL_RETURNED WHERE  Id ='" + textBox5.Text + "' ", con);
                cmd.ExecuteNonQuery();

                tableload();

                con.Close();

            }
            else
            {

                Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnHolder s = new ReturnHolder();
            s.Show();
        }







      }
}
