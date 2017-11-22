<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AgendarConsultas.aspx.cs" Inherits="AgendarConsultas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Selecione o médico:"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlMedicos" runat="server" DataSourceID="dsMedicos" DataTextField="nome" DataValueField="id_medico">
        </asp:DropDownList>
        <asp:SqlDataSource ID="dsMedicos" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [nome], [id_medico] FROM [Medico]"></asp:SqlDataSource>
    </p>
    <p>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Selecione a data e o horário "></asp:Label>
        <asp:Calendar ID="cldDatas" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:DropDownList ID="ddlHora" runat="server">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlMinuto" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Selecione a duração"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlDuracaoCons" runat="server">
        </asp:DropDownList>
        </p>
    <p>
        <asp:Button ID="btnAgendar" runat="server" Height="54px" OnClick="Button1_Click" Text="Agendar consulta" Width="212px" />
    </p>
    <p>
        <asp:Label ID="lblErro" runat="server" ForeColor="Red"></asp:Label>
    </p>
    <p>
    </p>
</asp:Content>

