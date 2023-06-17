﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Enterprise_application
{
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminD obj = new AdminD();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
           
            string id = textBox1.Text;
            string name = textBox2.Text;
            string location = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string cost = textBox5.Text;

            string Query = "INSERT INTO project (Id,name,location,start,endd,cost)VALUES ('"+id+"','"+name+"','"+location+"','"+start+"','"+endd+"','"+cost+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteReader();
            con.Close();
           
            MessageBox.Show("insert success!");
            vender_Load();
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox5.Text = "";
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Projects_Load(object sender, EventArgs e)
        {
            vender_Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string id = textBox1.Text;
            string name = textBox2.Text;
            string location = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string cost = textBox5.Text;

            string Query = "DELETE FROM project WHERE Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            vender_Load();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Delete success!");

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["name"].Value.ToString();
                textBox3.Text = row.Cells["location"].Value.ToString();
               //dateTimePicker1.Text = row.Cells["start"].Value.ToString();
               //dateTimePicker1.Text = row.Cells["endd"].Value.ToString();
                textBox5.Text = row.Cells["cost"].Value.ToString();




            }
        }
        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Projects_Load_1(object sender, EventArgs e)
        {
            vender_Load();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label8.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Supplyers obj = new Supplyers();
            this.Hide();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stock obj = new Stock();
            this.Hide();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            
            this.Hide();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Projects obj =new Projects ();

            this.Hide();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Records obj = new Records();

            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 se_form = new Form2();
            se_form.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string id = textBox1.Text;
            string name = textBox2.Text;
            string location = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string cost = textBox5.Text;


            string Query = "UPDATE project SET name='" + name + "',location='" + location + "', start='" + start + "',endd='" + endd + "' WHERE Id='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("update Succesful!");
            vender_Load();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            vender_Load();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
