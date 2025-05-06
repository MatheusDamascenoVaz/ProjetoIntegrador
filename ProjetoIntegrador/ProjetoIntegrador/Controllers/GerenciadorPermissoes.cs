using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Controllers
{
    public enum NivelPermissao
    {
        Administrador = 1,
        Gerente = 2,
        Estoquista = 3,
        Auditor = 4
    }

    public enum Funcionalidade
    {
        GerenciarUsuarios,
        GerenciarProdutos,
        GerenciarVendas,
        AdicionarProduto,
        Relatorios,
        ConfiguracoesAvancadas,
        VisualizarDados
    }

    
    
    public static class GerenciadorPermissoes
    {
        
        public static bool TemPermissao(Usuario usuario, Funcionalidade funcionalidade)
        {
            switch (usuario.IdRegra)
            {
                case (int)NivelPermissao.Administrador:
                    return true; // Administrador tem acesso a tudo

                case (int)NivelPermissao.Gerente:
                    return funcionalidade == Funcionalidade.Relatorios
                        || funcionalidade == Funcionalidade.ConfiguracoesAvancadas
                        || funcionalidade == Funcionalidade.GerenciarVendas
                        || funcionalidade == Funcionalidade.GerenciarProdutos
                        || funcionalidade == Funcionalidade.AdicionarProduto
                        || funcionalidade == Funcionalidade.VisualizarDados;

                case (int)NivelPermissao.Estoquista:
                    return funcionalidade == Funcionalidade.VisualizarDados
                       || funcionalidade == Funcionalidade.GerenciarVendas
                       || funcionalidade == Funcionalidade.AdicionarProduto;


                case (int)NivelPermissao.Auditor:
                    return funcionalidade == Funcionalidade.VisualizarDados
                        || funcionalidade == Funcionalidade.Relatorios;
                        

                default:
                    return false;
            }
        }

        public static bool ValidarPermissao(Usuario usuario, Funcionalidade funcionalidade)
        {
            
               
            if (!TemPermissao(usuario, funcionalidade))
            {
                MessageBox.Show($"Usuário não tem permissão para acessar: {funcionalidade}",
                    "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                //throw new UnauthorizedAccessException(
                //    $"Usuário não tem permissão para acessar: {funcionalidade}");
            }
            return true;
        }
    }
    }