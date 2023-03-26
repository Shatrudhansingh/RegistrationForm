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
using System.Data.Common;
using System.Data.SqlTypes;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
         long stdid;
        private void Form1_Load(object sender, EventArgs e)
        {
        con = new SqlConnection("Data Source=LAPTOP-8R9P3I75;Database=NewProject;User Id=sa;Password=12345");
            ShowData();

        }
        private void ShowData()
        {
            cmd = new SqlCommand("Select *from Student", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            dgvstudentdetails.DataSource = dt;
            con.Close();
        }
        private void btnnewreset_Click(object sender, EventArgs e)
        {
            textboxClear();
        }
        private void textboxClear()
        {
            txtname.Text = "";
            txtadd.Text = "";
            txtphone.Text = "";
            txtsem.Text = "";
            cbbranch.SelectedIndex = -1;
            txtsearch.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Student values(@Sname,@addr,@phone,@sem,@brancs)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@addr", txtadd.Text);
            cmd.Parameters.AddWithValue("@Sname", txtname.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@sem", txtsem.Text);
            cmd.Parameters.AddWithValue("@brancs", cbbranch.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowData();
            textboxClear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Student", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowData();
        }

        private void dgvstudentdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(("update student set @sname=sname,@addr=addr,@phone=phone,@sem=sem,@branch=branch where @stdid=regno"), con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@addr", txtadd.Text);
            cmd.Parameters.AddWithValue("@Sname", txtname.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@sem", txtsem.Text);
            cmd.Parameters.AddWithValue("@branch", cbbranch.SelectedText);
            cmd.Parameters.AddWithValue("@stdid",this.stdid);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            ShowData();
            textboxClear();
        }

        private void dgvstudentdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdid = Convert.ToInt64(dgvstudentdetails.SelectedRows[0].Cells[0].Value);
            txtname.Text = dgvstudentdetails.SelectedRows[0].Cells[1].Value.ToString();
            txtadd.Text = dgvstudentdetails.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = dgvstudentdetails.SelectedRows[0].Cells[3].Value.ToString();
            txtsem.Text = dgvstudentdetails.SelectedRows[0].Cells[4].Value.ToString();
            cbbranch.Text = dgvstudentdetails.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
