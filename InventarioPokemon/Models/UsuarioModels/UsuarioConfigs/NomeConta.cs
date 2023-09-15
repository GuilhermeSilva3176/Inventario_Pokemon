using Npgsql;
namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class NomeConta
{
    private string Email { get; }
    private string Senha { get; }

    public NomeConta(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    public string RetornaNome()
    {
        LogarConta lgConta = new();
        try
        {
            UserModel usrModel = UserModel.Instance;
            using NpgsqlConnection connection = new(usrModel.GetConnectionString());
            connection.Open();

            int id = lgConta.LogarUsuario(Email, Senha);
            string nameUserQuery = "SELECT nome FROM users WHERE id=@id";

            NpgsqlCommand cmd = new NpgsqlCommand(nameUserQuery, connection);
            cmd.Parameters.AddWithValue("id", id);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(0);
            }
        }
        catch (Exception ex)
        {
            return $"Algum erro inesperado aconteceu {ex.Message}";
        }
        return "Erro ao Mostrar Nome D:";
    }
}
