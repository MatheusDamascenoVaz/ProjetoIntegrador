using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;
using MySql.Data.MySqlClient;

using System;

namespace ProjetoIntegrador.Model
{
    public class UsuarioRepositorio
    {
        DatabaseService _databaseService;

        public UsuarioRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool Register(Usuario usuario, string password)
        {
            try
            {
                string query = @"INSERT INTO usuarios 
                                (nomeUsuario, matricula, telefone, email, idRegra, senha_hash) 
                                VALUES 
                                (@nome, @matricula, @telefone, @email, @idRegra, @senha_hash)";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@nome", usuario.Nome),
                    new MySqlParameter("@matricula", usuario.Matricula),
                    new MySqlParameter("@telefone", usuario.Telefone),
                    new MySqlParameter("@email", usuario.Email),
                    new MySqlParameter("@senha_hash", Criptografia.HashPassword(password)),
                    new MySqlParameter("@idRegra", usuario.IdRegra),
                };

                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao registrar usuário: " + ex.Message);
            }
        }
    }
}
