using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon.Models.UsuarioModels;

public class UserModel
{
    private string db;
    private static UserModel instance;

    private UserModel()
    {
        db = SqlConnectManager.GetConnectionString();
    }

    public static UserModel Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new UserModel();
            }
            return instance;
        }
    }

    public string GetConnectionString()
    {
        return db;
    }
}

