using OrderNow.Common.Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace OrderNow.Admin.DAL
{
    public static class Conexion
    {
        public static SqlConnection conexion;


        public const string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = OrderNow; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //public const string cadenaConexion = "Server=tcp:ordernowdbserver.database.windows.net,1433;Initial Catalog=OrderNow-API;Persist Security Info=False;User ID=epolicardo;Password=Em1Li4No;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


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

        public static DataSet ExecuteNonQueryWithData(string orden)
        {
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
            catch (Exception ex)
            {
                throw new Exception("Error al obtener registros", ex);
            }
            finally
            {
                conexion.Close();
                command.Dispose();
            }
            return ds;
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
                var a = "Error al obtener registros";
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
