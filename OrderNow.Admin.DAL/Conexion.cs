using System.Data;
using System.Data.SqlClient;

namespace OrderNow.Admin.DAL
{
    public class Conexion
    {
        public SqlConnection conexion;
        public string cadenaconex = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = OrderNow; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Conexion()
        {
            conexion = new SqlConnection(cadenaconex);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }


    }
}
