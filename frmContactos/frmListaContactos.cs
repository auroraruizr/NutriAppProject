using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmContactos
{
    public partial class frmListaContactos : Form
    {
        frmCitas.frmAgendarCita Wagendar = new frmCitas.frmAgendarCita();
        public frmListaContactos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //condicion1:devuelta a la forma *frmAgendarCita*
            this.Close();
            //condicion2:para regresar a menu**
            
        }

        private void lstListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando se le de doble click sobre un contacto dentro del datagridview, la informacion
            //se deberá imprimir en la forma *frmAgendarCita*
        }
    }
}
