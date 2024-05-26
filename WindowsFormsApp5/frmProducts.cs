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
    public partial class frmProducts : Form
    {
        Categories obj;
        Products bravoSix;

        private string user;

        public frmProducts(string user)
        {
            InitializeComponent();
            obj = new Categories();
            bravoSix = new Products();

            populateDGV();

            txtId.Select();
            this.user = user;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void cmbRole_DropDown(object sender, EventArgs e)
        {
            populateComboBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Id = Convert.ToInt32(txtId.Text_);
                bravoSix.accessDatabase();
                bravoSix.search();
                txtName.Text_ = bravoSix.Name;
                cmbCategory.Text = bravoSix.Category;
                txtPrice.Text_ = bravoSix.Price.ToString();
                txtQuantity.Text_ = bravoSix.Quantity;
                txtDescription.Text_ = bravoSix.Description;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Name = txtName.Text_;
                bravoSix.Category = cmbCategory.Text;
                bravoSix.Price = Convert.ToDouble(txtPrice.Text_);
                bravoSix.Quantity = txtQuantity.Text_;
                bravoSix.Description = txtDescription.Text_;

                bravoSix.accessDatabase();
                bravoSix.insert();
                bravoSix.execute();

                populateDGV();
                populateComboBox();
                clearData();
            }

            catch( Exception ex )
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
                populateComboBox();
                clearData();
            }

            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bravoSix.Name = txtName.Text_;
                bravoSix.Category = cmbCategory.Text;
                bravoSix.Price = Convert.ToDouble(txtPrice.Text_);
                bravoSix.Quantity = txtQuantity.Text_;
                bravoSix.Description = txtDescription.Text_;

                bravoSix.accessDatabase();
                bravoSix.update();
                bravoSix.execute();

                populateDGV();
                populateComboBox();
                clearData();
            }

            catch( Exception ex)
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

            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateComboBox()
        {
            try
            {
                cmbCategory.Items.Clear();
                obj.accessDatabase();
                obj.fillComboBox();
                for (int i = 0; i < obj.NameList.Length; i++)
                {
                    if (obj.NameList[i] != null)
                    {
                        cmbCategory.Items.Add(obj.NameList[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearData()
        {
            cmbCategory.Items.Clear();
            txtName.Text_ = "";
            cmbCategory.Text = "";
            txtPrice.Text_ = "";
            txtQuantity.Text_ = "";
            txtDescription.Text_ = "";

        }

        private void txtEmployees_MouseClick(object sender, MouseEventArgs e)
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
                txtId.Focus();
            }
        }

        private void frmProducts_MouseHover(object sender, EventArgs e)
        {
            txtError.Hide();
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            frmCategories one = new frmCategories(user);
            this.Close();
            one.Show();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProducts_Click(object sender, EventArgs e)
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
            dgvOne.Height = dgvOne.RowCount * dgvOne.RowTemplate.Height * 2;

            Bitmap imagebmp = new Bitmap(1200, 720);
            dgvOne.DrawToBitmap(imagebmp, new Rectangle(0, 0, 1200, 720));

            dgvOne.Height = height;
            e.Graphics.DrawImage(imagebmp, 0, 0);
        }
    }
}
