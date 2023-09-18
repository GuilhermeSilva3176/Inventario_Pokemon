using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon.Models.UsuarioModels;

public class UserModel
{
    private string db;

    public UserModel()
    {
        db = SqlConnectManager.GetConnectionString();
    }

    public string GetConnectionString()
    {
        return db;
    }
}

