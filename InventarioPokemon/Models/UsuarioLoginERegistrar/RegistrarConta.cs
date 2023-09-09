using Npgsql;

namespace InventarioPokemon.Models.UsuarioLoginERegistrar;

internal class RegistrarConta
{
    private string _linhaDeConexao;

    public RegistrarConta(string conexao)
    {
        _linhaDeConexao = conexao;
    }

    public bool RegistrarUsuario(string nome, string email, string senha)
    {
        using (var connection = new NpgsqlConnection(_linhaDeConexao))
        {
            try
            {
                connection.Open();

                string sqlCommand = "INSERT INTO users (nome, email, senha) VALUES (@nome, @email, @senha)";

                using (var cmd = new NpgsqlCommand(sqlCommand, connection))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
