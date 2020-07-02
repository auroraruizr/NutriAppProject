using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NutriApp.frmContactos
{
    public partial class frmListaContactos : Form
    {
        string connetionString;
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        frmCitas.frmAgendarCita Wagendar = new frmCitas.frmAgendarCita();
        public frmListaContactos()
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-1SFVU29;Initial Catalog=NutriApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
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
            string cel1 = lstListado.CurrentCell.RowIndex.ToString();
            int row = int.Parse(cel1);
            var s = lstListado.Rows[row].Cells[0].Value;
            var t = lstListado.Rows[row].Cells[1].Value;
            var u = lstListado.Rows[row].Cells[2].Value;
            var v = lstListado.Rows[row].Cells[3].Value;
            MessageBox.Show(s.ToString() + t.ToString() + u.ToString() + v.ToString());

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string Nombre = txtNombre.Text;
            string list = "select Nombre, Apellidos,Correo,Telefono from Usuarios where NombreUsuario LIKE '" + Nombre + "%';";
            SqlDataAdapter dataadapter = new SqlDataAdapter(list, cnn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Usuarios");
            lstListado.DataSource = ds.Tables[0];// Columns[0];
            lstListado.Columns[0].HeaderText = "Nombre";
            lstListado.Columns[1].HeaderText = "Apellido";
            lstListado.Columns[2].HeaderText = "Correo";
            lstListado.Columns[3].HeaderText = "Telefono";
            cnn.Close();//**/
        }
    }
}
