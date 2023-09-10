using Newtonsoft.Json.Linq;

namespace InventarioPokemon.Services.BdConexao;

public class SqlConnectManager
{
    public static string GetConnectionString()
    {
        try
        {

            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sensible", "Key.jzon");

            string jsonContent = File.ReadAllText(jsonFilePath);
            dynamic config = JObject.Parse(jsonContent);

            string configPath = $"Server={config.DatabaseSettings.Server};Database={config.DatabaseSettings.Database};Username={config.DatabaseSettings.Username};Password={config.DatabaseSettings.Password}";
            return configPath;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao encontrar o caminho do arquivo: {ex.Message}");
            return null;
        }
    }
}