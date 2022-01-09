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
    public partial class existingForm : Form
    {
        //SqlConnection con = new SqlConnection(@"Server=.\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        //SqlConnection con = new SqlConnection(@"Server=TYRIEL-PC\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlCommand cmd;
        SqlCommand cmd2;
        DataTable dt2 = new DataTable();
        DataGridView dataGridView2, dataGridView1;

        public existingForm()
        {
            InitializeComponent();
        }

        private void existingForm_Load(object sender, EventArgs e)
        {
            firsttableload();
        }

        public void firsttableload()
        {



            con.Open();

            cmd = new SqlCommand(" SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView111.DataSource = ds;
            dataGridView111.DataMember = ds.Tables[0].ToString();

            con.Close();

        }
        private void existsSrchButton_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD WHERE السيريال LIKE  '%"
              + serial1.Text + "%' AND الأسم like '%" + name1.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView111.DataSource = dt22;
        }

    }
}
