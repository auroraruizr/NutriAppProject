using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.Login
{
    public partial class frmLogin : Form
    {
        frmMenu Wmenu = new frmMenu();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wmenu.Show();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Wmenu.Show();
        }
    }
}
