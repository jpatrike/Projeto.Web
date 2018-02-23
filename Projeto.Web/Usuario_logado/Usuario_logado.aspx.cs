using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;

namespace Projeto.Web.Usuario_logado
{
    public partial class Usuario_logado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblLogin.Text = HttpContext.Current.User.Identity.Name;
                Usuario u = (Usuario)Session["usuario"];
                lblCodigo.Text = Convert.ToString(u.Codigo);
                lblNome.Text = u.Nome;                lblLogin.Text = u.Login;
                lblUltimoAcesso.Text = Convert.ToString(u.Ultimo_acesso);
                lblSenha.Text = u.Senha;
            }

        }
    }
}