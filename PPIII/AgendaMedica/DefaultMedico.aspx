<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultMedico.aspx.cs" Inherits="DefaultMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <link href="./Content/defaultConsultas.css" rel="stylesheet" />
        <div class="row" style="">
            <div class="col-md-6" style="">
                <h3>Consultas</h3>
                <hr style="border-color:rgba(0, 0, 0, 0.9)">
                <br>
                <asp:GridView ID="gvConsultas" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="5" CellSpacing="5" DataSourceID="dsConsultas" Height="100%" CssClass="gridView">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True"/>
                        <asp:BoundField DataField="dados_paciente" HeaderText="Paciente" SortExpression="dados_paciente"/>
                        <asp:BoundField DataField="dados_medico" HeaderText="Médico" SortExpression="dados_medico" />
                        <asp:BoundField DataField="data_consulta" HeaderText="Data" SortExpression="data_consulta" />
                        <asp:BoundField DataField="inicio_consulta" HeaderText="Inicio" SortExpression="inicio_consulta" />
                        <asp:BoundField DataField="duracao" HeaderText="Duração (min)" SortExpression="duracao" />
                    </Columns>
                    <HeaderStyle CssClass="cell" />
                </asp:GridView>
                <asp:SqlDataSource ID="dsConsultas" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [dados_paciente], [dados_medico], [id_medico], [id_paciente], [data_consulta], [inicio_consulta], [duracao] FROM [view_consultas]"></asp:SqlDataSource>
            </div>
            <div class="col-md-6" style="">
                <h3>Consulta Selecionada</h3>
                <hr style="border-color:rgba(0, 0, 0, 0.9)">
                <br>
                <asp:Panel ID="pnlConsultaSelecionada" runat="server" Visible="False">
                    <b>Paciente:</b> <asp:Label ID="lbPaciente" runat="server"></asp:Label>
                    <b>&nbsp;Data:</b> <asp:Label ID="lbData" runat="server"></asp:Label>
                </asp:Panel>
            </div>
        </div>
</asp:Content>

