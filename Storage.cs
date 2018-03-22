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
    public partial class Storage : Form
    {
        public Storage()
        {
            
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            int catId = Convert.ToInt32(comboBox1.SelectedValue);

            // con.Open();
            //string CName = comboBox1.Text;
            //DataTable dt = new DataTable();
            //int catId = (from DataRow dr in dt.Rows where (string)dr["CategoryName"] == CName select(int)dr["CategoryId"]).FirstOrDefault();

            //int catId = (comboBox1.SelectedIndex) + 1;

            con.Open();
            string query = "INSERT INTO AllProduct (PName,PPrice,PQuantity,CategoryId) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "', '" + catId + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();

            con.Close();
            MessageBox.Show("Added !"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
         //   string query = "UPDATE AllProduct SET PName = '" + textBox4.Text + "' WHERE ProductId = '" + textBox1.Text + "' ";
            string query = "UPDATE AllProduct SET PName = '" + textBox1.Text + "' WHERE ProductId = '" + textBox4.Text + "' ";
            string query1 = "UPDATE AllProduct SET PPrice = '" + textBox2.Text + "' WHERE ProductId = '" + textBox4.Text + "' ";
            string query2 = "UPDATE AllProduct SET PQuantity = '" + textBox5.Text + "' WHERE ProductId = '" + textBox4.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);


            sda.SelectCommand.ExecuteNonQuery();
            sda1.SelectCommand.ExecuteNonQuery();
            sda2.SelectCommand.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();

            con.Close();
            MessageBox.Show("Updated !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM AllProduct WHERE ProductId='" + textBox4.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();

            con.Close();
            MessageBox.Show("Deleted !");
        }


        private void AddPro_Load(object sender, EventArgs e)
        {
            if (((Form)this.MdiParent).Controls["label1"].Text != "Admin")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            fill();
        }

        private void fill()
        {
            string Error = "";
            DBProduct Obj = new DBProduct();
            DataTable table = Obj.getAllCategory(ref Error);

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from AllProduct";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}

