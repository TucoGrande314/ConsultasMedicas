<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RelatoriosSecretaria.aspx.cs" Inherits="Relatorios_RelatoriosSecretaria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row" style="">
            <div class="col-md-4" style="">
                <h3>Relatorio</h3>
            </div>
            <div class="col-md-8" style="">
                <h3>Relatório Selecionado</h3>
                    <asp:ListBox ID="ListBox1" runat="server">
                    <asp:ListItem Selected="True" Value="RelatorioConsultasMes.aspx">Consultas Mensais por Médico</asp:ListItem>
                    <asp:ListItem Value="RelatorioCancelamentosMes.aspx">Consultas Canceladas Mensalmente</asp:ListItem>
                </asp:ListBox>
            </div>
        </div>
    
</asp:Content>

