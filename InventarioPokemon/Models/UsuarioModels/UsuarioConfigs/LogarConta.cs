﻿using Npgsql;

namespace InventarioPokemon.Models.UsuarioModels.UsuarioConfigs;

public class LogarConta
{
    public int LogarUsuario(string email, string senha)
    {
        try
        {
            UserModel usrModel = new();
            string connectionString = usrModel.GetConnectionString();

            using NpgsqlConnection connection = new(connectionString);
            connection.Open();
            int id = -1;
            string userQuery = "SELECT id FROM Users WHERE email = @Email AND senha = @Senha";

            NpgsqlCommand cmdNpg = new(userQuery, connection);

            cmdNpg.Parameters.AddWithValue("Email", email);
            cmdNpg.Parameters.AddWithValue("Senha", senha);

            NpgsqlDataReader reader = cmdNpg.ExecuteReader();

            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            return id;
        }
        catch
        {
            return -1;
        }
    }
}
