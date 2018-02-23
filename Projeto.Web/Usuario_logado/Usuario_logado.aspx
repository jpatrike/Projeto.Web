<%@ Page Title="" Language="C#" MasterPageFile="~/Usuario_logado/Template_logado.Master" AutoEventWireup="true" CodeBehind="Usuario_logado.aspx.cs" Inherits="Projeto.Web.Usuario_logado.Usuario_logado" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ConteudoLogado" runat="server">

    <div>   
                        <label>Codigo:&nbsp; </label>
                        <asp:Label ID="lblCodigo" runat="server" />
        </br></br>
                        <label>Nome:&nbsp; </label>
                        <asp:Label ID="lblNome" runat="server" />
        </br></br>
                        <label>Login:&nbsp; </label>
                        <asp:Label ID="lblLogin" runat="server" />           
        </br></br>
                        <label>Senha:&nbsp; </label>
                        <asp:Label ID="lblSenha" runat="server" />
        </br></br>
                        <label>Ultimo Acesso:&nbsp; </label>
                        <asp:Label ID="lblUltimoAcesso" runat="server" />

    </div>



</asp:Content>
