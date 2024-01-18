using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymTuto
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        //CONNECTION WITH DATABASE
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

        //FUNCTION OF CallToDB INVOKED
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        //MEMBER SDGV
        int key = 0;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            TimeCb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
           
            


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //RESET BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimeCb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        //DELETE BUTTON 
        private void button5_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the member to delete");
            }
            else
            {
                try {
                    Con.Open();
                    string query = "delete from MemberTbl where Mid='" + key + "'";
                    SqlCommand cmd= new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Deleted");
                    Con.Close();
                    populate();
                
                }
                catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                }
            }
        }

        //UPDATE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || AmountTb.Text == "" || GenderCb.Text == "" || TimeCb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTbl set MName = '" + NameTb.Text + "', MPhone= '" + PhoneTb.Text + "',MAge= '" + AgeTb.Text + "', MGen = '" + GenderCb.Text + "',  MAmount = '" + AmountTb.Text + "', MTime='" + TimeCb.Text + "' where MId=" + key + "; ";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("member Updated succsessfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //X BUTTON
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
