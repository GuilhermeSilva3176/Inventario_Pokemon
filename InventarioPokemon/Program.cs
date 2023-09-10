using InventarioPokemon.Forms;

namespace InventarioPokemon;
internal static class Program
{      
    [STAThread]
    static void Main()
    {           
        ApplicationConfiguration.Initialize();
        Application.Run(new MessageBox.Show("Palmeiras."));
    }
}