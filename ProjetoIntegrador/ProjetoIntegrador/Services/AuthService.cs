﻿// Services/AuthService.cs
using System;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Services
{
    public class AuthService
    {
        private readonly DatabaseService _databaseService;

        public AuthService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario Authenticate(string email, string password)
        {
            try
            {
                // Primeiro busca o usuário pelo email
                string query = "SELECT * FROM usuarios WHERE email = @emailDigitado";
                var parameters = new MySqlParameter[] 
                {

                    new MySqlParameter("@emailDigitado", email),

                };

                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())
                        
                    {
                        // Verifica a senha
                        string storedHash = respostaBanco["senha_hash"].ToString();
                        string inputHash = Criptografia.HashPassword(password);

                        if (storedHash == inputHash)
                        {
                          Usuario usuario =  new Usuario
                            {
                                Id = Convert.ToInt32(respostaBanco["idUsuario"]),
                                IdRegra = Convert.ToInt32(respostaBanco["idRegra"]),
                                Nome = respostaBanco["nomeUsuario"].ToString(),
                                Email = respostaBanco["email"].ToString(),
                                SenhaHash = respostaBanco["senha_hash"].ToString(),
                                Telefone = respostaBanco["telefone"].ToString(),
                                Matricula = Convert.ToInt32(respostaBanco["matricula"]),
                            };
                            SessionUser.Login(usuario);

                            return usuario;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante autenticação: " + ex.Message);
            }
        }

        

       
    }
}