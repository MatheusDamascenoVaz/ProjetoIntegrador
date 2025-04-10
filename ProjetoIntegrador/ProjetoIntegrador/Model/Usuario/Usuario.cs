// Models/Usuario.cs
using System;

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
        
    }
}