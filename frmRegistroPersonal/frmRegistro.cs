using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmRegistroPersonal
{
    public partial class frmRegistro : Form
    {
        frmMenu Wmenu = new frmMenu();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Wmenu.Show();
            
        }
    }
}
