using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmLogin : Form
    {
        //This variable will be used to prevent employees from accessing critical information
        private string user;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Text_ = "";
            lblUsernameError.Text = "";
            txtUsername.BorderColor = Color.DimGray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text_ = "";
            lblPasswordError.Text = "";
            txtPassword.BorderColor = Color.DimGray;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkNull();
        }

        private void checkNull()
        {
            if (txtUsername.Text_ == string.Empty)
            {
                txtUsername.BorderColor = Color.DarkOrange;
                lblUsernameError.ForeColor = Color.DarkOrange;
                lblUsernameError.Text = "USERNAME CAN'T BE EMPTY";
            }

            if (txtPassword.Text_ == string.Empty)
            {
                txtPassword.BorderColor = Color.DarkOrange;
                lblPasswordError.ForeColor = Color.DarkOrange;
                lblPasswordError.Text = "PASSWORD CAN'T BE EMPTY";
            }

            if (txtUsername.Text_ != string.Empty && txtPassword.Text_ != string.Empty)
            {
                checkRole();
            }
        }

        private void checkRole()
        {
            if (cmbRole.Text == "ADMIN")
            {
                user = "ADMIN";
                checkData("admin","root");
            }
            else if (cmbRole.Text == "EMPLOYEE")
            {
                user = "EMPLOYEE";
                checkData("employee","0000");
            }
            else
            {
                cmbRole.ForeColor = Color.Red;
                cmbRole.Text = "PLEASE SELECT A ROLE";
            }
        } 
        private void checkData(string username,string password)
        {
            if (txtUsername.Text_ != username)
            {
                txtUsername.BorderColor = Color.Red;
                lblUsernameError.ForeColor = Color.Red;
                lblUsernameError.Text = "INCORRECT USERNAME";
            }

            if (txtPassword.Text_ != password)
            {
                txtPassword.BorderColor = Color.Red;
                lblPasswordError.ForeColor = Color.Red;
                lblPasswordError.Text = "INCORRECT PASSWORD";
            }

            if (txtUsername.Text_ == username && txtPassword.Text_ == password)
            {
                frmLoading loading = new frmLoading(user);
                loading.Show();
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmbRole_Click(object sender, EventArgs e)
        {
            cmbRole.ForeColor = Color.White;
        }
    }
}
