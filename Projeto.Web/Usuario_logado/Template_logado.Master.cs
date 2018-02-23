using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Projeto.Entidades;

namespace Projeto.Web.Usuario_logado
{
    public partial class Template_logado : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblLogin.Text = HttpContext.Current.User.Identity.Name;
                Usuario u = (Usuario)Session["usuario"];
                lblNome.Text = u.Nome;                lblLogin.Text = u.Login;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("/Login.aspx");
        }
    }
}