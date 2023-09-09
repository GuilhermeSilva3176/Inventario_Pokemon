using Npgsql;

namespace InventarioPokemon.Models.UsuarioLoginERegistrar;

internal class LogarConta
{
    private readonly string _linhaDeConexao;

    public LogarConta(string conexao)
    {
        _linhaDeConexao = conexao;
    }

    public int LogarUsuario(string email, string senha)
    {
        try
        {
            using (var connection = new NpgsqlConnection(_linhaDeConexao))
            {
                connection.Open();

                string userQuery = "SELECT * FROM users WHERE email = @Email AND senha = @Senha";

                using (NpgsqlCommand cmdNpg = new(userQuery, connection))
                {
                    cmdNpg.Parameters.AddWithValue("Email", email);
                    cmdNpg.Parameters.AddWithValue("Senha", senha);

                    object result = cmdNpg.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return -1;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
