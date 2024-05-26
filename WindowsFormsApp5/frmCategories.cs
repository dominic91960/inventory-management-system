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
    public partial class frmCategories : Form
    {
        Categories bravoSix;
        private string user;
        private Boolean categoryIsValid = false;
        private Boolean descriptionIsVaild = false;

        public frmCategories(string user)
        {
            InitializeComponent();

            bravoSix = new Categories();

            refreshDGV();

            bravoSix.fillComboBox();
            txtNewName.Select();

            this.user = user;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                checkCategory();

                if (categoryIsValid == true)
                {
                    bravoSix.Name = cmbCategory.Text;
                    bravoSix.accessDatabase();
                    bravoSix.search();
                    txtDescription.Text_ = bravoSix.Description;
                }
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
                checkNewCategory();
                checkDescription();

                if (categoryIsValid == true && descriptionIsVaild == true)
                {
                    bravoSix.Name = txtNewName.Text_;
                    bravoSix.Description = txtDescription.Text_;
                    bravoSix.accessDatabase();
                    bravoSix.insert();
                    bravoSix.execute();

                    refreshDGV();
                    populateComboBox();
                    clearData();
                }
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
                checkCategory();
                checkDescription() ;

                if (categoryIsValid == true && descriptionIsVaild == true)
                {
                    if (txtNewName.Text_ == string.Empty)
                    {
                        txtNewName.Text_ = cmbCategory.Text;
                    }

                    bravoSix.Name = cmbCategory.Text;
                    bravoSix.NewName = txtNewName.Text_;
                    bravoSix.Description = txtDescription.Text_;
                    bravoSix.accessDatabase();
                    bravoSix.update();
                    bravoSix.execute();

                    refreshDGV();
                    populateComboBox();
                    clearData();
                }
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
                checkCategory() ;

                if (categoryIsValid == true)
                {
                    bravoSix.Name = cmbCategory.Text;
                    bravoSix.accessDatabase();
                    bravoSix.delete();
                    bravoSix.execute();

                    refreshDGV();
                    populateComboBox();
                    clearData();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProducts_Click(object sender, EventArgs e)
        {
            frmProducts one = new frmProducts(user);
            this.Close();
            one.Show();
        }

        private void txtEmployees_Click(object sender, EventArgs e)
        {
            if(user == "ADMIN")
            {
                frmEmployees two = new frmEmployees();
                this.Close();
                two.Show();
            }

            else
            {
                txtError.Show();
                txtNewName.Focus();
            }
        }
        

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategories_MouseHover(object sender, EventArgs e)
        {
            txtError.Hide();
        }

        private void txtCategory_Click(object sender, EventArgs e)
        {
            txtNewName.Focus();
        }

        private void dgvOne_SelectionChanged(object sender, EventArgs e)
        {
            dgvOne.CurrentCell = null;
        }

        private void cmbCategory_DropDown(object sender, EventArgs e)
        {
            populateComboBox();
        }

        private void checkCategory()
        {
            if(cmbCategory.Text == string.Empty)
            {
                MessageBox.Show("Please select a product category");
                categoryIsValid = false;
                cmbCategory.Focus();
            }

            else
            {
                categoryIsValid = true;
            }
        }

        private void checkNewCategory()
        {
            if(txtNewName.Text_ == string.Empty)
            {
                MessageBox.Show("Please enter a new category name");
                categoryIsValid = false;
                cmbCategory.Focus();
            }

            else
            {
                categoryIsValid = true;
            }
        }

        private void checkDescription()
        {
            if (txtDescription.Text_ == string.Empty)
            {
                MessageBox.Show("Please add a description");
                descriptionIsVaild = false;
                txtDescription.Focus();
            }

            else
            {
                descriptionIsVaild = true;
            }
        }


        private void refreshDGV()
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

        private void populateComboBox()
        {
            try
            {
                cmbCategory.Items.Clear();
                bravoSix.accessDatabase();
                bravoSix.fillComboBox();
                for (int i = 0; i < bravoSix.NameList.Length; i++)
                {
                    if (bravoSix.NameList[i] != null)
                    {
                        cmbCategory.Items.Add(bravoSix.NameList[i]);
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
            cmbCategory.Text = "";
            txtNewName.Text_ = "";
            txtDescription.Text_ = "";
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
