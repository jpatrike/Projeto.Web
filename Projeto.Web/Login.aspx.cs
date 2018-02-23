using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.DAL;
using System.Web.Security;
namespace Projeto.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                UsuarioDAL d = new UsuarioDAL();
                Usuario u = d.ValidarLogin(login,senha);

                if (u != null) 
                {
                    d.DataLogin(txtLogin.Text);
                    d.Limp_qtd_erro(txtLogin.Text);
                    Session.Add("usuario", u); 
                    FormsAuthenticationTicket ticket
                    = new FormsAuthenticationTicket(login, false, 5);
                    HttpCookie cookie = new HttpCookie
                    (FormsAuthentication.FormsCookieName,
                     FormsAuthentication.Encrypt(ticket));
                    Response.Cookies.Add(cookie);
                    Response.Redirect("Usuario_logado/Usuario_logado.aspx");
                }
               else { d.ContadorErro(txtLogin.Text); lblMensagem.Text = "Erro"; }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}