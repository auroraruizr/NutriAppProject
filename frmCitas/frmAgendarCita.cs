using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmCitas
{
    public partial class frmAgendarCita : Form
    {
        frmMenu Wmenu = new frmMenu();

        public frmAgendarCita()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wmenu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmContactos.frmListaContactos Wlista = new frmContactos.frmListaContactos();
            Wlista.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wmenu.Show();
        }
    }
}
