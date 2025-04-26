using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;
using MySql.Data.MySqlClient;

using System;
using ProjetoIntegrador.Model.Product;
using System.Collections.Generic;

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

        public List<Usuario> GetAllUsers()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            try
            {
                string query = @"SELECT * FROM usuarios";

                MySqlDataReader dataReader = _databaseService.ExecuteQuery(query);

                while (dataReader.Read())
                {

                    Usuario usuario = new Usuario();
                    usuario = Usuario.UserFromDataReader(dataReader);

                    listaUsuario.Add(usuario);
                }
                return listaUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro buscar lista: " + ex.Message);
            }
        }

    }
}
