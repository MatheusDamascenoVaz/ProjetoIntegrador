// Models/Usuario.cs
using System;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }
        public int IdRegra { get; set; }
        public string Telefone { get; set; }
        public string SenhaHash { get; set; }



        public static Usuario UserFromDataReader(MySqlDataReader datareader)
        {

            return new Usuario
            {

                Id = datareader.GetInt32("idUsuario"),
                Nome = datareader["nomeUsuario"].ToString(),
                Matricula = datareader.GetInt32("matricula"),
                Telefone = datareader["telefone"].ToString(),
                Email = datareader["email"].ToString(),
                IdRegra = datareader.GetInt32("idRegra"),
                SenhaHash = datareader["senha_hash"].ToString(),
            };

        }
    } 
}