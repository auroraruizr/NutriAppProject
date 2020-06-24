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
        SqlConnection cnn;
        public frmLogin()
        {
            InitializeComponent();
            connetionString = @"Data Source=DESKTOP-1SFVU29;Initial Catalog=NutriApp;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("sp_insert", cnn);//crear stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@tipousuarioid", 1);
            cmd.Parameters.AddWithValue("@apellido", "Ruiz Rueda");
            cmd.Parameters.AddWithValue("@nombre", "Aurora");


            int i = cmd.ExecuteNonQuery();

            cnn.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }
    }
}
