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

namespace WindowsFormsApplication7.MainPages
{
    
    public partial class outSubForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlCommand cmd,cmd2;
        DataTable dt2;
        public outSubForm()
        {
            InitializeComponent();
        }

        private void outSubForm_Load(object sender, EventArgs e)
        {
            con.Open();

            cmd2 = new SqlCommand(" SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج FROM TBL_AWAY ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds2);
            dataGridView.DataSource = ds2;
            dataGridView.DataMember = ds2.Tables[0].ToString();
            con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {

            string query = "SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج FROM TBL_AWAY WHERE السيريال LIKE  '%"
               + textBox1.Text + "%' AND الأسم like '%" + textBox2.Text + "%' AND الصنف like '%" + textBox3.Text 
               + "%' AND القسم_المستلم like '%" + dept2.Text + "%' AND المستلم like '%" 
               + receiver2.Text + "%'";
            SqlDataAdapter da2 = new SqlDataAdapter(query, con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView.DataSource = dt2;

        }
    }
}
