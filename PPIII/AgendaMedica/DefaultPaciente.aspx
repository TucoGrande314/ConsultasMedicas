<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultPaciente.aspx.cs" Inherits="DefaultPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="imgProfilePic" runat="server" Height="160px" Width="120px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Nome:"></asp:Label>
        &nbsp;<asp:Label ID="lblNome" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="E-Mail"></asp:Label>
        &nbsp;<asp:Label ID="lblEmail" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Data de Nascimento:"></asp:Label>
        &nbsp;<asp:Label ID="lblDataNasc" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Celular"></asp:Label>
        &nbsp;<asp:Label ID="lblCelular" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Endereço:"></asp:Label>
    
    &nbsp;<asp:Label ID="lblEndereco" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
