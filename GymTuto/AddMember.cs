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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandra\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        //RESET BUTTON
        private void button3_Click_1(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimeCb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //BACK BUTTON
        private void button4_Click_1(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        //ADD MEMBER
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into MemberTbl values('" + NameTb.Text + "', '" + PhoneTb.Text + "', '" + GenderCb.SelectedItem.ToString() + "', " + AgeTb.Text + ", '" + TimeCb.SelectedItem.ToString() + "' ,'" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Con.Close();
                    AmountTb.Text = "";
                    AgeTb.Text = "";
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.Text = "";
                    TimeCb.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
