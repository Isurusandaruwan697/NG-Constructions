using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enterprise_application
{
    public partial class Ustock : Form
    {
        public Ustock()
        {
            InitializeComponent();
        }

        private void Ustock_Load(object sender, EventArgs e)
        {
            vender_Load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serchEmolye se_form = new serchEmolye();
            se_form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Usupply obj= new Usupply();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["Name"].Value.ToString();
                comboBox1.Text = row.Cells["Catagory"].Value.ToString();
                textBox3.Text = row.Cells["Amount"].Value.ToString();
                textBox4.Text = row.Cells["Supplyer"].Value.ToString();
                textBox5.Text = row.Cells["Contity"].Value.ToString();




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stock values (@Id,@Name,@Catagory,@Amount,@Supplyer,@Contity)", con);
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Catagory", comboBox1.Text);

            cmd.Parameters.AddWithValue("@Amount", textBox3.Text);
            cmd.Parameters.AddWithValue("@Supplyer", textBox4.Text);
            cmd.Parameters.AddWithValue("@Contity", textBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Insert Success!");

            vender_Load();
        }
        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  Stock", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string catagory = comboBox1.Text;
            string Amount = textBox3.Text;
            string supplyer = textBox4.Text;
            string contity = textBox5.Text;


            string Query = "UPDATE Stock SET Name='" + name + "',Catagory='" + catagory + "', Amount='" + Amount + "',Supplyer='" + supplyer + "',Contity='" + contity + "' WHERE Id='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";

            MessageBox.Show("update Succesful!");
            vender_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string catagory = comboBox1.Text;
            string Amount = textBox3.Text;
            string supplyer = textBox4.Text;
            string contity = textBox5.Text;

            string Query = "DELETE FROM Stock WHERE Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("deleted success!");
            vender_Load();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userD obj = new userD();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isuueditem obj = new isuueditem();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Urecord obj = new Urecord();
            obj.Show();
            obj.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            user se_form = new user();
            se_form.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Stock WHERE Name=@Name", con);
                cmd.Parameters.AddWithValue("@Name", textBox6.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }
    }
    }

