using Npgsql;
using System.Xml;

namespace InventarioPokemon.Services;

public class SqlConnection
{

    private static string linhaDeConexao = SqlConnectManager.GetConnectionString();
    public static NpgsqlConnection Conecta()
    {
        if (!string.IsNullOrEmpty(linhaDeConexao))
        {
            using (var connection = new NpgsqlConnection(linhaDeConexao))
            {
               try
                {
                    connection.Open();
                    return connection;
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}"); 
                    throw; 
                }
            }
        }
        else 
        { 
            MessageBox.Show("String de conexão não encontrada ou inválida.");
            return null;
        }
    }
}