using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

internal class IDUsuario
{
    public int usarID(string email, string senha)
    {
        try
        {
            LogarConta logarConta = new();
            int idUsuario = logarConta.LogarUsuario(email, senha);
            return idUsuario;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

}
