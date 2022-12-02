using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderNow.Common.Data.Entities;

namespace OrderNow.Admin.DAL.Repositorios
{
    public class RepositorioRecetas
    {
        public static int GuardarIngredienteDeReceta(Guid recipeId, Ingredients ingrediente)
        {
            string commandText = "";

            commandText = $"INSERT INTO [dbo].[Ingredients] ([Id] ,[IngredientId] ,[Quantity],[RecipesId] ,[Created],[LastModified]) VALUES " +
                $"(@Id, @IngredientId, @Quantity, @RecipesId, @Created, @LastModified)";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@IngredientId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@RecipesId", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Quantity", SqlDbType.VarChar);
            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);



            command.Parameters["@ID"].Value = ingrediente.Id;
            command.Parameters["@IngredientId"].Value = ingrediente.Ingredient.Id;
            command.Parameters["@RecipesId"].Value = recipeId;
            command.Parameters["@Quantity"].Value = ingrediente.Quantity;
            command.Parameters["@Created"].Value = ingrediente.Created.ToUniversalTime();
            command.Parameters["@LastModified"].Value = ingrediente.LastModified.ToUniversalTime();

            return Conexion.ExecuteNonQuery(command);
        }

        public static int GuardarReceta(Recipes recipes)
        {
            string commandText = "";

            commandText = $"INSERT INTO [dbo].[Recipes] ([Id], [Name], [Created], [LastModified])" +
            $" VALUES " +
            $"(@Id, @Name, @Created, @LastModified)";

            SqlCommand command = new SqlCommand(commandText);

            command.Parameters.Add("@Id", SqlDbType.UniqueIdentifier);
            command.Parameters.Add("@Name", SqlDbType.VarChar);
            command.Parameters.Add("@Created", SqlDbType.DateTime);
            command.Parameters.Add("@LastModified", SqlDbType.DateTime);



            command.Parameters["@ID"].Value = recipes.Id;
            command.Parameters["@Name"].Value = recipes.Name;
            command.Parameters["@Created"].Value = recipes.Created.ToUniversalTime();
            command.Parameters["@LastModified"].Value = recipes.LastModified.ToUniversalTime();

            return Conexion.ExecuteNonQuery(command);

        }


        public static DataSet ObtenerIngredientes()
        {
            string orden = $"select * from products where IsSelleable = 0;";
            return Conexion.ExecuteNonQueryWithData(orden);
        }

    }
}
