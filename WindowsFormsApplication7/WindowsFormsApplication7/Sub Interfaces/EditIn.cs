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
    public partial class EditIn : Form
    {


        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=newData;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmdfind;
        DataTable dt2 = new DataTable();


        public EditIn()
        {
            InitializeComponent();
        }

        private void EditIn_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Now;

            secondtableload();

        }





        public void secondtableload()
        {

            cmd2 = new SqlCommand(" SELECT ID,الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds2);
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = ds2.Tables[0].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void existsSrchButton_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT ID,الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD WHERE السيريال LIKE  '%"
              + serial1.Text + "%' AND الأسم like '%" + name1.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView1.DataSource = dt22;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            IDtxt.Text = row.Cells[0].Value.ToString();
            Nametxt.Text = row.Cells[1].Value.ToString();
            txtSerial.Text = row.Cells[2].Value.ToString(); 
            txtQty.Text = row.Cells[3].Value.ToString();
            custodytxt.Text = row.Cells[4].Value.ToString(); 
            txtType.Text = row.Cells[5].Value.ToString();
            PagenTxt.Text = row.Cells[6].Value.ToString();
            datetxt.Text = row.Cells[7].Value.ToString();

        }

        private void ExcutingButton_Click(object sender, EventArgs e)
        {
            con.Open();
            // string date = dateTimePicker1.Text;
            cmd = new SqlCommand(" UPDATE  TBL_PRD set السيريال ='" + txtSerial.Text +
                "' , الأسم = '" + Nametxt.Text +
                "' , الصنف = '" + txtType.Text +
                "' , العهدة = '" + custodytxt.Text +
                "' , العدد = '" + txtQty.Text +
                "' , رقم_الصفحة = '" + PagenTxt.Text +
                "' , تاريخ_الدخول = '" + datetxt.Text +
                "' Where ID = '" + IDtxt.Text + "' ", con);

            cmd.ExecuteNonQuery();

            secondtableload();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show(" Are you sure you want to Delete This Record?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand(" DELETE  FROM TBL_PRD WHERE  ID ='" + IDtxt.Text + "' ", con);
                cmd.ExecuteNonQuery();

                secondtableload();

                con.Close();

            }
            else
            {

                Close();

            }
        }



    }
}
