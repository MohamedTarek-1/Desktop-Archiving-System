using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class الإضافة : Form
    {

        // SqlConnection con = new SqlConnection(@"Server=IT-PC\SQLEXPRESS;Database=DB_BARCODE;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQL2019;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        #region Variables

        public  Int64 userinput;//العدد المراد إضافتة
        public  Int64 userinput2;//العدد قبل الإضافة
        public  Int64 userinput3;//العدد بعد الإضافة
        public  Int64 diffrence;
        public  Int64 oldTBLPRD;
        public  Int64 oldTBLPRD2;

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet dsx = new DataSet();
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataReader myReader3;
        String custody;
        #endregion

        public الإضافة()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            fillingComboBox();

        }

        #region EventHandlers
        private void txtSerial_TextChanged(object sender, EventArgs e)
        {

            //con.Close();
            con.Open();

            cmd = new SqlCommand("SELECT * FROM TBL_PRD WHERE السيريال =  '" + txtSerial.Text + "'", con);
            cmd.ExecuteNonQuery();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            //  if (!dr.IsDBNull())
            //{

            // }

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    string Name = (string)dr["الأسم"].ToString();
                    txtName.Text = Name;

                    string Type = (string)dr["الصنف"].ToString();
                    comboBox1.Text = Type;


                    string CustodyVariable = (string)dr["العهدة"].ToString();
                    // custody.Text = CustodyVariable;

                    if (CustodyVariable == "عهدة قوات مسلحة ")
                    {
                        rdiobtnMilitary.Checked = true;
                    }
                    else if (CustodyVariable == "عهدة خارجية ")
                    {
                        rdiobtnOuter.Checked = true;

                    }
                    else
                    {

                    };


                    string page = (string)dr["رقم_الصفحة"].ToString();
                    txtPagen.Text = page;

                    string existingnumber = (string)dr["العدد"].ToString();
                    CurrentNumber.Text = existingnumber;


                }

            }


            else
            {
                clearTexts();

            }

            dr.Close();
            con.Close();


        }

        #endregion

        #region AddingOperations

        public void AddingOperation()  //REPLACE TRYCATCH by Binding the user's Ability to Enter Wrong Format
        {
            cmd = new SqlCommand(" INSERT INTO TBL_PRD Values " +
                "(@الأسم,@السيريال,@العدد,@العهدة,@الصنف,@رقم_الصفحة,@تاريخ_الدخول)", con);
            // INSERT INTO TBL_PRD Values (@Name,@Serial,@Des,@Qty,@Custody,@Type,@Date,@Place,@Pagen,@Reciever,@Kemmya)

            if (rdiobtnMilitary.Checked)
            {
                custody = "عهدة قوات مسلحة";
            }
            else
            {
                custody = "عهدة خارجية";

            }

            #region Parameters
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@الأسم", SqlDbType.VarChar);
            try
            {
                param[0].Value = txtName.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            param[1] = new SqlParameter("@السيريال", SqlDbType.NChar, 50);
            try
            {
                param[1].Value = txtSerial.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            param[2] = new SqlParameter("@العدد", SqlDbType.Int);
            try
            {
                param[2].Value = txtQty.Text;
                userinput = Int64.Parse(txtQty.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            param[3] = new SqlParameter("@العهدة", SqlDbType.VarChar, 35);
            try
            {
                param[3].Value = custody;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            param[4] = new SqlParameter("@الصنف", SqlDbType.VarChar, 35);
            try
            {
                param[4].Value = comboBox1.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            param[5] = new SqlParameter("@رقم_الصفحة", SqlDbType.NChar, 10);

            try
            {
                param[5].Value = txtPagen.Text;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("تأكد من دخول اليانات بصيغة صحيحة", "خطأ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            param[6] = new SqlParameter("@تاريخ_الدخول", SqlDbType.VarChar, 50);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";


            DateTime dp1 = dateTimePicker1.Value;
            // Modify next line, set HH:MM to HH:mm
            String dpstring = dp1.ToString("dd/MM/yyyy hh:mm tt");

            param[6].Value = dpstring;
            #endregion


            //GETTING CURRENT TBL_PRD QTY VALUE//////////////////Select العدد///////////////
            #region UsedSearchCommand

            //  oldTBLPRD = old TBL_PRD value   serial 
            //  oldTBLPRD2 = old TBL_PRD value having in common serial and name

            cmd2 = new SqlCommand("SELECT العدد FROM TBL_PRD WHERE السيريال  =  '" + txtSerial.Text + "' ", con);
            con.Open();
            SqlDataReader myReader2 = cmd2.ExecuteReader();
            oldTBLPRD = 0;
            if (myReader2.Read())
            {
                oldTBLPRD = myReader2.GetInt32(0);
                myReader2.Close();

            }
            con.Close();
            myReader2.Close();
            #endregion
            #region notUsedSearchCommand
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            cmd2 = new SqlCommand("SELECT العدد FROM TBL_PRD WHERE السيريال  =  '"
                + txtSerial.Text + "' AND الأسم = '" + txtName.Text + "' ", con);
            con.Open();

            myReader3 = cmd2.ExecuteReader();
            oldTBLPRD2 = 0;
            if (myReader3.Read())
            {
                oldTBLPRD2 = myReader3.GetInt32(0);
                myReader3.Close();

            }
            con.Close();
            myReader3.Close();
            #endregion


            //CHECKING IF SERIAL OR SERIAL AND NAME EXISTS//////////////////////Select */////////////////////////////

            //i = serial exists
            //ix = serial and name exists
            #region UsedSearchCommand
            cmd2 = new SqlCommand("SELECT * FROM TBL_PRD where السيريال = '" + txtSerial.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            #endregion
            #region notUsedSearchCommand

            /*
            SqlCommand cmdx = new SqlCommand("SELECT * FROM TBL_PRD where السيريال = '" + txtSerial.Text 
                + "' AND الأسم = '" + txtName.Text + "' ", con);
            SqlDataAdapter dax = new SqlDataAdapter(cmdx);

            dax.Fill(dsx);
            int ix = dsx.Tables[0].Rows.Count;
            */
            #endregion

            diffrence = oldTBLPRD + userinput;

            if (userinput != 0 && userinput > 0)
            {
                if (i > 0) /// IF VALUE SERIAL EXISTS IN TABLE
                {
                    //  MessageBox.Show("should be updated", "LOL", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Question);

                    cmd = new SqlCommand(" UPDATE  TBL_PRD set العدد ='" + diffrence + "' Where السيريال = '" + txtSerial.Text + "'", con);
                    cmd2 = new SqlCommand(" UPDATE  TBL_PRD set تاريخ_الدخول ='" + dpstring + "' Where السيريال = '" + txtSerial.Text + "' ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تمت الإضافة علي الصنف وتجديد تاريخ الدخول", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    addingToTblOrginalQts();
                    clearTexts();

                }

                else   /// IF THE SERIAL IS NEW
                {
                    con.Open();
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("تم إضافة المنتج بنجاح", "الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addingToTblOrginalQts();

                    /////////////CLEARING TEXTS
                    //   con.Close();
                    txtName.Text = "";
                    txtQty.Text = "";
                    txtSerial.Text = "";
                    txtPagen.Text = "";
                    //comboBox1.Items.Clear();
                    comboBox1.SelectedIndex = -1;

                    rdiobtnMilitary.Checked = false;
                    rdiobtnOuter.Checked = false;
                }

            }   // IF Input Not 0 & Bigger Than 0 
            else
            {
                MessageBox.Show("لم تتم الإضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void addingToTblOrginalQts()
        {
            cmd = new SqlCommand("INSERT INTO TBL_ORG Values (@الأسم,@العدد,@الصنف,@تاريخ_الدخول,@السيريال,@العدد_قبل_الإضافة,@العدد_بعد_الإضافة)", con);

            #region Parameters

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@الأسم", SqlDbType.NVarChar, 150);
            param[0].Value = txtName.Text;

            param[1] = new SqlParameter("@العدد", SqlDbType.Int);
            param[1].Value = txtQty.Text;
            userinput = Int64.Parse(txtQty.Text);

            param[2] = new SqlParameter("@الصنف", SqlDbType.NVarChar, 50);
            param[2].Value = comboBox1.Text;

            param[3] = new SqlParameter("@تاريخ_الدخول", SqlDbType.NVarChar, 50);
            DateTime dp1 = dateTimePicker1.Value;
            // Modify next line, set HH:MM to HH:mm
            String dpstring = dp1.ToString("dd/MM/yyyy hh:m tt");
            param[3].Value = dpstring;


            param[4] = new SqlParameter("@السيريال", SqlDbType.NVarChar, 50);
            param[4].Value = txtSerial.Text;

            param[5] = new SqlParameter("@العدد_قبل_الإضافة", SqlDbType.Int);
            param[5].Value = CurrentNumber.Text;


            if (userinput == 0)
            {

                MessageBox.Show("لم يتم إدخال كمية", "!خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sets default value for  العدد_عند_الإضافة , وبعد

            }
            else if (userinput < 0)
            {

                MessageBox.Show("تأكد أن العدد أكبر من 0", "!خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sets default value for  العدد_عند_الإضافة , وبعد

            }

            else if (CurrentNumber == null)
            {

                //sets default value for  العدد_عند_الإضافة , وبعد
                userinput2 = 0;
                userinput3 = userinput;
                param[6] = new SqlParameter("@العدد_بعد_الإضافة", SqlDbType.Int);
                param[6].Value = userinput3;

                con.Open();
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                con.Close();

            }

            else
            {
                userinput2 = Int64.Parse(CurrentNumber.Text);
                userinput3 = userinput2 + userinput;
                param[6] = new SqlParameter("@العدد_بعد_الإضافة", SqlDbType.Int);
                param[6].Value = userinput3;
                con.Open();

                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            #endregion
        }    //ADDS TO TABLE الكميات عند الدخول

        #endregion

        #region SecondaryMethods
        public void fillingComboBox()
        {

            comboBox1.Items.Clear();
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

                comboBox1.Items.Add(dr["Name"].ToString());

            };


            con.Close();
        }
        public void clearTexts()
        {
            /////////////CLEARING TEXTS
            txtName.Text = "";
            txtQty.Text = "";
            txtPagen.Text = "";
            CurrentNumber.Text = "0";
            comboBox1.Text = "";
            rdiobtnMilitary.Checked = false;
            rdiobtnOuter.Checked = false;
        }
        #endregion

        #region ButtonClicks
        private void addbtn_Click(object sender, EventArgs e)
        {

            if ((txtName.Text == "") || (txtQty.Text == "") || (txtSerial.Text == "")
            || (comboBox1.Text == "") || (rdiobtnMilitary.Checked == false) && (rdiobtnOuter.Checked == false))
            {
                MessageBox.Show("الرجاء إكمال المربعات الفارغة", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                userinput = Int64.Parse(txtQty.Text);

                if (userinput == 0)
                {

                    MessageBox.Show("لم يتم إدخال كمية", "!خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sets default value for  العدد_عند_الإضافة , وبعد

                }
                else if (userinput < 0)
                {

                    MessageBox.Show("تأكد أن العدد أكبر من 0", "!خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sets default value for  العدد_عند_الإضافة , وبعد

                }
                else
                {
                    MessageBox.Show("Entered!", "What!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    AddingOperation();
                }
            }

        }    //EXECUTING BUTTON
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }  //EXIT BUTTON
        #region OpenOtherForms
        private void button3_Click_1(object sender, EventArgs e)
        {
            Form900 openform6 = new Form900();
            openform6.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            إضافة_خارج form4open = new إضافة_خارج();
            form4open.Show();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            EditIn openit = new EditIn();
            openit.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 form4open = new Form4();
            form4open.Show();

        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            DeptBtn form1open = new DeptBtn();
            form1open.Show();


        }
        #endregion
        #endregion
    }
}