using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class DeletarConta
{
    public int ExcluirUsuarioPorID(int id)
    {
        try
        {
            UserModel usrModel = new();
            string connectionString = usrModel.GetConnectionString();

            using NpgsqlConnection connection = new(connectionString);
            connection.Open();

            string sqlCommand = $"DELETE FROM users WHERE Id= {id}";

            NpgsqlCommand cmd = new(sqlCommand, connection);
            cmd.Parameters.AddWithValue("Id", id);

            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao deletar sua conta: {ex.Message}");
        }
        return 0;
    }
}
