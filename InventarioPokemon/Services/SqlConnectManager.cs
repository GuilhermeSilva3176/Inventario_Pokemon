using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using InventarioPokemon.Sensible;
using Newtonsoft.Json.Linq;
using Npgsql;

namespace InventarioPokemon.Services;

public class SqlConnectManager
{
    public static string GetConnectionString()
    {
        try
        {
            CaminhoJson caminhoJson = new();
            string jsonFilePath = caminhoJson.retornaCaminho();

            string jsonContent = File.ReadAllText(jsonFilePath);
            dynamic config = JObject.Parse(jsonContent);

            string configPath = $"Server={config.DatabaseSettings.Server};Database={config.DatabaseSettings.Database};Username={config.DatabaseSettings.Username};Password={config.DatabaseSettings.Password}";
            return configPath;

        }catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}");
            return null;
        }
    }
}