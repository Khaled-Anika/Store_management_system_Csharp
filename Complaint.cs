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
    public partial class Complaint : Form
    {
        public Complaint()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void Complaint_Load(object sender, EventArgs e)
        {
            fillCategory();
            fillStatus();
        }
        private void fillCategory()
        {
            string Error = "";
            DBProduct Obj = new DBProduct();
            DataTable table = Obj.getAllCategory(ref Error);

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CategoryId = (comboBox1.SelectedIndex) + 1;
            if (comboBox1.SelectedValue.ToString() != "")
            {
                FillProducts(CategoryId);
            }
        }

        private void FillProducts(int cID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ProductId,PName from AllProduct where CategoryId =@CategoryId";
            cmd.Parameters.AddWithValue("@CategoryId", cID);
            DataSet Ods = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            con.Open();
            sda.Fill(Ods);
            con.Close();

            if (Ods.Tables[0].Rows.Count > 0)
            {
                comboBox2.DisplayMember = "PName";
                comboBox2.ValueMember = "ProductId";
                comboBox2.DataSource = Ods.Tables[0];
            }
        }

        private void fillStatus()
        {
            string Error = "";
            DBProduct Obj = new DBProduct();
            DataTable table = Obj.getAllStatus(ref Error);

            comboBox3.DataSource = table;
            comboBox3.DisplayMember = "ProblemSolved";
            comboBox3.ValueMember = "SlvId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO ProductProblem (CName,PName,Problem) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + richTextBox1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            richTextBox1.Clear();
            textBox1.Clear();
            con.Close();
            MessageBox.Show("Added !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM ProductProblem WHERE ProblemId='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            richTextBox1.Clear();
            textBox1.Clear();
            con.Close();
            MessageBox.Show("Deleted !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from ProductProblem";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "YES")
            {
                con.Open();
                string query = "UPDATE ProductProblem SET Problem = '" + richTextBox1.Text + "' WHERE ProblemId = '" + textBox1.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Status Updated !");
            }
            else
            {
                MessageBox.Show("Problem not solved yet !!");

            }
            richTextBox1.Clear();
            textBox1.Clear();
        }
    }
}
