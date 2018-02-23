using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome{ get; set; }
        public string Login{ get; set; }
        public string Senha{ get; set; }
        public DateTime Ultimo_acesso { get; set; }
        public int Qtd_erro_login { get; set; }
        public int Bl_ativo { get; set; }

        public Usuario()
        {

        }
       public Usuario (int codigo, string nome, string login, string senha, DateTime ultimo_acesso, int qtd_erro_login, int bl_ativo)
        {
            Codigo = codigo;
            Nome = nome;
            Login = login;
            Senha = senha;
            Ultimo_acesso = ultimo_acesso;
            Qtd_erro_login = qtd_erro_login;
            Bl_ativo = bl_ativo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6}",Codigo, Nome, Login, Senha, Ultimo_acesso, Qtd_erro_login, Bl_ativo);
        }

    }

}
