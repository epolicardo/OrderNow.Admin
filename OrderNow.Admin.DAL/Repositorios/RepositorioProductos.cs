using Microsoft.VisualBasic;
using OrderNow.Common.Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace OrderNow.Admin.DAL.Repositorios
{
    public static class RepositorioProductos
    {

        public static int AltaProducto(Products product, Guid userId)
        {
            string commandText = "";
            if (product.HasRecipe)
            {

                commandText = $"INSERT INTO [dbo].[Products] " +
                    $"([Id],[Code], [EAN], [Name], [LegalName], [Description], [URLImage], [URLIcon], [Price], [Stock], [Status], [BusinessId], [CategoryId], [Score], [Qualifications], [Brand], [IsSelleable], [UsersId], [Created], [LastModified], [IsSuggested], [HasRecipe], [RecipeId]) " +
                    $"VALUES " +
                    $"(@Id, @Code, @EAN,  @Name, @LegalName, @Description, @URLImage, @URLIcon, @Price, @Stock, @Status, @BusinessId, @CategoryId, @Score, @Qualifications, @Brand, @IsSelleable, @UsersId, @Created, @LastModified, @IsSuggested, @HasRecipe, @RecipeId)";

            }
            else
            {
                commandText = $"INSERT INTO [dbo].[Products] " +
                   $"([Id],[Code], [EAN], [Name], [LegalName], [Description], [URLImage], [URLIcon], [Price], [Stock], [Status], [BusinessId], [CategoryId], [Score], [Qualifications], [Brand], [IsSelleable], [UsersId], [Created], [LastModified], [IsSuggested], [HasRecipe])" +
                   $"VALUES " +
                   $"(@Id, @Code, @EAN,  @Name, @LegalName, @Description, @URLImage, @URLIcon, @Price, @Stock, @Status, @BusinessId, @CategoryId, @Score, @Qualifications, @Brand, @IsSelleable, @UsersId, @Created, @LastModified, @IsSuggested, @HasRecipe)";

            }

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Code", SqlDbType.VarChar);
            command.Parameters.Add("@EAN", SqlDbType.VarChar);
            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@LegalName", SqlDbType.VarChar);
            command.Parameters.Add("@Description", SqlDbType.VarChar);
            command.Parameters.Add("@URLImage", SqlDbType.VarChar);
            command.Parameters.Add("@URLIcon", SqlDbType.VarChar);
            command.Parameters.Add("@Price", SqlDbType.Float);
            command.Parameters.Add("@Stock", SqlDbType.Float);
            command.Parameters.Add("@Status", SqlDbType.Bit);
            command.Parameters.Add("@BusinessId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@CategoryId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Score", SqlDbType.Float);
            command.Parameters.Add("@Qualifications", SqlDbType.BigInt);
            command.Parameters.Add("@Brand", SqlDbType.VarChar);
            command.Parameters.Add("@IsSelleable", SqlDbType.Bit);
            command.Parameters.Add("@UsersId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);
            command.Parameters.Add("@IsSuggested", SqlDbType.Bit);
            command.Parameters.Add("@HasRecipe", SqlDbType.Bit);
            if (product.HasRecipe)
            {

                command.Parameters.Add("@RecipeId", SqlDbType.UniqueIdentifier);
            }


            command.Parameters["@ID"].Value = product.Id;
            command.Parameters["@Code"].Value = product.Code;
            command.Parameters["@EAN"].Value = product.EAN;
            command.Parameters["@Name"].Value = product.Name;
            command.Parameters["@LegalName"].Value = product.LegalName;
            command.Parameters["@Description"].Value = product.Description;
            command.Parameters["@URLImage"].Value = product.URLImage;
            command.Parameters["@URLIcon"].Value = product.URLIcon;
            command.Parameters["@Price"].Value = product.Price;
            command.Parameters["@Stock"].Value = product.Stock;
            command.Parameters["@Status"].Value = product.Status;
            command.Parameters["@BusinessId"].Value = product.Business?.Id;
            command.Parameters["@CategoryId"].Value = product.Category?.Id;
            command.Parameters["@Score"].Value = product.Score;
            command.Parameters["@Qualifications"].Value = product.Qualifications;
            command.Parameters["@Brand"].Value = product.Brand;
            command.Parameters["@IsSelleable"].Value = product.IsSelleable;
            command.Parameters["@UsersId"].Value = userId;
            command.Parameters["@Created"].Value = product.Created.ToUniversalTime();
            command.Parameters["@LastModified"].Value = product.LastModified.ToUniversalTime();
            command.Parameters["@IsSuggested"].Value = product.IsSuggested;
            command.Parameters["@HasRecipe"].Value = product.HasRecipe;
            if (product.HasRecipe)
            {
                command.Parameters["@RecipeId"].Value = product.Recipe?.Id;
            }


            return Conexion.ExecuteNonQuery(command);

        }

        public static int ModificarProducto(Products product)
        {

            string commandText = $"UPDATE [dbo].[Products] SET " +
                $"[Id]= @Id," +
                $"[Code]= @Code," +
                $"[EAN]= @EAN," +
                $"[Name]= @Name," +
                $"[LegalName]= @LegalName," +
                $"[Description]= @Description," +
                $"[URLImage]= @URLImage," +
                $"[URLIcon]= @URLIcon," +
                $"[Price]= @Price," +
                $"[Stock]= @Stock," +
                $"[Status]= @Status," +
                $"[BusinessId]= @BusinessId," +
                $"[CategoryId]= @CategoryId," +
                $"[Score]= @Score," +
                $"[Qualifications]= @Qualifications," +
                $"[Brand]= @Brand," +
                $"[IsSelleable]= @IsSelleable," +
                $"[UsersId]= @userId," +
                $"[Created]= @CreatedAt," +
                $"[LastModified]= @ModifiedAt," +
                $"[IsSuggested]= @IsSuggested," +
                $"[HasRecipe]= @HasRecipe," +
                $"[RecipeId] = @RecipeId;" +
                $"WHERE productId ='{product.Id}';";


            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Code", SqlDbType.VarChar);
            command.Parameters.Add("@EAN", SqlDbType.VarChar);
            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@LegalName", SqlDbType.VarChar);
            command.Parameters.Add("@Description", SqlDbType.VarChar);
            command.Parameters.Add("@URLImage", SqlDbType.VarChar);
            command.Parameters.Add("@URLIcon", SqlDbType.VarChar);
            command.Parameters.Add("@Price", SqlDbType.Float);
            command.Parameters.Add("@Stock", SqlDbType.Float);
            command.Parameters.Add("@Status", SqlDbType.Bit);
            command.Parameters.Add("@BusinessId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@CategoryId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Score", SqlDbType.Float);
            command.Parameters.Add("@Qualifications", SqlDbType.BigInt);
            command.Parameters.Add("@Brand", SqlDbType.VarChar);
            command.Parameters.Add("@IsSelleable", SqlDbType.Bit);
            command.Parameters.Add("@UsersId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@CreatedAt", SqlDbType.DateTime);
            command.Parameters.Add("@ModifiedAt", SqlDbType.DateTime);
            command.Parameters.Add("@IsSuggested", SqlDbType.Bit);
            command.Parameters.Add("@HasRecipe", SqlDbType.Bit);
            command.Parameters.Add("@RecipeId", SqlDbType.UniqueIdentifier);


            command.Parameters["@ID"].Value = product.Id;
            command.Parameters["@Code"].Value = product.Code;
            command.Parameters["@EAN"].Value = product.EAN;
            command.Parameters["@Name"].Value = product.Name;
            command.Parameters["@LegalName"].Value = product.LegalName;
            command.Parameters["@Description"].Value = product.Description;
            command.Parameters["@URLImage"].Value = product.URLImage;
            command.Parameters["@URLIcon"].Value = product.URLIcon;
            command.Parameters["@Price"].Value = product.Price;
            command.Parameters["@Stock"].Value = product.Stock;
            command.Parameters["@Status"].Value = product.Status;
            command.Parameters["@BusinessId"].Value = product.Business?.Id;
            command.Parameters["@CategoryId"].Value = product.Category?.Id;
            command.Parameters["@Score"].Value = product.Score;
            command.Parameters["@Qualifications"].Value = product.Qualifications;
            command.Parameters["@Brand"].Value = product.Brand;
            command.Parameters["@IsSelleable"].Value = product.IsSelleable;
            command.Parameters["@UsersId"].Value = Guid.Parse("7ef3c3cb-295b-48e3-8ae1-72b35cf56820");
            command.Parameters["@CreatedAt"].Value = product.Created.ToUniversalTime();
            command.Parameters["@ModifiedAt"].Value = product.LastModified.ToUniversalTime();
            command.Parameters["@IsSuggested"].Value = product.IsSuggested;
            command.Parameters["@HasRecipe"].Value = product.HasRecipe;
            command.Parameters["@RecipeId"].Value = product.Recipe.Id;

            return Conexion.ExecuteNonQuery(command);

        }

        public static List<Products> ObtenerProductos()
        {
            DataSet ds = Conexion.ObtenerTodos("products");
          
            List<Products> products = new();
            foreach (DataRow p in ds.Tables[0].Rows)
            {
                Products product = new();
                product.Id = Guid.Parse(p.ItemArray[0].ToString());
                product.Code = p.ItemArray[4].ToString();
                products.Add(product);
            }
            return products;
        }

        public static DataSet ObtenerProductoPorCodigo(string codigo)
        {
            string orden = $"select * from products where Code = {codigo};";
            DataSet ds = Conexion.ExecuteNonQueryWithData(orden);
            return null;
        }
    }
}

