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
    public partial class MainForm : Form
    {
        public MainForm(string ROLE)
        {
            InitializeComponent();
            label1.Text = ROLE;
        }

        Biodata ob = new Biodata();
        Storage ob1 = new Storage();
        Issue ob2 = new Issue();
        Category ob3 = new Category();
        Sell ob4 = new Sell();
        Complaint ob5 = new Complaint();
        ShowSell ob6 = new ShowSell();

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob.IsDisposed == true)
            {
                ob = new Biodata();
            }
            ob.MdiParent = this;
            ob.Show();
            ob1.Hide();
            ob2.Hide();
            ob3.Hide();
            ob4.Hide();
            ob5.Hide();
            ob6.Hide();
            label2.Hide();
        }

        private void aDDPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob1.IsDisposed == true)
            {
                ob1 = new Storage();
            }
            ob1.MdiParent = this;
            ob1.Show();
            ob.Hide();
            ob2.Hide();
            ob3.Hide();
            ob4.Hide();
            ob5.Hide();
            ob6.Hide();
            label2.Hide();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            label2.Text = "You just LoggedIn as: " + label1.Text;
            LoginTS.Enabled = false;
        }

        private void iSSUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob2.IsDisposed == true)
            {
                ob2 = new Issue();
            }
            ob2.MdiParent = this;
            ob2.Show();
            ob1.Hide();
            ob.Hide();
            ob3.Hide();
            ob4.Hide();
            ob5.Hide();
            ob6.Hide();
            label2.Hide();

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob3.IsDisposed == true)
            {
                ob3 = new Category();
            }
            ob3.MdiParent = this;
            ob3.Show();
            ob1.Hide();
            ob2.Hide();
            ob.Hide();
            ob4.Hide();
            ob5.Hide();
            ob6.Hide();
            label2.Hide();

        }

        private void sELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob4.IsDisposed == true)
            {
                ob4 = new Sell();
            }
            ob4.MdiParent = this;
            ob4.Show();
            ob1.Hide();
            ob2.Hide();
            ob3.Hide();
            ob.Hide();
            ob5.Hide();
            ob6.Close();
            label2.Hide();

        }

        private void cUSTOMERCOMPLAINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob5.IsDisposed == true)
            {
                ob5 = new Complaint();
            }
            ob5.MdiParent = this;
            ob5.Show();
            ob1.Hide();
            ob2.Hide();
            ob3.Hide();
            ob4.Hide();
            ob.Hide();
            ob6.Hide();
            label2.Hide();

        }

        private void sELLINGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ob6.IsDisposed == true)
            {
                ob6 = new ShowSell();
            }
            ob6.MdiParent = this;
            ob6.Show();
            ob.Hide();
            ob1.Hide();
            ob2.Hide();
            ob3.Hide();
            ob4.Hide();
            ob5.Hide();
            label2.Hide();

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogoutTS.Enabled = false;
            LoginTS.Enabled = true;
            ExitTS.Enabled = true;
            FileTS.Enabled = false;
            CategoryTS.Enabled = false;
            StorageTS.Enabled = false;
            SellTS.Enabled = false;
            SellInfoTS.Enabled = false;
            IssueTS.Enabled = false;
            ComplaintTS.Enabled = false;

            ob.Close();
            ob1.Close();
            ob2.Close();
            ob3.Close();
            ob4.Close();
            ob5.Close();
            ob6.Close();
            label2.Hide();

        }

        private void ExitTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginTS_Click(object sender, EventArgs e)
        {
            LogIn ln = new LogIn();
            this.Close();
            ln.Show();
        }
    }
}

       