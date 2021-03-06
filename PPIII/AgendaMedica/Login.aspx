﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="min-width:340px">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Content/Login.css" />
     <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'/>
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>
    <script>
        const widthOriginalPainel = "60%";
        const widthOriginalForm = "40%";


        function reajustar() {
            let painel = document.getElementById("painel");
            let form = document.getElementById("formContent");
            let corpo = document.getElementById("corpo");

            
            if (corpo.clientWidth <= 1000) {
                painel.style.width = "100%";
                form.style.width = "100%";
            }
            else {
                painel.style.width = widthOriginalPainel;
                form.style.width = widthOriginalForm;
            }
        }
    </script>
</head>
<body onresize="reajustar();">
  <div id="corpo" style="height:100%;">
    <div id="painel" class="painel" style="background-image:url('Images/medico-editado.jpg')">
       <h1>
           Consultas Médicas
       </h1>
    </div>
    <div id="formContent" class="form">
    <form id="form1" runat="server">
      <ul class="tab-group">
        <li class="tab active"><a href="#login">Faça seu login</a></li>
        <li class="tab"><a href="#signup">Cadastre-se</a></li>
      </ul>
      
      <div class="tab-content">
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
          
            <br />
            <asp:Label ID="lblMensagem" runat="server" ForeColor="Red" Width="100%"></asp:Label>
        </div>

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

            <asp:Button ID="btnCadastrar" runat="server" class="button" Text="Cadastrar" OnClick="btnCadastrar_Click" />

        </div>
      </div>
      </form>
    </div> <!-- /form -->
  </div>
    
  <script src='Scripts/jquery-1.10.2.min.js'></script>

  <script  src="Scripts/Login.js"></script>
  <script>
      reajustar();
  </script>

</body>
</html>
