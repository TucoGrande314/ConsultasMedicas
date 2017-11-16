<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioCancelamentosMes.aspx.cs" Inherits="Relatorios_RelatorioCancelamentosMes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:Chart ID="Chart1" runat="server" DataSourceID="dsCancelamentosMes" Palette="SeaGreen">
            <Series>
                <asp:Series Name="Series1" XValueMember="mes" YValueMembers="qtd_cancelamentos">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource ID="dsCancelamentosMes" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [mes], [qtd_cancelamentos], [id_mes] FROM [v_cancelamentos_mes] ORDER BY [qtd_cancelamentos]"></asp:SqlDataSource>
    </form>

</body>
</html>
