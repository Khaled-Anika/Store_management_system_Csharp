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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select ROLE from LOGIN where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainForm ob1 = new MainForm(dt.Rows[0][0].ToString());
                ob1.Show();
                // ((Form))ob1).Controls["lable1"].Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password ! Try Again !!");
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
