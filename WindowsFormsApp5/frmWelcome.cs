using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp5
{
    public partial class frmWelcome : Form
    {
        private string user;

        public frmWelcome(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void lblCategories_MouseHover(object sender, EventArgs e)
        {
            lblCategories.ForeColor = Color.Yellow;
            txtError.Hide();
        }

        private void lblProducts_MouseHover(object sender, EventArgs e)
        {
            lblProducts.ForeColor = Color.Yellow;
            txtError.Hide();
        }

        private void lblEmployees_MouseHover(object sender, EventArgs e)
        {
            lblEmployees.ForeColor = Color.Yellow;
            txtError.Hide();
        }

        private void lblCategories_MouseLeave(object sender, EventArgs e)
        {
            lblCategories.ForeColor = Color.DarkGray;
        }

        private void lblProducts_MouseLeave(object sender, EventArgs e)
        {
            lblProducts.ForeColor = Color.DarkGray;
        }

        private void lblEmployees_MouseLeave(object sender, EventArgs e)
        {
            lblEmployees.ForeColor = Color.DarkGray;
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {
            frmCategories one = new frmCategories(user);
            this.Close();
            one.Show();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            frmProducts one = new frmProducts(user);
            this.Close(); 
            one.Show();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            if (user == "ADMIN")
            {
                frmEmployees one = new frmEmployees();
                this.Close();
                one.Show();
            }

            else
            {
                txtError.Show();
            }
        }
    }
}
