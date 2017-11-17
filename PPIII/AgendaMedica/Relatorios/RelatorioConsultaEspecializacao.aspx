<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioConsultaEspecializacao.aspx.cs" Inherits="Relatorios_RelatorioConsultaEspecializacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
    <style>
        .txt{
            min-width : 30px;
        }
        .combo{
            min-width : 80px;
        }
        .coluna{
            min-width : 225px;
        }
        .botao{
            margin:20px
        }
    </style>
    <form id="form1" runat="server">
    <div class="container-fluid row">
        <div class="col-xs-3 coluna">
            <div class="col-xs-6">
                <label>Ano</label><br/>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="txt" Width="100%" ></asp:TextBox>
            </div>
            <div class="col-xs-6">
                 <label>Filtrar</label><br/>
                <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" TextAlign="Left" Width="100%" />
            </div>
        </div>
        <div class="col-xs-3 coluna">
            <div class="col-xs-6">
                <label>Mês</label><br/>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="combo" Width="100%">
                </asp:DropDownList>
            </div>
            <div class="col-xs-6 ">
                 <label>Filtrar</label><br/>
                <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" TextAlign="Left" />
            </div>
        </div>
        <div class="col-xs-3 coluna">
            <div class="col-xs-6">
                <label>Dia</label><br/>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="txt" Width="100%"></asp:TextBox>
            </div>
            <div class="col-xs-6">
                <label>Filtrar</label><br/>
                <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" TextAlign="Left" />
            </div>
        </div>
        <div class="col-xs-3 coluna">
            <asp:Button ID="Button1" runat="server" CssClass="btn-default botao" Text="Buscar" />
        </div> 
    </div> 
        
        <asp:Chart ID="Chart1" runat="server" DataSourceID="dsConsultaEspecializacao">
            <Series>
                <asp:Series Name="Series1">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource ID="dsConsultaEspecializacao" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
