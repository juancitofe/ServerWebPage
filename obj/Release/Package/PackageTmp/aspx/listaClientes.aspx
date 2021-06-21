<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="listaClientes.aspx.cs" Inherits="JuanFer_Servers.listaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Lista de Clientes</h2>
        <asp:TextBox ID="txtBuscar" CssClass="busqueda" placeholder="Buscar por nombre" runat="server" OnTextChanged="txtBuscar_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:GridView ID="gridClientes" CssClass="gridClientes grilla" runat="server" AutoGenerateColumns="False" DataKeyNames="#" DataSourceID="sqlGrillaClientes">
            <Columns>
                <asp:BoundField DataField="#" HeaderText="#" InsertVisible="False" ReadOnly="True" SortExpression="#" />
                <asp:BoundField DataField="Nombre y Apellido" HeaderText="Nombre y Apellido" SortExpression="Nombre y Apellido" ReadOnly="True" />
                <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" SortExpression="Ciudad" ReadOnly="True" />
                <asp:BoundField DataField="Vencimiento" HeaderText="Vencimiento" SortExpression="Vencimiento" ReadOnly="True" />
                <asp:BoundField DataField="Subdominio" HeaderText="Subdominio" SortExpression="Subdominio" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sqlGrillaClientes" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT id as #, Concat(c.Nombre,' ',c.Apellido) as 'Nombre y Apellido' , Concat(Provincia,' - ',Ciudad) as Ciudad,
FORMAT(c.uVencimiento, 'dd/mm/yy') as Vencimiento, Subdominio
FROM Cliente c
INNER JOIN Subdominio s ON c.cod_subdominio = s.cod_subdominio
WHERE (Nombre &lt;&gt; '')">
        </asp:SqlDataSource>
    </section>
</asp:Content>