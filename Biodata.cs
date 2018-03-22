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

namespace Store_manage
{
    public partial class Biodata : Form
    {
        public Biodata()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Biodata_Load(object sender, EventArgs e)
        { 
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Info (name,Mbl) VALUES ('" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommand cmd = new SqlCommand("INSERT INTO INFO (REGNO,NAME,MBL) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')", con);
            sda.SelectCommand.ExecuteNonQuery();
            textBox6.Clear();
            textBox2.Clear();
            textBox5.Clear();
            con.Close();
            MessageBox.Show("Added !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Info";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt); 
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Info WHERE RegNo='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            textBox6.Clear();
            textBox2.Clear();
            textBox5.Clear();
            con.Close();
            MessageBox.Show("Deleted !");
        }

        private void button7_Click(object sender, EventArgs e)
        {
             con.Open();
            string query1 = "UPDATE Info SET name = '" + textBox5.Text + "' WHERE RegNo = '" + textBox2.Text + "' ";

            string query2 = "UPDATE Info SET Mbl = '" + textBox6.Text + "' WHERE RegNo = '" + textBox2.Text + "' ";

            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);

            sda1.SelectCommand.ExecuteNonQuery();
            sda2.SelectCommand.ExecuteNonQuery();
            textBox6.Clear();
            textBox2.Clear();
            textBox5.Clear();

            con.Close();
            MessageBox.Show("Updated !");
        }
    }
}
