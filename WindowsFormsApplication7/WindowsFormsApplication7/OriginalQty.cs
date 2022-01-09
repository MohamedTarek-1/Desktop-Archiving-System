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

    public partial class OriginalQty : Form
    {

        // SqlConnection con = new SqlConnection(@"Server=WIN-9CBF44K90T1\SQLEXPRESS;Database=newData;Integrated Security=True;MultipleActiveResultSets=true;");
        SqlConnection con = new SqlConnection(@"Server=TYRIEL-PC\SQLEXPRESS;Database=DB_BARCODE2;Integrated Security=True;MultipleActiveResultSets=true;");

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        DataSet dsx = new DataSet();
        SqlCommand cmd;

        public OriginalQty()
        {
            InitializeComponent();
        }

        private void OriginalQty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_BARCODE2DataSet.TBL_ORG' table. You can move, or remove it, as needed.
            //    eeeeeeeeeeeeee    this.tBL_ORGTableAdapter.Fill(this.dB_BARCODE2DataSet.TBL_ORG);

            //dateTimePicker1.Value = DateTime.Now;
            con.Open();
            firsttableload();
        }


        public void firsttableload()
        {
            //con.Open();

            //cmd = new SqlCommand(" SELECT الأسم,العدد,العدد_قبل_الإضافة,العدد_بعد_الإضافة,الصنف,تاريخ_الدخول,السيريال FROM TBL_ORG ", con);
           // cmd = new SqlCommand("SELECT تاريخ_الدخول, , العدد, السيريال,الصنف, الأسم FROM TBL_ORG", con);
            cmd = new SqlCommand("SELECT تاريخ_الدخول, العدد_بعد_الإضافة, العدد_قبل_الإضافة, العدد, السيريال,الصنف, ID,الأسم FROM TBL_ORG", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();

            con.Close();

        }

        private void existsSrchButton_Click(object sender, EventArgs e)
        {

        }

        private void existsSrchButton_Click_1(object sender, EventArgs e)
        {
            string query2 = "SELECT تاريخ_الدخول, العدد_بعد_الإضافة, العدد_قبل_الإضافة, العدد, السيريال,الصنف, ID,الأسم FROM TBL_ORG WHERE السيريال LIKE  '%"
  + serial1.Text + "%' AND الأسم like '%" + name1.Text + "%' AND الصنف like '%" + type1.Text + "%'";
            SqlDataAdapter da22 = new SqlDataAdapter(query2, con);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);
            dataGridView1.DataSource = dt22;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrgReport openform = new OrgReport();
            openform.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            txtSerial.Text = row.Cells[7].Value.ToString();
            datetxt.Text = row.Cells[6].Value.ToString();
            txtType.Text = row.Cells[5].Value.ToString();
            txtQty.Text = row.Cells[2].Value.ToString();
            Nametxt.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[0].Value.ToString();


        }

        private void ExcutingButton_Click(object sender, EventArgs e)
        {
            con.Open();
            // string date = dateTimePicker1.Text;
            cmd = new SqlCommand(" UPDATE  TBL_ORG set السيريال ='" + txtSerial.Text +
                "' , الأسم = '" + Nametxt.Text +
                "' , الصنف = '" + txtType.Text +
                "' , العدد = '" + txtQty.Text +
                "' , تاريخ_الدخول = '" + datetxt.Text +
                "' Where ID = '" + textBox5.Text + "'", con);
            cmd.ExecuteNonQuery();

            firsttableload();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show(" Are you sure you want to Delete This Record?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                con.Open();

                cmd = new SqlCommand(" DELETE  FROM TBL_ORG WHERE  Id ='" + textBox5.Text + "' ", con);
                cmd.ExecuteNonQuery();

                firsttableload();

                con.Close();

            }
            else
            {

                Close();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtSerial.Text = row.Cells[7].Value.ToString();
                datetxt.Text = row.Cells[6].Value.ToString();
                txtType.Text = row.Cells[5].Value.ToString();
                txtQty.Text = row.Cells[2].Value.ToString();
                Nametxt.Text = row.Cells[1].Value.ToString();
                textBox5.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}