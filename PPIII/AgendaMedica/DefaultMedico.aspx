<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DefaultMedico.aspx.cs" Inherits="DefaultMedico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

        <div class="row" style="">
            <div class="col-md-6" style="">
                <h3>Consultas</h3>
                <hr style="border-width: 2px; border-color:rgba(0, 0, 0, 0.9)">
                <br>
                <asp:GridView ID="GridView1" runat="server" Width="100%">
                    <Columns>
                        <asp:CheckBoxField AccessibleHeaderText="Presença" HeaderText="Presença">
                        <ItemStyle Width="50px" />
                        </asp:CheckBoxField>
                        <asp:HyperLinkField AccessibleHeaderText="Detalhes" HeaderText="Detalhes" Text="Detalhes">
                        <ItemStyle Width="50px" />
                        </asp:HyperLinkField>
                        <asp:BoundField AccessibleHeaderText="Paciente" FooterText="Paciente" HeaderText="Paciente" />
                        <asp:BoundField AccessibleHeaderText="Data" HeaderText="Data" />
                        <asp:BoundField AccessibleHeaderText="Horário" HeaderText="Horário" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="consultas" runat="server"></asp:SqlDataSource>
            </div>
            <div class="col-md-6" style="">
                asd
            </div>
        </div>
    
    
</asp:Content>

