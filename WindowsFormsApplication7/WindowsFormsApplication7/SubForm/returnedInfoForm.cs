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
    public partial class returnedInfoForm : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        DataSet datasetcustody = new DataSet();
        SqlCommand cmd;


        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=newData;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        public returnedInfoForm()
        {
            InitializeComponent();
        }

        private void returnedInfoForm_Load(object sender, EventArgs e)
        {
            tableload();
        }
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


    }
}
