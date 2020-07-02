using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp
{
    public partial class frmMenu : Form
    {
        ConnectToDataBase cnxON = new ConnectToDataBase();
        public frmMenu()
        {
            InitializeComponent();
            cnxON.OpenConnection();
            
        }

        private void asistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Login.frmLogin Wlogin = new Login.frmLogin();
            this.Hide();
            Wlogin.Show();
        }

        private void asistenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroPersonal.frmRegistro Wregistrar = new frmRegistroPersonal.frmRegistro();
            this.Hide();
            Wregistrar.Show();       
        }

        private void agendarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas.frmAgendarCita Wagendar = new frmCitas.frmAgendarCita();
            this.Hide();
            Wagendar.Show();
        }

        private void proximasCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas.frmProximaCita WcitasList = new frmCitas.frmProximaCita();
            this.Hide();
            WcitasList.Show();
        }

        private void cancelarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas.frmCancelarCitas Wcancelar = new frmCitas.frmCancelarCitas();
            this.Hide();
            Wcancelar.Show();
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes.frmNuevoPaciente WaltaPac = new frmPacientes.frmNuevoPaciente();
            this.Hide();
            WaltaPac.Show();
        }

        private void listaContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos.frmListaContactos WlistCont = new frmContactos.frmListaContactos();            
            WlistCont.ShowDialog();
        }

        private void nuevoContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos.frmAltaContacto WaltaCont = new frmContactos.frmAltaContacto();
            this.Hide();
            WaltaCont.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes.frmActualizacion WactPac = new frmPacientes.frmActualizacion();
            this.Hide();
            WactPac.Show();
        }

        private void progresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes.Form1 Wprogress = new frmPacientes.Form1();
            this.Hide();
            Wprogress.ShowDialog();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes.frmArchivoPaciente WarchivoPac = new frmPacientes.frmArchivoPaciente();          
            WarchivoPac.ShowDialog();
        }

        private void salirDeNutriAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajusteDeAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas.frmAjustesAgenda Wajustes = new frmConsultas.frmAjustesAgenda();
            Wajustes.ShowDialog();
        }
    }
}
