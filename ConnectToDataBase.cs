using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace NutriApp
{
    class ConnectToDataBase
    {
        
        string[] paciente = { "@EstiloVidaID", "@Edad", "@FechaNacimiento", "@Fuma", "@Toma", "@Objetivo", "@Sexo" };
        string[] datosAnt = { "@Estatura", "@IMC", "@MedidaCadera", "@MedidaCintura", "@Peso" };
        string[] citas = { "@EstadoID", "@FechaCita", "@UsuarioID", "@PacienteID" };
        string connectionString;
        SqlConnection cnn;
        
        public void OpenConnection()
        {
            try
            {
                connectionString = @"Data Source=DESKTOP-1SFVU29;Initial Catalog=NutriApp;Integrated Security=True";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertData(string[]data,string[]columnsName)
        {
            SqlCommand cmd = new SqlCommand("sp_insertContacto", cnn);//crear stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            for(int i=0; i<data.Length; i++)
            {
                cmd.Parameters.AddWithValue(columnsName[i],data[i]);
            }

            int j = cmd.ExecuteNonQuery();

            cnn.Close();

            if (j != 0)
            {
                MessageBox.Show(j + "Registro Exitoso!");
            }
        }

        public void CloseConnection()
        {
            cnn.Close();
        }
    }
}
