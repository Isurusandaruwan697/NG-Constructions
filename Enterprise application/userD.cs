using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class userD : Form
    {
        public userD()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label7.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user se_form = new user();
            se_form.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            serchEmolye se_form = new serchEmolye();
            se_form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usupply obj = new Usupply();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ustock obj = new Ustock();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Urecord obj = new Urecord();
            obj.Show(); 
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isuueditem obj=new isuueditem();
            obj.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            userD obj=new userD();
            obj.Show(); 
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void userD_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Sup", con);
            var count1 = cmd.ExecuteScalar();
            label12.Text = count1.ToString();




            SqlCommand cmdd = new SqlCommand("select count(*) from Stock", con);
            var count2 = cmdd.ExecuteScalar();
            label1.Text = count2.ToString();


            SqlCommand cmddd = new SqlCommand("select count(*) from vender12", con);
            var count3 = cmddd.ExecuteScalar();
            label2.Text = count3.ToString();




           // SqlCommand cmd3 = new SqlCommand("select count(*) from project", con);
           // var count4 = cmd3.ExecuteScalar();
            //label15.Text = count4.ToString();

            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
