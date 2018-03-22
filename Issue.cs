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
    public partial class Issue : Form
    {
        public Issue()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void Issue_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Issues (IssueName,ProductId) VALUES ('"+textBox3.Text + "','" + textBox1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            string query_Del = "DELETE FROM AllProduct WHERE ProductId = '" + textBox1.Text + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query_Del , con);
            sda1.SelectCommand.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            con.Close();
            MessageBox.Show("Issue added and defect product deleted !");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Issues";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Issues WHERE IssueId='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            con.Close();
            MessageBox.Show("Deleted !");
        }
    }
}
