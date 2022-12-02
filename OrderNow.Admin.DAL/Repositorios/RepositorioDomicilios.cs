using OrderNow.Common.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNow.Admin.DAL.Repositorios
{
    public static class RepositorioDomicilios
    {
        public static DataSet ObtenerTodos()
        {
            return Conexion.ObtenerTodos("Addresses");
        }

        public static int InsertarNuevo(Addresses domicilio)
        {
            string commandText = $" INSERT INTO [dbo].[Addresses] ([Id] ,[Street] ,[Number] ,[Floor] ,[Apartment] ,[Tower] ,[City] ,[Observations] ,[Created] ,[LastModified] ) " +
                $"VALUES " +
                $"( @Id, @Street, @Number, @Floor, @Apartment, @Tower, @City, @Observations, @Created, @LastModified )";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Street", SqlDbType.VarChar);
            command.Parameters.Add("@Number", SqlDbType.VarChar);
            command.Parameters.Add("@Floor", SqlDbType.VarChar);
            command.Parameters.Add("@Apartment", SqlDbType.VarChar);
            command.Parameters.Add("@Tower", SqlDbType.VarChar);
            command.Parameters.Add("@City", SqlDbType.VarChar);
            command.Parameters.Add("@Observations", SqlDbType.VarChar);
            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);

            command.Parameters["@Id"].Value = domicilio.Id;
            command.Parameters["@Street"].Value = domicilio.Street;
            command.Parameters["@Number"].Value = domicilio.Number;
            command.Parameters["@Floor"].Value = domicilio.Floor;
            command.Parameters["@Apartment"].Value = domicilio.Apartment;
            command.Parameters["@Tower"].Value = domicilio.Tower;
            command.Parameters["@City"].Value = domicilio.City;
            command.Parameters["@Observations"].Value = domicilio.Observations;
            command.Parameters["@Created"].Value = domicilio.Created;
            command.Parameters["@LastModified"].Value = domicilio.LastModified;

            return Conexion.ExecuteNonQuery(command);
        }
    }
}