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
    public partial class OriginalSubForm : Form
    {

        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=newData;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet dsx = new DataSet();
        SqlCommand cmd;


        public OriginalSubForm()
        {
            InitializeComponent();
        }

        private void OriginalSubForm_Load(object sender, EventArgs e)
        {
            firsttableload();

        }

        public void firsttableload()
        {
            //con.Open();

            //cmd = new SqlCommand(" SELECT الأسم,العدد,العدد_قبل_الإضافة,العدد_بعد_الإضافة,الصنف,تاريخ_الدخول,السيريال FROM TBL_ORG ", con);
            // cmd = new SqlCommand("SELECT تاريخ_الدخول, , العدد, السيريال,الصنف, الأسم FROM TBL_ORG", con);
           // cmd = new SqlCommand("SELECT تاريخ_الدخول, العدد_بعد_الإضافة, العدد_قبل_الإضافة, العدد, السيريال,الصنف, ID,الأسم FROM TBL_ORG", con);
            cmd = new SqlCommand("SELECT الأسم,الصنف,السيريال,العدد,العدد_قبل_الإضافة, العدد_بعد_الإضافة,تاريخ_الدخول FROM TBL_ORG", con);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView.DataSource = ds;
            dataGridView.DataMember = ds.Tables[0].ToString();

            con.Close();

        }



    }
}
