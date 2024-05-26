using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            tmrOne.Start();
        }

        private void tmrOne_Tick(object sender, EventArgs e)
        {
            pnlLoading.Width += 1;

            if(pnlLoading.Width <= 300) {
                pnlLoading.Width += 1;
            }
            else if (pnlLoading.Width <= 500)
            {
                pnlLoading.Width += 2;
            }
            else if (pnlLoading.Width <= 800)
            {
                pnlLoading.Width += 5;
            }
            else
            {
                tmrOne.Stop();
                frmLogin login = new frmLogin();
                this.Hide();
                login.Show();
            }
            
        }
    }
}
