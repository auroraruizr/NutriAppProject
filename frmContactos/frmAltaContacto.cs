using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriApp.frmContactos
{
    public partial class frmAltaContacto : Form 
    {
       
        ConnectToDataBase cnx = new ConnectToDataBase();
  
        frmMenu menu = new frmMenu();
        string[] data_contact = new string[4];
        string[] columns_contacts = { "@Nombre", "@Apellido", "@Telefono", "@Email" };



        public frmAltaContacto()
        {
            InitializeComponent();
            cnx.OpenConnection();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
            menu.Show();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("sp_insert", cnn);//crear stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;
            ////tabla pacient
            data_contact[0] = txtContacto.Text;
            data_contact[1] = txtDireccion.Text;
            data_contact[2] = txtEmail.Text;
            data_contact[3] = txtTelefono.Text;

            cnx.InsertData(data_contact,columns_contacts);
            MessageBox.Show("Contacto guardado correctamente.");
            this.Hide();
            menu.Show();       
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
