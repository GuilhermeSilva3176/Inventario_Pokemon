using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class RegistrarConta
{
    public int RegistrarUsuario(string nome, string email, string senha)
    {
        
        try
        {
            UserModel usrModel = UserModel.Instance;

            using NpgsqlConnection connection = new(usrModel.GetConnectionString());
            connection.Open();
            string sqlCommand = "INSERT INTO users (nome, email, senha) VALUES (@Nome, @Email, @Senha)";

            NpgsqlCommand cmd = new(sqlCommand, connection);
            cmd.Parameters.AddWithValue("Nome", nome);
            cmd.Parameters.AddWithValue("Email", email);
            cmd.Parameters.AddWithValue("Senha", senha);
            cmd.ExecuteNonQuery();
            return 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return -1;
        }
    }
}
