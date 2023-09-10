using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

internal class DeletarConta : UserModel
{
    public int ExcluirUsuarioPorID(string email, string senha)
    {
        IDUsuario iDUsuario = new();
        int id = iDUsuario.usarID(email, senha);
        try
        {
            using NpgsqlConnection connection = new(db);
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
