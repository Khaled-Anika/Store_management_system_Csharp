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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASUS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");


        private void Sell_Load(object sender, EventArgs e)
        {
            fillCategory();
            textBox3.Text = "0.00";

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PId = comboBox2.Text;
            if (comboBox2.SelectedValue.ToString() != "")
            {
                //   MessageBox.Show("it");
                FillPrice(PId);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex > 0)
            //{
            //    if (comboBox1.SelectedValue.ToString() != "")
            //    {
            //        int catId = (comboBox1.SelectedIndex) + 1;
            //        MessageBox.Show("it");
            //        DBProduct Obj = new DBProduct();
            //        DataTable table2 = Obj.getCatProduct(catId);
            //        comboBox2.DataSource = table2;
            //        comboBox2.DisplayMember = "PName";

            //    }
            //}
            int CategoryId = (comboBox1.SelectedIndex) + 1;
            if (comboBox1.SelectedValue.ToString() != "")
            {
                FillProducts(CategoryId);
                //comboBox1.SelectedIndex = 0;

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
            else
            {
                comboBox2.DisplayMember = null;
            }
        }

        private void FillPrice(string Prc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select PPrice from AllProduct where PName =@PId";
            cmd.Parameters.AddWithValue("@PId", Prc);
            DataSet Ods = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            con.Open();
            sda.Fill(Ods);
            con.Close();

            if (Ods.Tables[0].Rows.Count > 0)
            {
                comboBox3.DataSource = Ods.Tables[0];
                comboBox3.DisplayMember = "PPrice";
               // comboBox3.ValueMember = "ProductId";
                //comboBox3.Text = "PPrice";

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        } 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0.00";
            if (textBox2.Text != "")
            {
                double price = 0.00;
                price = Convert.ToInt32(comboBox3.Text) * Convert.ToInt32(textBox2.Text);

                textBox3.Text = Convert.ToString(price);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pID = Convert.ToInt32(comboBox2.SelectedValue);
            string Error = "";
            DBProduct Obj = new DBProduct();
            double PCount = Obj.geProductQuantityCount(pID, ref Error);
            double qun = Convert.ToInt64(textBox2.Text);
            if (qun < PCount)
            {
                con.Open();
                string query = "INSERT INTO SalesInfo (CategoryName,PtName,SQuantity,Price,Date) VALUES ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "', '" + dateTimePicker1.Value.Date + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sell Submitted !");
            }
            else
            {
                MessageBox.Show("Quantity exceeded the available limit in stock !!");
                MessageBox.Show("Available Quantity of the selected product : " + Convert.ToString(PCount));
            }
            textBox2.Clear();
            textBox3.Clear();
        }
    }
 }

