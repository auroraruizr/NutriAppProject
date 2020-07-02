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

namespace NutriApp.Login
{
    public partial class frmLogin : Form
    {
        string connetionString;
        ConnectToDataBase cnxON = new ConnectToDataBase();
        SqlConnection cnn;
        public frmLogin()
        {
            InitializeComponent();

            connetionString = @"Data Source=DESKTOP-1SFVU29;Initial Catalog=NutriApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnn.Open();

            string list = "select * from Usuarios where NombreUsuario='"+txtUsuario.Text+"';";
           
            SqlDataAdapter dataadapter = new SqlDataAdapter(list, cnn);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "Usuarios");
            if (  ds.Tables[0].Rows.Count>0)
            {
            if (txtPassword.Text == ds.Tables[0].Rows[0]["Contraseña"].ToString())
                        {
                            MessageBox.Show("Bienvenido!");
                        }
            else
                        {
                            MessageBox.Show("Intent más tarde");
                        }
            }
            else
            {
                MessageBox.Show("Intent más tarde");
            }
            cnn.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
