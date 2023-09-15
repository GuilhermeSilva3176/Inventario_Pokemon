using InventarioPokemon.Forms;
using Npgsql;
using System.ComponentModel.DataAnnotations;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

internal class AtualizarConta
{
    private string Email { get; }
    private string Senha { get; }

    public AtualizarConta(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
    public string AttConta(string nome, string email, string senha)
    {
        try
        {          
            FormMenuLogin fMenuLogin = new();
            LogarConta lgConta = new();

            UserModel usrModel = UserModel.Instance;
            using NpgsqlConnection connection = new(usrModel.GetConnectionString());
            connection.Open();

            int id = lgConta.LogarUsuario(Email, Senha);
            string attQuery = "UPDATE users SET nome=@Nome,email=@Email,senha=@Senha WHERE id=@Id";


            NpgsqlCommand cmd = new NpgsqlCommand(attQuery, connection);
            cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Nome", nome);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("Senha", senha);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               return "Nome Atualizado com sucesso!!";
            }
            connection.Close();
        }
        catch (Exception ex)
        {
            return $"Erro: {ex.Message}";
        }
        return "Não foi possivel atualizar o nome.";
    }
}
