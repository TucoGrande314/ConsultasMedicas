<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultMedico.aspx.cs" Inherits="DefaultMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <link href="./Content/defaultConsultas.css" rel="stylesheet" />
        <div class="row" style="">
            <div class="col-md-4" style="">
                <h3>Consulta Selecionada</h3>
                <hr style="border-color:rgba(0, 0, 0, 0.9)">
                <asp:Panel ID="pnlConsultaSelecionada" runat="server" Visible="False">
                    <b>Paciente:</b> <asp:Label ID="lbPaciente" runat="server"></asp:Label><br>
                    <b>Data:</b> <asp:Label ID="lbData" runat="server"></asp:Label><br>
                    <b>Hora:</b> <asp:Label ID="lbHorario" runat="server"></asp:Label><br><br>
                    <b>Status:</b><br>
                    <asp:RadioButtonList ID="rbStatus" runat="server" CellPadding="5" CellSpacing="5" CssClass="" RepeatDirection="Horizontal" Width="100%" Font-Bold="False">
                        <asp:ListItem Value="AGENDADA">&amp;nbsp;Agendada</asp:ListItem>
                        <asp:ListItem Value="OCORRIDA">&amp;nbsp;Ocorrida</asp:ListItem>
                        <asp:ListItem Value="CANCELADA">&amp;nbsp;Cancelada</asp:ListItem>
                    </asp:RadioButtonList>
                    <br>
                    <div class="container-fluid" style="padding:0">
                        <b>Diagnóstico</b><br>
                        <asp:TextBox ID="txtDiagnostico" runat="server" Height="150px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                        
                    </div>
                    <div class="container-fluid" style="padding:0">
                        <b>Medicamentos</b><br>
                        <asp:TextBox ID="txtMedicamentos" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </div>
                    <div class="container-fluid" style="padding:0">
                        <asp:Button ID="btnSalvar" runat="server" CssClass="btn-primary" Height="30px" Text="SALVAR" Width="100%" OnClick="btnSalvar_Click" />
                    </div>
                </asp:Panel>
            </div>
            <div class="col-md-8" style="">
                <h3>Consultas</h3>
                <hr style="border-color:rgba(0, 0, 0, 0.9)">
                <br>
                <asp:GridView ID="gvConsultas" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="5" CellSpacing="5" DataSourceID="dsConsultas" Height="100%" CssClass="gridView" OnSelectedIndexChanged="gvConsultas_SelectedIndexChanged" SelectedIndex="0">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True"/>
                        <asp:BoundField DataField="dados_paciente" HeaderText="Paciente" SortExpression="dados_paciente"/>
                        <asp:BoundField DataField="dados_medico" HeaderText="Médico" SortExpression="dados_medico" />
                        <asp:BoundField DataField="data_consulta" HeaderText="Data" SortExpression="data_consulta" />
                        <asp:BoundField DataField="inicio_consulta" HeaderText="Inicio" SortExpression="inicio_consulta" />
                        <asp:BoundField DataField="duracao" HeaderText="Duração (min)" SortExpression="duracao" />
                        <asp:BoundField DataField="stat" HeaderText="Status" SortExpression="stat" />
                        <asp:BoundField AccessibleHeaderText="Id" DataField="id_consulta" HeaderText="Id" SortExpression="idConsulta" />
                    </Columns>
                    <HeaderStyle CssClass="cell" />
                    <SelectedRowStyle BackColor="#D8D8D8" BorderColor="Black" BorderWidth="2px" />
                </asp:GridView>
                <asp:SqlDataSource ID="dsConsultas" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [dados_paciente], [dados_medico], [id_medico], [id_paciente], [data_consulta], [inicio_consulta], [duracao], [stat], [id_consulta] FROM [view_consultas]"></asp:SqlDataSource>
            </div>
        </div>
</asp:Content>

