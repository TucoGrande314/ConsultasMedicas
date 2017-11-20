<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RelatorioConsultaEspecializacao.aspx.cs" Inherits="Relatorios_RelatorioConsultaEspecializacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:#F2F1EF">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body >
    <style>
        .txt{
            min-width : 30px;
        }
        .combo{
            min-width : 80px;
        }
        .linha{
            min-width : 225px;
            margin-bottom:10px;
            width:100%;
        }
        .botao{
            width:100%;
           
        }
    </style>
    <form id="form1" runat="server">
        <div class="">
            <div class="col-xs-4" style="height:500px; padding:10px; top: 0px; left: 0px;">
                <div class="linha">
                    <label>Ano</label><br/>
                    <asp:TextBox ID="txtAno" runat="server" CssClass="txt" Width="100%" Text="2017" TextMode="Number" >2017</asp:TextBox>
                </div>
                <div class="linha">
                    <label>Mês</label><br/>
                    <asp:DropDownList ID="ddlMes" runat="server" CssClass="combo" Width="100%" AutoPostBack="True">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">Janeiro</asp:ListItem>
                        <asp:ListItem Value="2">Fevereiro</asp:ListItem>
                        <asp:ListItem Value="3">Março</asp:ListItem>
                        <asp:ListItem Value="4">Abril</asp:ListItem>
                        <asp:ListItem Value="5">Maio</asp:ListItem>
                        <asp:ListItem Value="6">Junho</asp:ListItem>
                        <asp:ListItem Value="7">Julho</asp:ListItem>
                        <asp:ListItem Value="8">Agosto</asp:ListItem>
                        <asp:ListItem Value="9">Setembro</asp:ListItem>
                        <asp:ListItem Value="10">Outubro</asp:ListItem>
                        <asp:ListItem Value="11" Selected="True">Novembro</asp:ListItem>
                        <asp:ListItem Value="12">Dezembro</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="linha">
                    <asp:Button ID="Button1" runat="server" CssClass="btn-default botao" Text="Buscar" OnClick="Button1_Click" />
                </div> 
                <asp:Chart ID="Chart1" runat="server" DataSourceID="dsConsultaEspecializacao" BackImageWrapMode="Scaled" IsSoftShadows="False" Palette="SeaGreen">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="nome_especializacao" YValueMembers="qtd_consultas">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
            </div>
  
                

            <asp:SqlDataSource ID="dsConsultaEspecializacao" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="sp_relatorio_consultas_especializacao" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:Parameter Name="dia" Type="String" DefaultValue=" " />
                    <asp:ControlParameter ControlID="ddlMes" DefaultValue="" Name="mes" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="txtAno" DefaultValue="" Name="ano" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
   
        </div>

        
    </form>
</body>
</html>
