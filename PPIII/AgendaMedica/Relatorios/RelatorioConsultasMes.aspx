<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioConsultasMes.aspx.cs" Inherits="Relatorios_RelatorioConsultasMes" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-color: rgba(0,0,0,0)">
    
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <h5>Médico</h5>
            <asp:DropDownList ID="dlMedicos" runat="server" DataSourceID="dsMedicos" DataTextField="nome" DataValueField="id_medico" Height="16px" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="dlMedicos_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="dsMedicos" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [id_medico], [nome] FROM [Medico]"></asp:SqlDataSource>
            <br/><br/>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Chart ID="chart" runat="server" DataSourceID="dsConsultasMes" Palette="SeaGreen">
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
