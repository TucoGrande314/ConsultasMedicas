<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="RelatoriosSecretaria.aspx.cs" EnableEventValidation="false" Inherits="Relatorios_RelatoriosSecretaria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row" style="">
            <div class="col-md-3" style="">
                <h5>Relatórios</h5>
                    <asp:ListBox ID="lbRelatorio" runat="server" AutoPostBack="True" Width="100%" OnSelectedIndexChanged="lbRelatorio_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Value="RelatorioConsultasMes.aspx">Consultas Mensais por Médico</asp:ListItem>
                    <asp:ListItem Value="RelatorioCancelamentosMes.aspx">Consultas Canceladas Mensalmente</asp:ListItem>
                        <asp:ListItem Value="RelatorioConsultaEspecializacao.aspx">Consultas por Especialidade  (Mês e Ano)</asp:ListItem>
                </asp:ListBox>
            </div>
            <div class="col-md-9" style="height:100%">
                <iframe src="./Relatorios/<%= lbRelatorio.SelectedValue %>" style="width:100%; border:0; height: 500px"/>
            </div>
    </div>
    </div>
</asp:Content>

