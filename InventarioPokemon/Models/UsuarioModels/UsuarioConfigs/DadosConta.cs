using Npgsql;
namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class DadosConta
{
    private string Email { get; }
    private string Senha { get; }

    public DadosConta(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    public (string Nome, string Email) RetornaInformacoes()
    {
        LogarConta lgConta = new();
        try
        {
            UserModel usrModel = new();
            string connectionString = usrModel.GetConnectionString();

            using NpgsqlConnection connection = new(connectionString);
            connection.Open();

            int id = lgConta.LogarUsuario(Email, Senha);
            string nameUserQuery = "SELECT nome, email, senha FROM users WHERE id=@id";

            NpgsqlCommand cmd = new NpgsqlCommand(nameUserQuery, connection);
            cmd.Parameters.AddWithValue("id", id);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string nome = reader.GetString(0);
                string email = reader.GetString(1);
                return (nome, email);
            }
        }
        catch (Exception ex)
        {
           throw ex;
        }
        return ("Erro ao ","Mostrar Nome.");
    }
}
