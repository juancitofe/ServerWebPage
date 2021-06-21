<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="listaServidores.aspx.cs" Inherits="JuanFer_Servers.ASPX.listaServidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
    <link rel="stylesheet" href="//cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css"/>

    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="//cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
    <script>
        $(document).ready( function () {
         $('#gridServidores').DataTable();
        } );
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Lista de Servidores</h2>
        <asp:GridView ID="gridServidores" class="gridServidores grilla" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="sqlGridServidores" OnSelectedIndexChanged="gridServidores_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                <asp:BoundField DataField="IP" HeaderText="IP" SortExpression="IP" />
                <asp:BoundField DataField="Proveedor" HeaderText="Proveedor" SortExpression="Proveedor" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sqlGridServidores" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT cod_servidor AS Codigo, cod_ip AS IP, Proveedor, Precio FROM Servidores"></asp:SqlDataSource>
    </section>
</asp:Content>