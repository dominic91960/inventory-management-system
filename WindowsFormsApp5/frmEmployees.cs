using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmEmployees : Form
    {
        Employees bravoSix;
        private string user = "ADMIN";

        public frmEmployees()
        {
            InitializeComponent();
            bravoSix = new Employees();

            populateDGV();

            txtId.Select();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Id = Convert.ToInt32(txtId.Text_);
                bravoSix.accessDatabase();
                bravoSix.search();
                txtName.Text_ = bravoSix.Name;
                txtAddress.Text_ = bravoSix.Address;
                txtAge.Text_ = bravoSix.Age.ToString();
                txtPosition.Text_ = bravoSix.Position;
                txtSalary.Text_ = bravoSix.Salary.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Name = txtName.Text_;
                bravoSix.Address = txtAddress.Text_;
                bravoSix.Age = Convert.ToInt32(txtAge.Text_);
                bravoSix.Position = txtPosition.Text_;
                bravoSix.Salary = Convert.ToDouble(txtSalary.Text_);

                bravoSix.accessDatabase();
                bravoSix.insert();
                bravoSix.execute();

                populateDGV();
                clearData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Id = Convert.ToInt32(txtId.Text_);
                bravoSix.accessDatabase();
                bravoSix.delete();
                bravoSix.execute();

                populateDGV();
                clearData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Name = txtName.Text_;
                bravoSix.Address = txtAddress.Text_;
                bravoSix.Age = Convert.ToInt32(txtAge.Text_);
                bravoSix.Position = txtPosition.Text_;
                bravoSix.Salary = Convert.ToDouble(txtSalary.Text_);

                bravoSix.accessDatabase();
                bravoSix.update();
                bravoSix.execute();

                populateDGV();
                clearData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateDGV()
        {
            try
            {
                bravoSix.accessDatabase();
                bravoSix.fillDataGridView();
                dgvOne.DataSource = bravoSix.dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearData()
        {
            txtName.Text_="";
            txtAddress.Text_ = "";
            txtAge.Text_ = "";
            txtPosition.Text_ = "";
            txtSalary.Text_ = "";
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            frmCategories one = new frmCategories(user);
            this.Close();
            one.Show();
        }

        private void txtProducts_Click(object sender, EventArgs e)
        {
            frmProducts one = new frmProducts(user);
            this.Close();
            one.Show();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmployees_Click(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void dgvOne_SelectionChanged(object sender, EventArgs e)
        {
            dgvOne.CurrentCell = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocOne.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("x", 1200, 720);

            printPDOne.Document = printDocOne;
            printPDOne.PrintPreviewControl.Zoom = 1;
            printPDOne.ShowDialog();
        }

        private void printDocOne_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvOne.Height;
            dgvOne.Height = dgvOne.RowCount*dgvOne.RowTemplate.Height*2;

            Bitmap imagebmp = new Bitmap(1200, 720);
            dgvOne.DrawToBitmap(imagebmp, new Rectangle(0,0,1200, 720));

            dgvOne.Height = height;
            e.Graphics.DrawImage(imagebmp,0,0);
        }

        private void frmEmployees_SizeChanged(object sender, EventArgs e)
        {/*
            MessageBox.Show(dgvOne.Width.ToString());
            MessageBox.Show(dgvOne.Height.ToString());*/
        }
    }
}
