using OrderNow.Admin.DAL;
using System.Data;

namespace OrderNow.Admin.Forms
{
    internal class RepositorioUsuarios
    {
        public RepositorioUsuarios()
        {
        }

        public DataSet ObtenerTodos()
        {
            return Conexion.ObtenerTodos("AspNetUsers");
        }

    }
}