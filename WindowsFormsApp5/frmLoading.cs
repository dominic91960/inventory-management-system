using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmLoading : Form
    {
        private int cycle;
        private string user;

        public frmLoading(string user)
        {
            InitializeComponent();
            tmrOne.Enabled = true;
            cpbOne.Value = 0;

            this.user = user;
        }

        private void tmrOne_Tick(object sender, EventArgs e)
        {
            if (cpbOne.Value < 50)
            {
                cpbOne.Value += 1;
                cpbOne.Text = cpbOne.Value.ToString() + "%";
            }

            else if (cpbOne.Value < 100)
            {
                cpbOne.Value += 2;
                cpbOne.Text = cpbOne.Value.ToString() + "%";
                lblLoading.Text = "A L M O S T  T H E R E . . .";
            }
            
            else
            {
                cycle++; 

                lblLoading.Text = "D O N E";
                
                if (cycle == 15)
                {
                    tmrOne.Enabled = false;

                    frmWelcome welcome = new frmWelcome(user);
                    welcome.Show();
                    this.Close();
                }
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }
    }
}