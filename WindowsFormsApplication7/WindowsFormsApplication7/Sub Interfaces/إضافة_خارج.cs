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
    public partial class إضافة_خارج : Form
    {


        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet dsx = new DataSet();


        SqlCommand cmd;
        SqlCommand cmd2;

        SqlDataReader myReader3;
        String custody;


        public class myGlobalVariables
        {
            public static Int64 userinput;
            public static Int64 diffrence;
            public static Int64 oldTBLPRD;
            public static Int64 oldTBLPRD2;

        }




        public إضافة_خارج()
        {
            InitializeComponent();
        }

        private void إضافة_خارج_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dateTimePicker1.Value = DateTime.Now;

            datacombobox();
            maincombobox();
        }

        public void maincombobox()
        {

            combox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name From TBL_DEPT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                combox1.Items.Add(dr["Name"].ToString());

            };
            con.Close();

        }

        public void loadingserials()
        {
           

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_DEPT", con);
            da2.Fill(dt);



            combox1.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combox1.Items.Add(dt.Rows[i]["Name"]);   //DEPT

            }

        }


        public void datacombobox()
        {

            TypeBox.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Name From TBL_PRD2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                TypeBox.Items.Add(dr["Name"].ToString());

            };
            con.Close();
        }


        public void conandadd()
        {

            cmd = new SqlCommand(" INSERT INTO TBL_AWAY Values (@السيريال,@الصنف,@القسم_المستلم,@العدد,@المستلم,@تاريخ_الخروج,@العهدة,@الأسم)", con);
            // cmd2 = new SqlCommand("SELECT * FROM TBL_PRD ", con);
            // INSERT INTO TBL_PRD Values (@Name,@Serial,@Des,@Qty,@Custody,@Type,@Date,@Place,8@Pagen,9@Reciever)

            SqlParameter[] param = new SqlParameter[8];
            if ( (TypeBox.Text == "") || (txtQty.Text == "") || (Receiver.Text == "") || (combox1.Text == "")
                || (txtName.Text == "")
                )
            {
                MessageBox.Show("الرجاء إكمال المربعات الفارغة",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.
                    Information);
            }




            else
            {

                param[0] = new SqlParameter("@السيريال", SqlDbType.NChar, 50);
                param[0].Value = SerialBox.Text;



                param[1] = new SqlParameter("@الصنف", SqlDbType.VarChar);
                param[1].Value = TypeBox.Text;



                param[2] = new SqlParameter("@القسم_المستلم", SqlDbType.VarChar);
                param[2].Value = combox1.Text;




                param[3] = new SqlParameter("@العدد", SqlDbType.Int);
                param[3].Value = txtQty.Text;

                param[4] = new SqlParameter("@المستلم", SqlDbType.VarChar);
                param[4].Value = Receiver.Text;

                param[5] = new SqlParameter("@تاريخ_الخروج", SqlDbType.Date);


                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";

                DateTime dp1 = dateTimePicker1.Value;
                // Modify next line, set HH:MM to HH:mm
                String dpstring = dp1.ToString("dd/MM/yyyy hh:mm tt");

                param[5].Value = dpstring;
                
                con.Open();
                if (rdiobtnMilitary.Checked)
                {
                    custody = "عهدة قوات مسلحة";
                }
                else
                {
                    custody = "عهدة خارجية";
                }



                param[6] = new SqlParameter("@العهدة", SqlDbType.VarChar, 35);
                param[6].Value = custody;

                param[7] = new SqlParameter("@الأسم", SqlDbType.VarChar);
                param[7].Value = txtName.Text;






                //GETTING CURRENT TBL_PRD QTY VALUE/////////////////////////////////

                //  oldTBLPRD = old TBL_PRD value   serial 
                //  oldTBLPRD2 = old TBL_PRD value having in common serial and name


                cmd2 = new SqlCommand("SELECT العدد FROM TBL_AWAY WHERE السيريال  =  '" + SerialBox.Text + "' ", con);

                SqlDataReader myReader2 = cmd2.ExecuteReader();
                myGlobalVariables.oldTBLPRD = 0;
                if (myReader2.Read())
                {
                    myGlobalVariables.oldTBLPRD = myReader2.GetInt32(0);
                    myReader2.Close();

                }
                myReader2.Close();


                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                cmd2 = new SqlCommand("SELECT العدد FROM TBL_AWAY WHERE السيريال  =  '" + SerialBox.Text + "' AND الأسم = '" + txtName.Text + "' ", con);

                myReader3 = cmd2.ExecuteReader();
                myGlobalVariables.oldTBLPRD = 0;
                if (myReader3.Read())
                {
                    myGlobalVariables.oldTBLPRD2 = myReader3.GetInt32(0);
                    myReader3.Close();

                }
                myReader3.Close();






                //CHECKING IF SERIAL OR SERIAL AND NAME EXISTS///////////////////////////////////////////////////
                //i = serial exists
                //ix = serial and name exists



                cmd2 = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + SerialBox.Text + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;


                SqlCommand cmdx = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + SerialBox.Text + "' AND الأسم = '" + txtName.Text + "' ", con);
                SqlDataAdapter dax = new SqlDataAdapter(cmdx);

                dax.Fill(dsx);
                int ix = dsx.Tables[0].Rows.Count;





                myGlobalVariables.diffrence = myGlobalVariables.oldTBLPRD2 + myGlobalVariables.userinput;


                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم إضافة المنتج بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    /////////////CLEARING TEXTS
                    //   con.Close();
                    txtName.Clear();
                    txtQty.Clear();
                    SerialBox.Clear();
                    Receiver.Clear();
                    txtName.Clear();
                    combox1.SelectedIndex = -1;
                    TypeBox.SelectedIndex = -1;

                    //comboBox1.Items.Clear();
                    rdiobtnMilitary.Checked = false;
                    rdiobtnOuter.Checked = false;
                    con.Close();
                    //     }

                
            }
        }





        private void Refresh()
        {


            con.Open();

            cmd = new SqlCommand(" SELECT الأسم FROM TBL_PRD2 ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            foreach (DataRow dr in dt.Rows)
            {

                TypeBox.Items.Add(dr["الأسم"].ToString());

            };
            con.Close();


        }

        private void DeptBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form800 openingNEWDept = new form800();
            openingNEWDept.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form900 openform6 = new Form900();
            openform6.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)

        {
            
            conandadd();

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditExist openit = new EditExist();
            openit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
