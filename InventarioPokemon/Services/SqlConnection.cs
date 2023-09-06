using Npgsql;
using System.Xml;

namespace InventarioPokemon.Services;

internal class SQLConnection
{
    public void Conectar()
    {
        string linhaDeConexao = SqlConnectManager.GetConnectionString();

        if (!string.IsNullOrEmpty(linhaDeConexao))
        {
            using(var connection = new NpgsqlConnection(linhaDeConexao))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão bem-sucedida com o banco de dados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }
        }
        else
        {
            MessageBox.Show("String de conexão não encontrada ou inválida.");
        }
    }
}