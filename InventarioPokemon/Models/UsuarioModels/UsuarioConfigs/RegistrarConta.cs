using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class RegistrarConta
{
    public int RegistrarUsuario(string nome, string email, string senha)
    {
        
        try
        {
            UserModel usrModel = new();
            string connectionString = usrModel.GetConnectionString();

            using NpgsqlConnection connection = new(connectionString);
            connection.Open();
            string sqlCommand = "INSERT INTO users (nome, email, senha) VALUES (@Nome, @Email, @Senha)";

            NpgsqlCommand cmd = new(sqlCommand, connection);
            cmd.Parameters.AddWithValue("Nome", nome);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Senha", senha);
            
            int id = cmd.ExecuteNonQuery();
            return id;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return -1;
        }
    }
}
