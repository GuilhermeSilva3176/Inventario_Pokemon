using InventarioPokemon.Services.BdConexao;

namespace InventarioPokemon.Models.UsuarioModels;

public class UserModel
{
    public string db;
    public string conexao()
    {
        db = SqlConnectManager.GetConnectionString();
        return db;
    }

}
