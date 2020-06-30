using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmPacientes
{
    public partial class frmActualizacion : Form
    {
        public frmActualizacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Close();
            menu.Show();
        }
    }
}
