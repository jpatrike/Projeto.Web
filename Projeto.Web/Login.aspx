<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">

    <asp:ValidationSummary 
        ID="validacao" 
        runat="server" 
        EnableClientScript="true" 
        DisplayMode="BulletList" 
     />

<div class="row"> 
    <div class="col-md-4"> 
        
        <label>Login </label> 
        &nbsp;<asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" placeholder="Digite aqui" /> 
        <asp:RequiredFieldValidator 
            ID="requiredLogin" 
            runat="server" 
            ControlToValidate="txtLogin" 
            Text="Campo obrigatório" 
            ErrorMessage="Por favor, informe o login de acesso." 
            ForeColor="Red" 
            Display="Dynamic" />
        
        <br />
        
        <label>Senha</label> 
        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Digite aqui" TextMode="Password" />
        <asp:RequiredFieldValidator
          ID="requiredSenha"
          runat="server"
          ControlToValidate="txtSenha"
          Text="Campo obrigatório"
          ErrorMessage="Por favor, informe a senha de acesso."
          ForeColor="Red"
          Display="Dynamic"
         />
        <br /> 
        
        <asp:Button ID="btnAcesso" runat="server" Text="Acessar" CssClass="btn btn-default" onClick ="btnAcesso_Click"/>
        
        <br /> <br /> 

        <a href="/Cadastro.aspx"> Cadastrar </a>
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-danger" />

    </div> 

</div>

</asp:Content>

