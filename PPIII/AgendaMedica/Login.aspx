<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Content/Login.css" />
     <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'/>
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="form">
      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">Cadastre-se</a></li>
        <li class="tab"><a href="#login">Faça seu login</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Cadastre-se
            </h1>
          
            <div class="field-wrap">
              <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" AutoCompleteType="Disabled"></asp:TextBox>
            </div>

            <div class="field-wrap">
              <asp:TextBox ID="txtDataNasc" runat="server" placeholder="Data Nascimento" AutoCompleteType="Disabled" TextMode="Date"></asp:TextBox>
            </div>

            <div class="field-wrap">
              <asp:TextBox ID="txtCelular" runat="server" placeholder="Celular" AutoCompleteType="Disabled" TextMode="Phone"></asp:TextBox>
            </div>

            <div class="field-wrap">
              <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço" AutoCompleteType="Disabled" TextMode="SingleLine"></asp:TextBox>
            </div>

          <div class="field-wrap">
            <asp:TextBox ID="txtEmailCadastro" runat="server" placeholder="E-mail"  TextMode="Email" AutoCompleteType="Email"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <asp:TextBox ID="txtSenhaCadastro" runat="server" placeholder="Senha" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
          </div>
          <div class="field-wrap">
            <asp:TextBox ID="txtConfSenha" runat="server" placeholder="Confirmar Senha" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
          </div>
          
         <asp:Button ID="btnCadastrar" runat="server" class="button button-block" Text="Cadastrar" />
          
        </div>
        
        <div id="login">   
          <h1>Bem vindo!</h1>
          
          <div class="field-wrap">
            <asp:TextBox ID="txtEmailLogin" runat="server" placeholder="E-mail" AutoCompleteType="Email" TextMode="Email" ></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <asp:TextBox ID="txtSenhaLogin" runat="server" placeholder="Senha" AutoCompleteType="Disabled" TextMode="Password"></asp:TextBox>
          </div>
          
          <!--<p class="forgot"><a href="#">Forgot Password?</a></p>-->
          
           <asp:Button ID="btnEntrar" runat="server" class="button button-block" Text="Entrar" OnClick="btnEntrar_Click" />
          
        </div>
        
      </div>
      
</div> <!-- /form -->
  <script src='Scripts/jquery-1.10.2.min.js'></script>

    <script  src="Scripts/Login.js"></script>
    </form>
</body>
</html>
