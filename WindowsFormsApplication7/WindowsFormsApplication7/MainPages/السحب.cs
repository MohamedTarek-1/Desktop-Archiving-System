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
    public partial class السحب : Form

    {
        //SqlConnection con = new SqlConnection(@"Server=TYRIEL-PC\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtx = new DataTable();
        DataSet ds = new DataSet();
        DataSet dsx = new DataSet();
        DataSet datasetcust = new DataSet();
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd7;

        bool epiphony;

        SqlDataReader Sdr;
        public static int userinput;
        //ss
        public السحب()
        {
            InitializeComponent();
/*
            // StartPosition was set to FormStartPosition.Manual in the properties window.
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width / 2 ? screen.Width : (screen.Width + Width)/2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height)/2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Top = (Screen.PrimaryScreen.WorkingArea.Top + Screen.PrimaryScreen.WorkingArea.Height) / 4;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Left + Screen.PrimaryScreen.WorkingArea.Width) / 4;

            this.Size = new Size(w, h);
           // this.WindowState = FormWindowState.Maximized;
           */
        }


        public class myGlobalVariables
        {
            public static Int32 variable;
            public static Int64 diffrence;
            public static Int64 oldAway;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        { 
            //this.Location = new Point(0, 0);
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;



            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.FormatCustom = "dd/MM/yyyy hh:mm tt";
            dateTimePicker1.Value = DateTime.Now;

            secondtableload();
            loadingserials();
          //  loadingType();
        }



        public void secondtableload()
        {

            cmd2 = new SqlCommand(" SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD ", con);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(ds2);
            dataGridView.DataSource = ds2;
            dataGridView.DataMember = ds2.Tables[0].ToString();
//,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول,الكمية_عند_الدخولسيشسي
        }


        private void button1_Click(object sender, EventArgs e)


        {
            Pullling();
             operation();



        }

        private void existsSrchButton_Click_1(object sender, EventArgs e)
        {
            string query2 = "SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD WHERE السيريال LIKE  '%"
             + serial1.Text + "%' AND الأسم like '%" + textBox3.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView.DataSource = dt22;

        }


        public void maincombobox() {

            DeptBox.Items.Clear();
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

                DeptBox.Items.Add(dr["Name"].ToString());

            };
            con.Close();

        }



        public void loadingserials()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PRD",con);
            da.Fill(dt);


            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_DEPT", con);
            da2.Fill(dt2);
            
            


            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DeptBox.Items.Add(dt2.Rows[i]["Name"]);   //DEPT

            }
            
        }




        private void SerialText_TextChanged(object sender, EventArgs e)
        {
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_PRD WHERE السيريال =  '" + txtSerial.Text + "'", con);

            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();



            
                while(dr.Read()){
                string Type = (string)dr["الصنف"].ToString();
                TypeText.Text = Type;

                string Name = (string)dr["الأسم"].ToString();
                NameText.Text = Name;

                string CustodyVariable = (string)dr["العهدة"].ToString();
                custody.Text = CustodyVariable;

                string page = (string)dr["رقم_الصفحة"].ToString();
                pagenumber.Text = page;

                string existingnumber = (string)dr["العدد"].ToString();
                CurrentNumber.Text = existingnumber;
            }
            

            dr.Close();
            con.Close();
        }


        /// DEPTBOX
       
     /*   public void loadingType()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBL_PRD", con);
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                TypeBox.Items.Add(dt.Rows[i]["Type"]);
            }
        }
        */




        public void Pullling() 
        {

                cmd7 = new SqlCommand(" INSERT INTO TBL_AWAY Values (@السيريال,@الصنف,@القسم_المستلم,@العدد,@المستلم,@تاريخ_الخروج,@العهدة,@الأسم)", con);             //JUST SAVING THE INSERT COMMAND INTO A VALUE
                //INSERT INTO TBL_PRD Values (@Name,@Serial,@Des,@Qty,@Custody,@Type,@Date,@Place,8@Pagen,9@Reciever)
                SqlParameter[] param = new SqlParameter[8];

                if ((txtSerial.Text == "") || (TypeText.Text == "") || (DeptBox.Text == "") || (DeptBox.Text == "") || (DeptBox.Text == ""))
                    
                {
                    MessageBox.Show("الرجاء إكمال المربعات الفارغة",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.
                        Information);
                }



                
                else{

                    param[0] = new SqlParameter("@السيريال", SqlDbType.NVarChar);
                    param[0].Value = txtSerial.Text;



                    param[1] = new SqlParameter("@الصنف", SqlDbType.VarChar);
                    param[1].Value = TypeText.Text;



                    param[2] = new SqlParameter("@القسم_المستلم", SqlDbType.VarChar);
                    param[2].Value = DeptBox.Text;




                    param[3] = new SqlParameter("@العدد", SqlDbType.Int);
                    try
                    {
                        param[3].Value = textBox2.Text;
                        userinput = Int32.Parse(textBox2.Text);
                    }
                    catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    param[4] = new SqlParameter("@المستلم", SqlDbType.VarChar);
                    param[4].Value = textBox1.Text;


                    param[5] = new SqlParameter("@تاريخ_الخروج", SqlDbType.VarChar,50);

                    //DateTimePicker dateTimePicker1 = new DateTimePicker();

                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    dateTimePicker1.FormatCustom = "dd/MM/yyyy hh:mm tt";

                    DateTime dp1 = dateTimePicker1.Value;
                    // Modify next line, set HH:MM to HH:mm
                    String dpstring = dp1.ToString("dd/MM/yyyy hh:mm tt");

                    param[5].Value = dpstring;


                   param[6] = new SqlParameter("@العهدة", SqlDbType.VarChar, 35);
                   param[6].Value = custody.Text;

                   param[7] = new SqlParameter("@الأسم", SqlDbType.VarChar);
                   param[7].Value = NameText.Text;


                   
                   //con.Open();



                   //GETTING CURRENT AWAY_TBL QTY VALUE/////////////////////////////////
                   cmd2 = new SqlCommand("SELECT العدد FROM TBL_AWAY WHERE السيريال  =  '" + txtSerial.Text + "'", con);
                con.Open();
                   SqlDataReader myReader2 = cmd2.ExecuteReader();
                   myGlobalVariables.oldAway = 0;

                   if (myReader2.Read())
                   {
                       myGlobalVariables.oldAway = myReader2.GetInt32(0);
                       myReader2.Close();

                   }
                   myReader2.Close();
                con.Close();
                   String oldawaystring = myGlobalVariables.oldAway.ToString();
                // MessageBox.Show(oldawaystring,"LOL",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Question);



                con.Open();
                cmd2 = new SqlCommand("SELECT العدد FROM TBL_PRD WHERE السيريال  =  '" + txtSerial.Text + "'", con);
                   SqlDataReader myReader = cmd2.ExecuteReader();
                   Int32 variable = 0;
                   if (myReader.Read())
                   {
                       variable = myReader.GetInt32(0);
                   }
                   myReader.Close();
                con.Close();

                   if (variable < userinput)
                   {
                       MessageBox.Show("العدد المطلوب سحبة أكبر من الموجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   }

                   else if (userinput < 0) {

                       MessageBox.Show("لا يمكنك سحب كمية بالسالب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   }
                   else if (userinput == 0)
                   {

                       MessageBox.Show("لم يتم سحب كمية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   }


                   else
                   {

                       ///////////////////////////////////////////////////////////////////////////
                       ///////////IF CURFRENT TBL_PRD is MORE THAN USER INPUT/////////

                       //////MATH//////


                       myGlobalVariables.diffrence = variable - userinput;
                       String newdiff = myGlobalVariables.diffrence.ToString();

                       /// IF There is a diffrence 
                       if (myGlobalVariables.diffrence != 0)
                       {
                           /*  cmd.Parameters.AddRange(param);
                             cmd.ExecuteNonQuery();
                            */
                           if (myGlobalVariables.diffrence < 0)
                           {

                               MessageBox.Show(" تم استهلاك الكمية الموجودة من هذا الصنف", "خطأ");

                               //cmd = new SqlCommand(" DELETE FROM TBL_PRD Where السيريال= '" + SerialText.Text + " ' AND الصنف= '" + TypeText.Text + "'", con);
                               //  cmd.ExecuteNonQuery();
                           }
                           else
                           {
                            
                               cmd = new SqlCommand(" UPDATE   TBL_PRD set العدد ='" + myGlobalVariables.diffrence + "' Where السيريال = '" + txtSerial.Text + "' ", con);
                               cmd.ExecuteNonQuery();
                           }

                       }


                           // IF THERE IS NO Numbers in the table
                       else if (myGlobalVariables.diffrence == 0)
                       {

                           MessageBox.Show("تم سحب كل العدد الموجود من هذا الصنف", "تحذير",MessageBoxButtons.OK, MessageBoxIcon.Information);

                           cmd = new SqlCommand(" UPDATE   TBL_PRD set العدد ='" + myGlobalVariables.diffrence + "' Where السيريال = '" + txtSerial.Text + "'  AND الصنف= '" + TypeText.Text + "' ", con);
                           //cmd = new SqlCommand(" DELETE FROM TBL_PRD Where السيريال= '" + SerialText.Text + " ' AND الصنف= '" + TypeText.Text + "'", con);
                           cmd.ExecuteNonQuery();
                       }







                       MessageBox.Show("تم السحب  بنجاح", "السحب", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       ///CLEARING TEXTS
                      // TypeText.Clear();
                      // custody.Text = "";
                     //  pagenumber.Clear();
                      // NameText.Clear();
                       DeptBox.Text = "";
                        textBox2.Text = "";
                      textBox1.Text = "";
                       txtSerial.Text = "";
                       con.Close();






                       ////////////////////////if SERIAL or DEPT ALREADY EXISTS/////////////////

                       cmd = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + txtSerial.Text + "' ", con);
                       SqlDataAdapter da = new SqlDataAdapter(cmd);
                       da.Fill(ds);
                       int i = ds.Tables[0].Rows.Count;

                       SqlCommand cmdx = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" + DeptBox.Text + "' ", con);
                       SqlDataAdapter dax = new SqlDataAdapter(cmdx);

                       dax.Fill(dsx);
                       int ix = dsx.Tables[0].Rows.Count;


                       SqlCommand cmdcust = new SqlCommand("SELECT * FROM TBL_AWAY where السيريال = '" + txtSerial.Text + "' AND القسم_المستلم = '" + DeptBox.Text + "'AND  المستلم = '" + textBox1.Text + "' ", con);
                       SqlDataAdapter dacust = new SqlDataAdapter(cmdcust);

                       dacust.Fill(datasetcust);
                       int cust = datasetcust.Tables[0].Rows.Count;




                       if (i > 0)               ////////////////////////if SERIAL  ALREADY EXISTS/////////////////
                       {
                           //  MessageBox.Show("serial exists ", "LOL", MessageBoxButtons.OK, MessageBoxIcon.Information);


                           if (ix > 0)       ////////////////////////if القسم ALREADY EXISTS  ()/////////////////
                           {
                               //    MessageBox.Show("dept exists ", "LOL", MessageBoxButtons.OK, MessageBoxIcon.Information);




                               if (cust >= 1)////////////////////////if المستلم ALREADY EXISTS  ()/////////////////
                               {
                                   //    MessageBox.Show("المستلم exists ", "LOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   /////Adding 
                                   Int64 oldbValAndUserinput = myGlobalVariables.oldAway + userinput;
                                   //  MessageBox.Show("should be updated", "LOL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                                   cmd = new SqlCommand(" UPDATE  TBL_AWAY set العدد ='" + oldbValAndUserinput + "' Where السيريال = '" + txtSerial.Text + "' AND المستلم = '" + textBox1.Text + "' ", con);
                                   cmd.ExecuteNonQuery();
                                   epiphony = true;
                                   myReader2.Close();
                               }

                               else
                               {
                                   con.Open();
                                   cmd7.Parameters.AddRange(param);
                                   cmd7.ExecuteNonQuery();
                                   con.Close();
                               }


                           }
                           else
                           {
                               //adding new row
                               con.Open();
                               //   MessageBox.Show("dept does not exist new row added ", "LOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               cmd7.Parameters.AddRange(param);
                               cmd7.ExecuteNonQuery();
                               //  epiphony = true;
                               con.Close();
                           }


                       }
                       else
                       {
                           con.Open();
                           //     MessageBox.Show("new serial added", "LOL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);
                           cmd7.Parameters.AddRange(param);
                           cmd7.ExecuteNonQuery();
                           myReader2.Close();
                           con.Close();
                       }


                   }

                 /*  if (epiphony == false)
                   {
                      
                   };*/
                    
                    /////////GETTING CURRENT NUMBER IN TBL_PRD AND COMPARING WITH USER INPUT//////////////////////////////////
                     //string userinput = textBox2.Text.;
                }
             
               // txtName.Clear();
               // txtQty.Clear();
                //txtSerial.Clear();

                


        
         
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void operation() 
        
        {

            //cmd = new SqlCommand("SELECT NUMBER FROM TBL_PRD WHERE Serial  =  '" + SerialBox.Text + "'", con);
           // SqlDataAdapter da = new SqlDataAdapter("SELECT NUMBER FROM TBL_PRD WHERE Serial  =  '" + SerialBox.Text + "'", con);
           // DataSet ds = new DataSet("SIMSv2");
           // Int32 result = da.Fill(ds, "NUMBER");

/*

            cmd = new SqlCommand("SELECT NUMBER FROM TBL_PRD WHERE Serial  =  '" + SerialBox.Text + "'", con);
            con.Open();
            SqlDataReader myReader = cmd.ExecuteReader();
            Int32 variable = 0;
            if (myReader.Read())
            {
                variable = myReader.GetInt32(0);
            }
            myReader.Close();
            con.Close();

            if (variable < userinput)
            {

                MessageBox.Show("العدد المطلوب سحبة أكبر من الموجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            */

        }

        private void pagenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DeptBtn openingNEWDept = new DeptBtn();
            openingNEWDept.Show();
        }
        
        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];

            txtSerial.Text = row.Cells[1].Value.ToString();
            NameText.Text = row.Cells[0].Value.ToString();
            CurrentNumber.Text = row.Cells[2].Value.ToString();
            custody.Text = row.Cells[3].Value.ToString();
            TypeText.Text = row.Cells[4].Value.ToString();
            pagenumber.Text = row.Cells[5].Value.ToString();
        }
        
        private void type1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //existsSrchButton.();
            }
        }

        private void serial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              //  existsSrchButton.PerformClick();
            }
        }

        private void DeptBox_TextChanged(object sender, EventArgs e)
        {
            con.Open();

            cmd = new SqlCommand("SELECT * FROM TBL_DEPT WHERE Name LIKE  '% " + DeptBox.Text + "%'", con);
            cmd.ExecuteNonQuery();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               
                string Type = (string)dr["Name"].ToString();
                con.Close();

                DeptBox.Text = Type;

                /*
                                string Name = (string)dr["الأسم"].ToString();
                                NameText.Text = Name;

                                string CustodyVariable = (string)dr["العهدة"].ToString();
                                custody.Text = CustodyVariable;

                                string page = (string)dr["رقم_الصفحة"].ToString();
                                pagenumber.Text = page;

                                string existingnumber = (string)dr["العدد"].ToString();
                                CurrentNumber.Text = existingnumber;*/

            }
            /*
            else
            {
                con.Close();

            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditExist openit = new EditExist();
            openit.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 form4open = new Form4();
            form4open.Show();

        }


        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void ExcutingButton_Click(object sender, EventArgs e)
        {
            Pullling();
            operation();
            secondtableload();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form4 form4open = new Form4();
            form4open.Show();

        }

        private void txtSerial_OnValueChanged(object sender, EventArgs e)
        {
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_PRD WHERE السيريال =  '" + txtSerial.Text + "'", con);

            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();




            while (dr.Read())
            {
                string Type = (string)dr["الصنف"].ToString();
                TypeText.Text = Type;

                string Name = (string)dr["الأسم"].ToString();
                NameText.Text = Name;

                string CustodyVariable = (string)dr["العهدة"].ToString();
                custody.Text = CustodyVariable;

                string page = (string)dr["رقم_الصفحة"].ToString();
                pagenumber.Text = page;

                string existingnumber = (string)dr["العدد"].ToString();
                CurrentNumber.Text = existingnumber;
            }


            dr.Close();
            con.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                txtSerial.Text = row.Cells[1].Value.ToString();
                NameText.Text = row.Cells[0].Value.ToString();
                CurrentNumber.Text = row.Cells[2].Value.ToString();
                custody.Text = row.Cells[3].Value.ToString();
                TypeText.Text = row.Cells[4].Value.ToString();
                pagenumber.Text = row.Cells[5].Value.ToString();
                //...
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                        string query2 = "SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD WHERE السيريال LIKE  '%"
             + serial1.Text + "%' AND الأسم like '%" + textBox3.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView.DataSource = dt22;

        }

        private void existsSrchButton_Click(object sender, EventArgs e)
        {
            string query2 = "SELECT الأسم,السيريال,العدد,العهدة,الصنف,رقم_الصفحة,تاريخ_الدخول FROM TBL_PRD WHERE السيريال LIKE  '%"
+ serial1.Text + "%' AND الأسم like '%" + textBox3.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView.DataSource = dt22;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4open = new Form4();
            form4open.Show();
        }
    }
}