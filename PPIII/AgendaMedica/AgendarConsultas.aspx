<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AgendarConsultas.aspx.cs" Inherits="AgendarConsultas" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <div>
        <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />
        <div class="col-xs-7">
            <h3>Agendar Consulta</h3>
            <hr style="border-color:rgba(0, 0, 0, 0.9)">
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
                <asp:Calendar ID="cldDatas" runat="server" SelectedDate="2017-11-09" OnSelectionChanged="cldDatas_SelectionChanged"></asp:Calendar>
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
        </div>
        <div class="col-xs-4">
          <h3>Agenda do Médico </h3>
          <hr style="border-color:rgba(0, 0, 0, 0.9)">
          <h5>consultas agendadas para o médico selecionado</h5>

          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="dsConsultas" Width="100%">
                <Columns>
                    <asp:BoundField DataField="inicio_consulta" HeaderText="Inicio" SortExpression="inicio_consulta" DataFormatString="{0:D5}" HtmlEncodeFormatString="False" />
                    <asp:BoundField DataField="fim_consulta" HeaderText="Fim" SortExpression="fim_consulta" DataFormatString="{0:D5}" ReadOnly="True" HtmlEncodeFormatString="False" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="dsConsultas" runat="server" ConnectionString="<%$ ConnectionStrings:BD16167ConnectionString %>" SelectCommand="SELECT [inicio_consulta], [fim_consulta] FROM [view_duracao_consulta] WHERE (([id_medico] = @id_medico) AND ([data_consulta] = @data_consulta))">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlMedicos" DefaultValue="0" Name="id_medico" PropertyName="SelectedValue" Type="Int32" />
                    <asp:ControlParameter ControlID="cldDatas" Name="data_consulta" PropertyName="SelectedDate" Type="DateTime" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

