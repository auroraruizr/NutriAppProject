using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmConsultas
{
    public partial class frmAjustesAgenda : Form
    {
        public frmAjustesAgenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Close();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            frmConsultas.frmOpciones WmasOpciones = new frmConsultas.frmOpciones();
            WmasOpciones.ShowDialog();
        }
    }
}
