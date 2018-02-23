using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;

namespace Projeto.BLL
{
    public class UsuarioBLL
    {
        public void CadastrarUsuario(Usuario u)
        {
            UsuarioDAL d = new UsuarioDAL();
            d.Inserir(u);
        }

    }
}
