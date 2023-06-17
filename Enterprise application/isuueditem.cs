using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enterprise_application
{
    public partial class isuueditem : Form
    {
        public isuueditem()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            user se_form = new user();
            se_form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Urecord obj = new Urecord();

            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serchEmolye se_form = new serchEmolye();
            se_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Stock obj = new Stock();

            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usupply obj = new Usupply();

            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isuueditem obj = new isuueditem();
            obj.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string id = textBox1.Text;
            string name = textBox2.Text;
            string quentity = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string employe = textBox5.Text;
            string tele = textBox4.Text;

            string Query = "INSERT INTO item (Id,name,quentity,start,endd,employe,tele)VALUES ('" + id + "','" + name + "','" + quentity + "','" + start + "','" + endd + "','"+employe+"','" + tele + "')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteReader();
            con.Close();

            MessageBox.Show("insert success!");
            vender_Load();

            textBox1.Text = "";
            textBox2.Text="";
            textBox3.Text="";
            //dateTimePicker1.Text="17-06-2023";
            //dateTimePicker2.Text="17-06-2023";
            textBox5.Text="";
            textBox4.Text="";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string id = textBox1.Text;
            string name = textBox2.Text;
            string quentity = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string employe = textBox5.Text;
            string tele = textBox4.Text;


            string Query = "UPDATE item SET name='" + name + "',quentity='" + quentity + "', start='" + start + "',endd='" + endd + "','"+employe+"','"+ tele + "', WHERE Id='" + id + "' ";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("update Succesful!");
            vender_Load();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";


        }
        private void vender_Load()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  item", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }



        private void isuueditem_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Id"].Value.ToString();
                textBox2.Text = row.Cells["name"].Value.ToString();
                textBox3.Text = row.Cells["quentity"].Value.ToString();
                //dateTimePicker1.Text = row.Cells["start"].Value.ToString();
                //dateTimePicker1.Text = row.Cells["endd"].Value.ToString();
                textBox5.Text = row.Cells["employe"].Value.ToString();
                textBox4.Text = row.Cells["tele"].Value.ToString();





            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isuueditem_Load_1(object sender, EventArgs e)
        {
            vender_Load();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = DateTime.Now.ToLongDateString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            string id = textBox1.Text;
            string name = textBox2.Text;
            string quentity = textBox3.Text;
            string start = dateTimePicker1.Text;
            string endd = dateTimePicker2.Text;
            string employe = textBox5.Text;
            string tele = textBox4.Text;

            string Query = "DELETE FROM item WHERE Id='" + id + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();
            vender_Load();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            MessageBox.Show("Delete success!");
        }
    }
}
