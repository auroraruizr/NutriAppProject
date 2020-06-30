using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NutriApp
{
    class ConnectToDataBase
    {
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

        public void CloseConnection()
        {
            cnn.Close();
        }
    }
}
