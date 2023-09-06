using System.Configuration;
using System.Xml;
using System.Xml.Linq;

namespace InventarioPokemon.Services;

internal class SqlConnectManager
{
    public static string GetConnectionString()
    {
        string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sensible", "Key.xml");
        string connectionString = string.Empty;
        try
        {
            XmlDocument xmlDoc = new();
            xmlDoc.Load(configPath);
            connectionString = xmlDoc.SelectSingleNode("/configuration/connectionStrings/add[@name = 'MyDatabase']").Attributes["connectionString"].Value;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao ler a string de conexão do arquivo XML: {ex.Message}");
        }
        return connectionString;
    }
}
