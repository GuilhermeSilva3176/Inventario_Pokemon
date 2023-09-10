using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels;

public class LogarConta : UserModel
{
    public int LogarUsuario(string email, string senha)
    {
        try
        {
            using NpgsqlConnection connection = new(conexao());
            connection.Open();
            int id;
            string userQuery = "SELECT id FROM Users WHERE email = @Email AND senha = @Senha";

            NpgsqlCommand cmdNpg = new(userQuery, connection);

            cmdNpg.Parameters.AddWithValue("Email", email);
            cmdNpg.Parameters.AddWithValue("Senha", senha);

            NpgsqlDataReader reader = cmdNpg.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
