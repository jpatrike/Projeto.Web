using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;
using Projeto.DAL;

namespace Projeto.Web
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAL d = new UsuarioDAL();
                if (!d.VerificarLoginExistente(txtLogin.Text))
                {
                    Usuario u = new Usuario(); 
                    u.Nome = txtNome.Text;
                    u.Login = txtLogin.Text;
                    u.Senha = txtSenha.Text;
                    d.Inserir(u); 
                    lblMensagem.Text = $"Usuário {u.Nome},cadastrado com sucesso.";
                    txtNome.Text = string.Empty;
                    txtLogin.Text = string.Empty;
                }
                else
                {
                    lblMensagem.Text = "Este login ja existe. Tente outro.";
                }

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}