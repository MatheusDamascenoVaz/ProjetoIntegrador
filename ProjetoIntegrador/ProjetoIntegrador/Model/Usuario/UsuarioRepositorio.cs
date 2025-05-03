using ProjetoIntegrador.Models;
using ProjetoIntegrador.Services;
using MySql.Data.MySqlClient;

using System;
using ProjetoIntegrador.Model.Product;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;

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
            MySqlDataReader dataReader = null;
            try
            {
                string query = @"SELECT * FROM usuarios WHERE status = 1";

                dataReader = _databaseService.ExecuteQuery(query);

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
            finally
            {
                dataReader?.Close();  // Fecha explicitamente o DataReader
                dataReader?.Dispose(); // Libera os recursos
            }
        }
        public bool AtualizaUsuario(Usuario usuario)
        {
            try
            {
                string query = @"UPDATE usuarios 
                                SET nomeUsuario = @nome, matricula = @matricula, telefone = @telefone, email = @email, idRegra = @idRegra 
                                WHERE idUsuario = @id";
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@nome", usuario.Nome),
                    new MySqlParameter("@matricula", usuario.Matricula),
                    new MySqlParameter("@telefone", usuario.Telefone),
                    new MySqlParameter("@email", usuario.Email),
                    new MySqlParameter("@idRegra", usuario.IdRegra),
                    new MySqlParameter("@id", usuario.Id)
                };
                int affectedRows = _databaseService.ExecuteNonQuery(query, parameters);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar usuário: " + ex.Message);
            }

        }


        public bool UpdateStatusUsuario(Usuario usuario)
        {
            try
            {
                string query = $"UPDATE usuarios SET status = 0 WHERE idUsuario = {usuario.Id}";

                MessageBox.Show(query);



                int affectedRows = _databaseService.ExecuteNonQuery(query);
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar produto: " + ex.Message);
            }


        }


    }
}
