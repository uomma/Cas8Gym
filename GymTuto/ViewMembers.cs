using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymTuto
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTbl where MName= '" + SearchMember.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        //SEARCH BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            filterByName();

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //POPULATE METHOD
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandra\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate(); 
        }
        //BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
          MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
        //REFRESH BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //X BUTTON
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
