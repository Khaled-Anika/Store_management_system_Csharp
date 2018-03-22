using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_manage
{
    public partial class ShowSell : Form
    {
        public ShowSell()
        {
            InitializeComponent();
        }

        private void ShowSell_Load(object sender, EventArgs e)
        {
            string Error = "";
            DBProduct obj = new DBProduct();
            DataTable table = obj.getAllSellsData(ref Error);
            if (Error != "")
            {
                MessageBox.Show(Error);
            }
            else
            {
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
