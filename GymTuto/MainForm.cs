using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTuto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //UPDATE/DELETE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDelete update = new UpdateDelete();
            update.Show();
            this.Hide();
        }
        //PAYMENTS BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            Payments pay = new Payments();
            pay.Show();
            this.Hide();
        }
        //VIEW BUTTON
        private void button3_Click_1(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();    
        }
        //DOG PIC
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
