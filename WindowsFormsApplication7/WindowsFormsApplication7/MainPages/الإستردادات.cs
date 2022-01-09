﻿using System;
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
    public partial class الإستردادات : Form
    {


        // SqlConnection con = new SqlConnection(@"Server=IT-PC\SQLEXPRESS;Database=DB_BARCODE;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataSet ds = new DataSet();
        DataSet datasetcustody = new DataSet();
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlConnection con1;
        public الإستردادات()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel2_Paint(object sender, EventArgs e)
        {

        }
        public class myGlobalVariables
        {
            public static Int32 variable;
            public static Int64 diffrence;
            public static Int64 tableV;
            public static Int64 Input;
            public static Int64 pageninput;
            public static Int64 oldTBLvalue;
            public static Int64 userinputnumber;

        }
        private void tableload()
        {



            con.Open();
            cmd = new SqlCommand(" SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج,ID FROM TBL_AWAY ", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();

            con.Close();



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Nametxt.Text = row.Cells[0].Value.ToString();
                txtSerial.Text = row.Cells[1].Value.ToString();
                txtType.Text = row.Cells[2].Value.ToString();
                userinputqty.Text = row.Cells[3].Value.ToString();                
                custodytxt.Text = row.Cells[4].Value.ToString();
                txtDept.Text = row.Cells[5].Value.ToString();
                txtCustomer.Text = row.Cells[6].Value.ToString();
                IDtxt.Text = row.Cells[8].Value.ToString().Trim();
                //...
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.FormatCustom = "dd/MM/yyyy hh:mm tt";
            dateTimePicker1.Value = DateTime.Now;

            try
            {
                tableload();

            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجي التأكد من الإتصال بقاعدة البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        private void onKeyPressOnlyNumeric(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void ExcutingButton_Click(object sender, EventArgs e)
        {
            if ((txtSerial.Text == "") || (Nametxt.Text == "") || (pagen.Text == ""))

            {
                MessageBox.Show("الرجاء إكمال المربعات الفارغة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // con.Open();
                //  cmd.Parameters.AddRange(param);
                // cmd.ExecuteNonQuery();
            }
        
            else
            {
                Returning();
                tableload();

            }

        }

        public void Returning()
        {
                    myGlobalVariables.Input = Convert.ToInt64(userinputqty.Text);
                    cmd = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" + txtDept.Text
                        + "'AND  المستلم = '" + txtCustomer.Text + "' AND  الصنف = '" + txtType.Text + "'  AND  العدد = '" + userinputqty.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;

                    cmd2 = new SqlCommand("SELECT العدد FROM TBL_AWAY WHERE السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" 
                        + txtDept.Text + "'AND  المستلم = '" + txtCustomer.Text + "' AND  الصنف = '" + txtType.Text + "'", con);

                    con.Open();
                    SqlDataReader myReader = cmd2.ExecuteReader();
                    // myGlobalVariables.tableV = 0;
                    if (myReader.Read())
                    {
                        myGlobalVariables.tableV = myReader.GetInt32(0);
                        // MessageBox.Show(myGlobalVariables.Input + "and " + myGlobalVariables.tableV, "lol", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        myReader.Close();

                    }
                    con.Close();

                    Operations();


                // String tableVstring = myGlobalVariables.tableV.ToString();
                // MessageBox.Show(oldawaystring,"LOL",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);
            }
       
        public void Operations()

        {
            //   MessageBox.Show(myGlobalVariables.Input + "and " + myGlobalVariables.tableV, "lol", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (myGlobalVariables.Input == myGlobalVariables.tableV)
            {

                if (checkifexist() == true)
                {
                    //     MessageBox.Show("UPDATED  TBL_PRD AND DELETED FROM AWAY ROW", "lol", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    //  newrowTBL_PRD();  \*******************************************************************
                    //con.Open();

                    updatingTBLPRDvalue();
                    newrowTBL_Returned();
                    con.Open();

                    cmd = new SqlCommand(" DELETE FROM TBL_AWAY Where السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" + txtDept.Text + "'AND  المستلم = '" + txtCustomer.Text + "' AND  الصنف = '" + txtType.Text + "'  AND  العدد = '" + myGlobalVariables.Input + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (checkifexist() == false)
                {
                    con.Open();

                    // MessageBox.Show("ADDED NEW ROW TO TBL_PRD AND DELETED FROM TBL AWAY", "lol", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    newrowTBL_PRD();
                    newrowTBL_Returned();
                    cmd = new SqlCommand(" DELETE FROM TBL_AWAY Where السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" + txtDept.Text + "'AND  المستلم = '" + txtCustomer.Text + "' AND  الصنف = '" + txtType.Text + "'  AND  العدد = '" + myGlobalVariables.Input + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }





                // con.Close();





            }

           else if (myGlobalVariables.Input < myGlobalVariables.tableV)

            {



                if (checkifexist() == true)
                {
                    updatingTBLPRDvalue();
                    updatingTBLAWAYvalue();

                }
                if (checkifexist() == false)
                {
                    MessageBox.Show("تأكد أن البيانات المدخلة موجودة في جدول الخارج", "lol", MessageBoxButtons.OK, MessageBoxIcon.Question);


                }

                con.Close();
            }

           else if (myGlobalVariables.Input > myGlobalVariables.tableV)
            {
                MessageBox.Show("العدد المطلوب استردادة أكبر من الخارج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            else if (myGlobalVariables.tableV == 0)
            {
                MessageBox.Show(" لم يعد في جدول الخارج", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }


        }
        public void newrowTBL_PRD()

        {
            // try
            // {            
            cmd = new SqlCommand("  INSERT INTO TBL_PRD Values (@الأسم,@السيريال,@العدد,@العهدة,@الصنف,@رقم_الصفحة,@تاريخ_الدخول)", con);
            // cmd = new SqlCommand(" INSERT INTO TBL_PRD Values (@Name,@Serial,@Number,@Custody,@Type,@Pagen)", con);



            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@الأسم", SqlDbType.VarChar);
            param[0].Value = Nametxt.Text;


            param[1] = new SqlParameter("@السيريال", SqlDbType.NChar, 50);
            param[1].Value = txtSerial.Text;


            param[2] = new SqlParameter("@العدد", SqlDbType.Int);
            param[2].Value = userinputqty.Text;
            myGlobalVariables.userinputnumber = Int64.Parse(userinputqty.Text);


            param[3] = new SqlParameter("@العهدة", SqlDbType.VarChar, 35);
            param[3].Value = custodytxt.Text;

            param[4] = new SqlParameter("@الصنف", SqlDbType.VarChar, 35);
            param[4].Value = txtType.Text;

            param[5] = new SqlParameter("@رقم_الصفحة", SqlDbType.NChar, 10);
            myGlobalVariables.pageninput = Int64.Parse(pagen.Text);
            param[5].Value = myGlobalVariables.pageninput;

            param[6] = new SqlParameter("@تاريخ_الدخول", SqlDbType.Date);
            param[6].Value = dateTimePicker1.Value.ToString();

            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("تم استرداد المنتج بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            /*

            catch (Exception ex)
            {
                MessageBox.Show("هنالك خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
            */
        }
        public void newrowTBL_Returned()
        {

            //con.Open();
            // cmd = new SqlCommand("  INSERT INTO TBL_RETURNED Values (@الأسم,@السيريال,@العدد,@العهدة,@الصنف,@رقم_الصفحة)", con);
            cmd = new SqlCommand(" INSERT INTO TBL_RETURNED Values (@الأسم,@السيريال,@العدد,@العهدة,@الصنف,@رقم_الصفحة,@تاريخ_الإسترداد,@القسم_المستلم,@المستلم)", con);
            //                 cmd = new SqlCommand(" INSERT INTO TBL_RETURNED Values (@الأسم,@السيريال,@العدد,@العهدة,@الصنف,@رقم_الصفحة,@تاريخ_الإسترداد,@القسم_المستلم,@المستلم)", con);


            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@الأسم", SqlDbType.VarChar);
            param[0].Value = Nametxt.Text;


            param[1] = new SqlParameter("@السيريال", SqlDbType.NChar, 150);
            param[1].Value = txtSerial.Text;


            param[2] = new SqlParameter("@العدد", SqlDbType.Int);
            param[2].Value = userinputqty.Text;
            myGlobalVariables.userinputnumber = Int64.Parse(userinputqty.Text);


            param[3] = new SqlParameter("@العهدة", SqlDbType.VarChar, 50);
            param[3].Value = custodytxt.Text;

            param[4] = new SqlParameter("@الصنف", SqlDbType.VarChar, 50);
            param[4].Value = txtType.Text;

            param[5] = new SqlParameter("@رقم_الصفحة", SqlDbType.NChar, 10);
            myGlobalVariables.pageninput = Int64.Parse(pagen.Text);
            param[5].Value = myGlobalVariables.pageninput;




            param[6] = new SqlParameter("@القسم_المستلم", SqlDbType.VarChar);
            param[6].Value = txtDept.Text;

            param[7] = new SqlParameter("@المستلم", SqlDbType.VarChar);
            param[7].Value = txtCustomer.Text;

            param[8] = new SqlParameter("@تاريخ_الإسترداد", SqlDbType.VarChar, 50);
            param[8].Value = dateTimePicker1.Value;


            cmd.Parameters.AddRange(param);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم استرداد المنتج بنجاح", "استرداد!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            tableload();
            /* 
          }

              catch (Exception ex)
              {
                  MessageBox.Show("هنالك خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }

              */
        }

        public bool checkifexist()

        {


            SqlCommand cmdcust = new SqlCommand("SELECT * FROM TBL_PRD where السيريال = '"
                + txtSerial.Text + "' AND الصنف = '" + txtType.Text + "' ", con);
            SqlDataAdapter dacust = new SqlDataAdapter(cmdcust);

            dacust.Fill(datasetcustody);
            int typeandserial = datasetcustody.Tables[0].Rows.Count;

            if (typeandserial > 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        public void updatingTBLPRDvalue()
        {



            //GETTING CURRENT AWAY_TBL QTY VALUE/////////////////////////////////
            
            cmd2 = new SqlCommand("SELECT العدد FROM TBL_PRD WHERE السيريال  =  '" 
                + txtSerial.Text + "' AND العهدة = '" + custodytxt.Text + "' ", con);
            con.Open();

            cmd2.ExecuteNonQuery();
            SqlDataReader myReader2 = cmd2.ExecuteReader();
            myGlobalVariables.oldTBLvalue = 0;
             
            if (myReader2.Read())
            {
                myGlobalVariables.oldTBLvalue = myReader2.GetInt32(0);
                myReader2.Close();

            }
            myReader2.Close();

            Int64 oldbValAndUserinput = myGlobalVariables.oldTBLvalue + myGlobalVariables.Input;
            // MessageBox.Show("should be updated", "LOL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            cmd = new SqlCommand(" UPDATE  TBL_PRD set العدد ='" + oldbValAndUserinput + "' Where السيريال = '"
                + txtSerial.Text + "' AND العهدة = '" + custodytxt.Text + "' ", con);

            cmd.ExecuteNonQuery();

            //    MessageBox.Show("تم استرداد المنتج بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }


        public void updatingTBLAWAYvalue()

        {
            //GETTING CURRENT AWAY_TBL QTY VALUE/////////////////////////////////
            cmd2 = new SqlCommand("SELECT العدد FROM TBL_AWAY WHERE السيريال  =  '" 
                + txtSerial.Text + "' AND الصنف = '" + txtType.Text + "' ", con);
            SqlDataReader myReader2;
                myReader2 = cmd2.ExecuteReader();
            myGlobalVariables.oldTBLvalue = 0;
            if (myReader2.Read())
            {
                myGlobalVariables.oldTBLvalue = myReader2.GetInt32(0);
                myReader2.Close();

            }
            con.Close();


            Int64 oldbValAndUserinput = myGlobalVariables.oldTBLvalue - myGlobalVariables.Input;

            // MessageBox.Show("should be updated", "LOL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
            con.Open();
            cmd = new SqlCommand(" UPDATE  TBL_AWAY set العدد ='" + oldbValAndUserinput 
                + "' Where السيريال = '" + txtSerial.Text + "' AND العهدة = '" + custodytxt.Text + "' ", con);
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void userinputqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT الأسم,السيريال,الصنف,العدد,العهدة,القسم_المستلم,المستلم,تاريخ_الخروج FROM TBL_AWAY WHERE السيريال LIKE  '%"
              + textBox1.Text + "%' AND الأسم like '%" + textBox2.Text + "%' AND الصنف like '%" + textBox3.Text + "%' AND القسم_المستلم like '%" + dept2.Text + "%' AND المستلم like '%" + receiver2.Text + "%'";
            SqlDataAdapter da2 = new SqlDataAdapter(query, con);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            معلومات_مستردات openform2 = new معلومات_مستردات();
            openform2.Show();
            this.Close();
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_AWAY WHERE السيريال =  '" + txtSerial.Text + "'", con);

            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();




            while (dr.Read())
            {
                string Type = (string)dr["الصنف"].ToString();
                txtType.Text = Type;

                string Name = (string)dr["الأسم"].ToString();
                Nametxt.Text = Name;

                string CustodyVariable = (string)dr["العهدة"].ToString();
                custodytxt.Text = CustodyVariable;

                //  int page = (string)dr["رقم_الصفحة"].ToString();
                //  pagen.Text = page;

                string existingnumber = (string)dr["العدد"].ToString();
                userinputqty.Text = existingnumber;

                string Dept = (string)dr["القسم_المستلم"].ToString();
                txtDept.Text = Dept;

                string Customer = (string)dr["المستلم"].ToString();
                txtCustomer.Text = Customer;

            }


            dr.Close();
            con.Close();
        }
    }
}
