using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class AtualizarConta
{
    public int Id { get; set; }
    public int AttConta(int id, string nome, string email, string senha)
    {
        try
        {
            UserModel usrModel = new();
            string connectionString = usrModel.GetConnectionString();

            using NpgsqlConnection connection = new(connectionString);
            connection.Open();

            string attQuery = "UPDATE users SET nome=@Nome,email=@Email,senha=@Senha WHERE id=@Id";

            NpgsqlCommand cmd = new NpgsqlCommand(attQuery, connection);
            cmd.Parameters.AddWithValue("Id", id);
            cmd.Parameters.AddWithValue("Nome", nome);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("Senha", senha);
            
            int rowsaffected = cmd.ExecuteNonQuery();
            if(rowsaffected > 0) 
            {
                MessageBox.Show("Conta atualizada com sucesso!!");
                return rowsaffected;
            }
            connection.Close();
        }
        catch
        {
            return -1;
        }
        return -1;
    }
}
