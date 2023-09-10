using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class DeletarConta : UserModel
{
    public int ExcluirUsuarioPorID(int id)
    {
        try
        {
            using NpgsqlConnection connection = new(conexao());
            connection.Open();

            string sqlCommand = $"DELETE FROM users WHERE Id= {id}";

            NpgsqlCommand cmd = new(sqlCommand, connection);
            cmd.Parameters.AddWithValue("Id", id);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao deletar sua conta: {ex.Message}");
        }
        return 0;
    }
}
