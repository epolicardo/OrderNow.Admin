using System.Data;
using System.Data.SqlClient;

namespace OrderNow.Admin.DAL
{
    public static class Conexion
    {
        public static SqlConnection conexion;
        public const string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = OrderNow; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public static void AbrirConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
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

        public static void CerrarConexion()
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

        public static int ExecuteNonQuery(SqlCommand command)
        {
            try
            {

                AbrirConexion();
                command.Connection = conexion;
                int resultado = command.ExecuteNonQuery();
                conexion.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static DataSet ObtenerTodos(string tipo)
        {
            string orden = $"select * from {tipo};";

            SqlCommand command = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                command.Connection = conexion;
                command.ExecuteNonQuery();
                da.SelectCommand = command;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener registros", e);
            }
            finally
            {
                conexion.Close();
                command.Dispose();
            }
            return ds;
        }


    }
}
