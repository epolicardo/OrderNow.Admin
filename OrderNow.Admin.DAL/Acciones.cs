using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderNow.Common.Data.Entities;

namespace OrderNow.Admin.DAL
{
    public static class Acciones 
    {




        //public Products ObtenerUno(Guid Id, string tipo)
        //{
        //    Products products = new Products();
        //    return products;
        //}


        //public DataSet EditarPorId(Guid Id, string tipo)
        //{
        //    string orden = $"UPDATE {tipo} SET ({0}) VALUES {1} WHERE Id={Id};";

        //    SqlCommand command = new SqlCommand(orden, conexion);
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    try
        //    {
        //        AbrirConexion();
        //        command.ExecuteReader();
        //        da.SelectCommand = command;
        //        da.Fill(ds);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception("Error al listar Alumnos", e);
        //    }
        //    finally
        //    {
        //        CerrarConexion();
        //        command.Dispose();
        //    }
        //    return ds;
        //}


    }
}
