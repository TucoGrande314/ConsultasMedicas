<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultPaciente.aspx.cs" Inherits="DefaultPacient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div> 
        <div style="top:5px; left:5px; Height:280px; Width:210px"><asp:Image ID="imgProfilePic" runat="server" Height="280px" Width="210px" /></div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <div  style="position:relative; top:-290px; left:220px;>
       <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Nome:" Font-Size="X-Large"></asp:Label>
        &nbsp;
        <asp:Label ID="lblNome" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="E-Mail" Font-Size="X-Large"></asp:Label>
        &nbsp;<asp:Label ID="lblEmail" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Data de Nascimento:" Font-Size="X-Large"></asp:Label>
        &nbsp;<asp:Label ID="lblDataNasc" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Celular" Font-Size="X-Large"></asp:Label>
        &nbsp;<asp:Label ID="lblCelular" runat="server" Font-Size="X-Large"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Endereço:" Font-Size="X-Large"></asp:Label>
    
    &nbsp;<asp:Label ID="lblEndereco" runat="server" Font-Size="X-Large"></asp:Label>
    </div>
    </div>
 </asp:Content>

