using OrderNow.Common.Data.Entities;
using System.Data;
using System.Data.SqlClient;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;

namespace OrderNow.Admin.DAL.Repositorios
{
    public static class RepositorioComercios
    {
        public static DataSet ObtenerTodos()
        {
            return Conexion.ObtenerTodos("Businesses");
        }

        public static void Relacionar(Guid comercioId, Guid usuarioId)
        {
            string commandText = $"INSERT INTO [dbo].[UsersBusinesses] " +
            $"([Id], [UsersId] ,[BusinessId] ,[Created] ,[LastModified] ) " +
            $"VALUES " +
            $"(@Id, @UsersId, @BusinessId,  @Created, @LastModified)";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@UsersId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@BusinessId", SqlDbType.UniqueIdentifier);

            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);

            command.Parameters["@Id"].Value = Guid.NewGuid();
            command.Parameters["@UsersId"].Value = usuarioId;
            command.Parameters["@BusinessId"].Value = comercioId;
            command.Parameters["@Created"].Value = DateTime.Now;
            command.Parameters["@LastModified"].Value = DateTime.Now;

            Conexion.ExecuteNonQuery(command);
        }

        public static int InsertarNuevoComercio(Businesses comercio, Guid usuario)
        {
            string commandText = $"INSERT INTO [dbo].[Businesses] " +
            $"([Id], [Name] ,[AddressId] ,[URLIconImage] ,[URLRegularImage] ,[ContractURL] ,[PromoMessage] ,[IsFrachise] ,[CUIT] ,[LegalName] ,[Phone] ,[IsValidated] ,[ValidationTime] ,[ValidationExpires] ,[Score] ,[Qualification]  ,[Created] ,[LastModified] ) " +
            $"VALUES " +
            $"(@Id, @Name, @AddressId, @URLIconImage, @URLRegularImage, @ContractURL, @PromoMessage, @IsFrachise, @CUIT, @LegalName, @Phone, @IsValidated, @ValidationTime, @ValidationExpires, @Score, @Qualification, @Created, @LastModified)";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@AddressId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@URLIconImage", SqlDbType.VarChar);
            command.Parameters.Add("@URLRegularImage", SqlDbType.VarChar);
            command.Parameters.Add("@ContractURL", SqlDbType.VarChar);
            command.Parameters.Add("@PromoMessage", SqlDbType.VarChar);
            command.Parameters.Add("@IsFrachise", SqlDbType.Bit);
            command.Parameters.Add("@CUIT", SqlDbType.VarChar);
            command.Parameters.Add("@LegalName", SqlDbType.VarChar);
            command.Parameters.Add("@Phone", SqlDbType.VarChar);
            command.Parameters.Add("@IsValidated", SqlDbType.Bit);
            command.Parameters.Add("@ValidationTime", SqlDbType.DateTime);
            command.Parameters.Add("@ValidationExpires", SqlDbType.DateTime);
            command.Parameters.Add("@Score", SqlDbType.Float);
            command.Parameters.Add("@Qualification", SqlDbType.Float);
            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);

            command.Parameters["@Id"].Value = comercio.Id;
            command.Parameters["@Name"].Value = comercio.Name;
            command.Parameters["@AddressId"].Value = comercio.Address?.Id;
            command.Parameters["@URLIconImage"].Value = comercio.URLIconImage;
            command.Parameters["@URLRegularImage"].Value = comercio.URLRegularImage;
            command.Parameters["@ContractURL"].Value = comercio.ContractURL;
            command.Parameters["@PromoMessage"].Value = comercio.PromoMessage;
            command.Parameters["@IsFrachise"].Value = comercio.IsFrachise;
            command.Parameters["@CUIT"].Value = comercio.CUIT;
            command.Parameters["@LegalName"].Value = comercio.LegalName;
            command.Parameters["@Phone"].Value = comercio.Phone;
            command.Parameters["@IsValidated"].Value = comercio.IsValidated;
            command.Parameters["@ValidationTime"].Value = comercio.ValidationTime;
            command.Parameters["@ValidationExpires"].Value = comercio.ValidationExpires;
            command.Parameters["@Score"].Value = comercio.Score;
            command.Parameters["@Qualification"].Value = comercio.Qualification;
            command.Parameters["@Created"].Value = comercio.Created;
            command.Parameters["@LastModified"].Value = comercio.LastModified;

            var i = Conexion.ExecuteNonQuery(command);
            Relacionar(comercio.Id, usuario);
            return i;
        }

        public static DataSet ObtenerListadoComercios()
        {
            string orden = $"SELECT " +
            $"b.Id, b.Name, a.Street, a.Number, a.Floor, a.Apartment, a.Tower, a.City, b.ContractURL, b.PromoMessage, b.IsFrachise, b.CUIT, b.LegalName, b.Phone, b.IsValidated, b.ValidationTime, b.ValidationExpires, b.Email, u.UserName, b.Created " +
            $"FROM Businesses b, Addresses a, AspNetUsers u " +
            $"WHERE b.AddressId = a.Id and b.UsersId = u.Id";
            DataSet ds = Conexion.ExecuteNonQueryWithData(orden);
            return ds;
        }

        public static Businesses ObtenerComercioPorURL(string ContractURL)
        {
            string orden = $"SELECT " +
            $"b.Id, b.Name, a.Street, a.Number, a.Floor, a.Apartment, a.Tower, a.City, b.ContractURL, b.PromoMessage, b.IsFrachise, b.CUIT, b.LegalName, b.Phone, b.IsValidated, b.ValidationTime, b.ValidationExpires, b.Email, u.UserName, b.Created " +
            $"FROM Businesses b, Addresses a, AspNetUsers u " +
            $"WHERE b.AddressId = a.Id and b.UsersId = u.Id and b.ContractURL = '{ContractURL}'";
            DataSet ds = Conexion.ExecuteNonQueryWithData(orden);
            Businesses business = null;
            foreach (DataRow p in ds.Tables[0].Rows)
            {
                business = new()
                {
                    Id = Guid.Parse(p.ItemArray[0].ToString()),
                    Name = p.ItemArray[1].ToString(),
                    ContractURL = p.ItemArray[8].ToString(),
                    PromoMessage = p.ItemArray[9].ToString(),
                    IsFrachise = Boolean.Parse(p.ItemArray[10].ToString()),
                    CUIT = p.ItemArray[11].ToString(),
                    LegalName = p.ItemArray[12].ToString(),
                    Phone = p.ItemArray[13].ToString(),
                    IsValidated = Boolean.Parse(p.ItemArray[14].ToString()),
                    ValidationTime = DateTime.Parse(p.ItemArray[15].ToString()),
                    ValidationExpires = DateTime.Parse(p.ItemArray[16].ToString()),
                    LastModified = DateTime.UtcNow
                };

                business.Address = new()
                {
                    Street = p.ItemArray[2].ToString(),
                    Number = p.ItemArray[3].ToString(),
                    Floor = p.ItemArray[4].ToString(),
                    Apartment = p.ItemArray[5].ToString(),
                    Tower = p.ItemArray[6].ToString(),
                    City = p.ItemArray[7].ToString(),
                };
            }
            return business;
        }

        public static int ActualizarComercio(Businesses business)
        {
            string commandText = $"UPDATE [dbo].[Businesses] " +
            $"SET " +
            $"[Name] = @Name," +
            $"[URLIconImage] = @URLIconImage," +
            $"[URLRegularImage] = @URLRegularImage," +
            $"[ContractURL] = @ContractURL," +
            $"[PromoMessage] = @PromoMessage," +
            $"[IsFrachise] = @IsFrachise," +
            $"[CUIT] = @CUIT," +
            $"[LegalName] = @LegalName," +
            $"[Phone] = @Phone," +
            $"[IsValidated] = @IsValidated," +
            $"[ValidationTime] = @ValidationTime," +
            $"[ValidationExpires] = @ValidationExpires," +
            $"[LastModified] = @LastModified" +
            $" WHERE Id ='{business.Id}';";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@URLRegularImage", SqlDbType.VarChar);
            command.Parameters.Add("@URLIconImage", SqlDbType.VarChar);
            command.Parameters.Add("@ContractURL", SqlDbType.VarChar);
            command.Parameters.Add("@PromoMessage", SqlDbType.VarChar);
            command.Parameters.Add("@IsFrachise", SqlDbType.Bit);
            command.Parameters.Add("@CUIT", SqlDbType.VarChar);
            command.Parameters.Add("@LegalName", SqlDbType.VarChar);
            command.Parameters.Add("@Phone", SqlDbType.VarChar);
            command.Parameters.Add("@IsValidated", SqlDbType.Bit);
            command.Parameters.Add("@ValidationTime", SqlDbType.DateTime);
            command.Parameters.Add("@ValidationExpires", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);

            command.Parameters["@Name"].Value = business.Name;
            command.Parameters["@URLRegularImage"].Value = business.URLRegularImage;
            command.Parameters["@URLIconImage"].Value = business.URLIconImage;
            command.Parameters["@ContractURL"].Value = business.ContractURL;
            command.Parameters["@PromoMessage"].Value = business.PromoMessage;
            command.Parameters["@IsFrachise"].Value = business.IsFrachise;
            command.Parameters["@CUIT"].Value = business.CUIT;
            command.Parameters["@LegalName"].Value = business.LegalName;
            command.Parameters["@Phone"].Value = business.Phone;
            command.Parameters["@IsValidated"].Value = business.IsValidated;
            command.Parameters["@ValidationTime"].Value = business.ValidationTime.ToUniversalTime();
            command.Parameters["@ValidationExpires"].Value = business.ValidationExpires.ToUniversalTime();
            command.Parameters["@LastModified"].Value = business.LastModified;

            return Conexion.ExecuteNonQuery(command);
        }
    }
}