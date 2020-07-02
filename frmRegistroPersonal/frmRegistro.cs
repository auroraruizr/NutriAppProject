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

namespace NutriApp.frmRegistroPersonal
{
    public partial class frmRegistro : Form
    {
        frmMenu Wmenu = new frmMenu();
        string connetionString;
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmRegistro()
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-1SFVU29;Initial Catalog=NutriApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Wmenu.Show();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            if (rdbNutriologa.Checked == true)
            {
                UserID = 3;
            }
            else if (rdbRecepcionista.Checked == true)
            {
                UserID = 2;
            }
            cnn.Open();
            SqlCommand cmd = new SqlCommand("sp_insert", cnn);//crear stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", txtID.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@tipousuarioid", UserID);
            cmd.Parameters.AddWithValue("@apellido", "");
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTRelefono.Text);

            int i = cmd.ExecuteNonQuery();

            cnn.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Registro Exitoso!");
            }
            //this.Hide();
        }
    }
}
