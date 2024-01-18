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

namespace GymTuto
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NameCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                string payperiod = Periodo.Value.Month.ToString() + "/" + Periodo.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from PaymentTbl where PMember='" + NameCb.SelectedValue.ToString() + "' and PMonth='" + payperiod + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for this month");
                }
                else
                {
                    string query = "insert into PaymentTbl values('" + payperiod + "', '" + NameCb.SelectedValue.ToString() + "', '" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }
                Con.Close();
                populate();
            }
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandra\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MName from MemberTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            NameCb.ValueMember = "MName";
            NameCb.DataSource = dt;
            Con.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTbl where PMember= '"+SearchName.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

            private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //NameTb.Text = "";
            AmountTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterByName();
            SearchName.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
