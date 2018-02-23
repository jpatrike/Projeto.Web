using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;



namespace Projeto.DAL
{
    public class UsuarioDAL : Conexao
    {

        public void Inserir(Usuario u)
        {
            AbrirConexao();
            string query = "insert into usuario(nome,logon,senha,bl_ativo,qtd_erro_login,ultimo_acesso)" + "values(@nome,@login,@senha,1,0,getDate())";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@senha", u.Senha);
            cmd.ExecuteNonQuery();
            FecharConexao();
        }

//--------------------------------------------------------------------------------

        public Usuario ValidarLogin(string login, string senha)
        {
            AbrirConexao();
            string query = "select * from usuario where logon = @Login and senha = @Senha and bl_ativo=1";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);
            dr = cmd.ExecuteReader(); 
            Usuario u = null;
            if (dr.Read()) 
            {
                u = new Usuario();
                u.Codigo = Convert.ToInt32(dr["codigo"]);
                u.Nome = Convert.ToString(dr["nome"]);
                u.Login = Convert.ToString(dr["logon"]);
                u.Senha = Convert.ToString(dr["senha"]);
                u.Ultimo_acesso = Convert.ToDateTime(dr["ultimo_acesso"]);
                u.Qtd_erro_login = Convert.ToInt16(dr["qtd_erro_login"]);
                u.Bl_ativo = Convert.ToInt16(dr["bl_ativo"]);
            }
            FecharConexao();
            return u;
        }

        //--------------------------------------------------------------------------------

        public void DataLogin(string login)
        {
            AbrirConexao();
            string query = "update usuario set ultimo_acesso = getDate() where logon = @Login";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.ExecuteNonQuery();
            FecharConexao();
        }

//--------------------------------------------------------------------------------

        public bool VerificarLoginExistente(string login)
        {
            AbrirConexao();
            string query = "select count(*) from usuario where logon = @Login";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            int qtd = Convert.ToInt32(cmd.ExecuteScalar());
            FecharConexao();
            return qtd > 0; 
        }


//--------------------------------------------------------------------------------

        public void ContadorErro(string login)
        {
            AbrirConexao();
            string query = "update usuario set qtd_erro_login += 1 where logon = @Login";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.ExecuteNonQuery();
            FecharConexao();
                Bloq(login);
        }

//--------------------------------------------------------------------------------

        public void Bloq(string login)
        {
            AbrirConexao();
            string query = "IF  (select qtd_erro_login from usuario where logon = @Login ) >= 3 BEGIN update usuario set bl_ativo = 0 where logon = @Login; END  ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.ExecuteNonQuery();
            FecharConexao();
        }

//--------------------------------------------------------------------------------

        public void Limp_qtd_erro(string login)
        {
            AbrirConexao();
            string query = "update usuario set qtd_erro_login = 0 where logon = @Login ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.ExecuteNonQuery();
            FecharConexao();
        }
    }
}
