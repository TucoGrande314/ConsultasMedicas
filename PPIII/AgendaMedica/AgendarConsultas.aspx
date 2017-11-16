<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AgendarConsultas.aspx.cs" Inherits="AgendarConsultas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Selecione o médico:"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="lbxMedicos" runat="server" Height="25px" Width="100px"></asp:ListBox>
    </p>
    <p>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Selecione a data:"></asp:Label>
        <asp:Calendar ID="cldDatas" runat="server"></asp:Calendar>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnAgendar" runat="server" Height="54px" OnClick="Button1_Click" Text="Agendar consulta" Width="212px" />
    </p>
    <p>
        <asp:Label ID="lblErro" runat="server" ForeColor="Red"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>

