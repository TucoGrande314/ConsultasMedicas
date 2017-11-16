<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioConsultasMes.aspx.cs" Inherits="Relatorios_RelatorioConsultasMes" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            Médico:<br />
            <asp:DropDownList ID="dlMedicos" runat="server" DataSourceID="dsMedicos" DataTextField="nome" DataValueField="id_medico" Height="16px" Width="295px" AutoPostBack="True" OnSelectedIndexChanged="dlMedicos_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="dsMedicos" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [id_medico], [nome] FROM [Medico]"></asp:SqlDataSource>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Chart ID="chart" runat="server" DataSourceID="dsConsultasMes" Palette="SeaGreen" Width="306px">
                <series>
                    <asp:Series Name="Series1" XValueMember="mes" YValueMembers="qtd_consultas">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="dsConsultasMes" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [mes], [id_medico], [qtd_consultas] FROM [v_consultas_mes] WHERE ([id_medico] = @id_medico) ORDER BY [id_mes]">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dlMedicos" Name="id_medico" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </asp:Panel>
    </form>
    
</body>
</html>
