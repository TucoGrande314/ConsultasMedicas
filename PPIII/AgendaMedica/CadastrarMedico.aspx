<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CadastrarMedico.aspx.cs" Inherits="CadastrarMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <style>
        .grupo{
            display:block;
            
            width:100%;
        }
        .grupo div{
            display:block;
        }
        .grupo span{
            margin-bottom:5px;
        }
        .grupo span label{
            display:block;
        }
        .grupo span input{
            width:100%;
            min-width:120px;
        }
        .grupo span select{
            width:100%;
            min-width:100px;
        }
    </style>
    <div class="formulario">
        <div class="cabecalho">
            <h3>
                Cadastrar Médico
            </h3>
            <hr>
        </div>
        <div class="grupo container-fluid">
            <div class="row">
                <span class="col-xs-5">
                 <label>E-mail</label><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"/>
                </span>    
                <span class="col-xs-3">
                 <label>Senha</label><asp:TextBox ID="txtSenha" runat="server" TextMode="Password"/>
                </span>
                <span class="col-xs-3">
                 <label>Confirmação de Senha</label><asp:TextBox ID="txtConfirmacaoSenha" runat="server" TextMode="Password"/>
                </span> 
            </div>
            <div class="row">
                <span class="col-xs-5">
                 <label>Nome</label><asp:TextBox ID="txtNome" runat="server"/>
                </span> 
                <span class="col-xs-3">
                 <label>Especialidade</label><asp:DropDownList ID="ddEspecialidade" runat="server" DataSourceID="dsEspecializacao" DataTextField="nome_especializacao" DataValueField="id_especializacao"/>              
                </span> 
                <span class="col-xs-3">
                 <label>Celular</label><asp:TextBox ID="txtCelular" runat="server" TextMode="Phone"/>
                </span> 
            </div>
            <div class="row">
                <span class="col-xs-9"> 
                 <asp:SqlDataSource ID="dsEspecializacao" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [id_especializacao], [nome_especializacao] FROM [ESPECIALIZACAO]"></asp:SqlDataSource>
                </span> 
                <span class="col-xs-2">
                 <br>
                 <asp:Button CssClass="btn-primary" Text="Salvar" Height="30px" ID="btnSalvar" runat="server" OnClick="btnSalvar_Click"/>
                </span> 
            </div>
        </div>
    </div>

</asp:Content>

