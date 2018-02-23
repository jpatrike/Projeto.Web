<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.Web.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">
   
    
    <asp:ValidationSummary
        ID="Validacao"
        runat="server"
        EnableClientScript="true"
        DisplayMode="BulletList"
        ForeColor="Red" />
    
    <div class="row">
        <div class="col-md-4">


            <label>Nome</label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredNome"
                runat="server"
                ControlToValidate="txtNome"
                Text="Campo obrigatório"
                ErrorMessage="Informe o nome do usuário."
                ForeColor="Red"
                Display="Dynamic" />
            <asp:RegularExpressionValidator
                ID="regexNome"
                runat="server"
                ControlToValidate="txtNome"
                Text="Nome inválido"
                ErrorMessage="Informe um nome válido"
                ForeColor="Red"
                Display="Dynamic"
                ValidationExpression="^[a-zA-Zà-üÀ-Ü\s]{3,50}$" />


            <br />


            <label>Login</label>
            <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" placeholder="Digite aqui" />
            <asp:RequiredFieldValidator
                ID="requiredLogin"
                runat="server"
                ControlToValidate="txtLogin"
                Text="Campo obrigatório"
                ErrorMessage="Informe o login do usuário."
                ForeColor="Red"
                Display="Dynamic" />
            <asp:RegularExpressionValidator
                ID="regexLogin"
                runat="server"
                ControlToValidate="txtLogin"
                Text="Apenas 12 Caracteres"
                ErrorMessage="Informe um login válido(letras minusculas e numeros)"
                ForeColor="Red"
                Display="Dynamic"
                ValidationExpression="^[a-z0-9]{3,12}$" />


            <br />


            <label>Senha</label>
            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Digite aqui" TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="requiredSenha"
                runat="server"
                ControlToValidate="txtSenha"
                Text="Campo obrigatório"
                ErrorMessage="Informe a senha do usuário."
                ForeColor="Red"
                Display="Dynamic" />
            <asp:RegularExpressionValidator
                ID="regexSenha"
                runat="server"
                ControlToValidate="txtSenha"
                Text="Senha inválida"
                ErrorMessage="Informe uma senha válida(letras e numeros)"
                ForeColor="Red"
                Display="Dynamic"
                ValidationExpression="^[a-zA-Z0-9]{6,20}$" />


            <br />



            <label>Confirmar Senha</label>
            <asp:TextBox ID="txtSenhaConfirm" runat="server" CssClass="form-control" placeholder="Digite aqui" TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="requiredSenhaConfirm"
                runat="server"
                ControlToValidate="txtSenhaConfirm"
                Text="Campo obrigatório"
                ErrorMessage="Confirme a senha do usuário."
                ForeColor="Red"
                Display="Dynamic" />
            <asp:CompareValidator
                ID="compareSenha"
                runat="server"
                ControlToValidate="txtSenhaConfirm"
                ControlToCompare="txtSenha"
                Text="Senhas não conferem"
                ErrorMessage="Informe sua senha corretamente (senhas não conferem)"
                ForeColor="Red"
                Display="Dynamic" />


            <br />
            <br />

            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-default" OnClick="btnCadastro_Click" />


            <br />
            <br />
            <label>Já possui Login? </label>
            <a href="/Login.aspx"> Fazer Login </a>
            <br />
            <asp:Label ID="lblMensagem" runat="server" />
        </div>
    </div>
</asp:Content>
