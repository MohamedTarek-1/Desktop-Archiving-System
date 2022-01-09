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
    public partial class EditExist : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmdfind;
        DataTable dt2 = new DataTable();
        public EditExist()
        {
            InitializeComponent();
        }

        private void EditExist_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Now;

            secondtableload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            string query = "SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج,ID FROM TBL_AWAY WHERE السيريال LIKE  '%"
               + textBox1.Text + "%' AND الأسم like '%" + textBox2.Text + "%' AND الصنف like '%" + textBox3.Text + "%' AND القسم_المستلم like '%" + dept2.Text + "%' AND المستلم like '%" + receiver2.Text + "%'";
            SqlDataAdapter da2 = new SqlDataAdapter(query, con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }



        public void secondtableload()
        {

            cmd2 = new SqlCommand(" SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج,ID FROM TBL_AWAY ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds2);
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = ds2.Tables[0].ToString();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtSerial.Text = row.Cells[1].Value.ToString();
                txtType.Text = row.Cells[2].Value.ToString();
                txtDept.Text = row.Cells[5].Value.ToString();
                txtCustomer.Text = row.Cells[6].Value.ToString();
                custodytxt.Text = row.Cells[4].Value.ToString();
                Nametxt.Text = row.Cells[0].Value.ToString();
                textBox5.Text = row.Cells[8].Value.ToString();
                datetxt.Text = row.Cells[7].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();

            }
        }


        private void ExcutingButton_Click(object sender, EventArgs e)
        {


            con.Open();
           // string date = dateTimePicker1.Text;
            cmd = new SqlCommand(" UPDATE  TBL_AWAY set السيريال ='" +txtSerial.Text+
                "' , الأسم = '" + Nametxt.Text + 
                "' , الصنف = '" + txtType.Text +
                "' , العهدة = '" + custodytxt.Text +
                "' , القسم_المستلم = '" + txtDept.Text +
                "' , المستلم = '" + txtCustomer.Text +
                "' , العدد = '" + textBox6.Text +
                "' , تاريخ_الخروج = '" + datetxt.Text +
                "' Where ID = '" + textBox5.Text + "' ", con);
            cmd.ExecuteNonQuery();

            secondtableload();
            con.Close();
        }

        private void updating() { }

        private void button2_Click(object sender, EventArgs e)
        {

           DialogResult Result=  MessageBox.Show(" هل أنت متأكد من حذف هذا السجل ؟?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result ==DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand(" DELETE  FROM TBL_AWAY WHERE  ID ='" + textBox5.Text + "' ", con);
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
