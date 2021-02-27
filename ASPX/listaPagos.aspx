<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="listaPagos.aspx.cs" Inherits="JuanFer_Servers.ASPX.listaPagos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../Estilos/funcionesPanel.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Lista de Pagos</h2>
        <asp:GridView ID="gridListaPagos" class="gridListaPagos grilla" runat="server" AutoGenerateColumns="False" DataSourceID="SqlGrillaListaPagos">
            <Columns>
                <asp:BoundField DataField="Nombre y Apellido" HeaderText="Nombre y Apellido" ReadOnly="True" SortExpression="Nombre y Apellido" />
                <asp:BoundField DataField="Dispositivos" HeaderText="Dispositivos" SortExpression="Dispositivos" />
                <asp:BoundField DataField="Vencimiento" HeaderText="Vencimiento" SortExpression="Vencimiento" />
                <asp:BoundField DataField="Metodo de Pago" HeaderText="Metodo de Pago" SortExpression="Metodo de Pago" />
                <asp:BoundField DataField="Precio Final" HeaderText="Precio Final" SortExpression="Precio Final" />
                <asp:BoundField DataField="Servicio" HeaderText="Servicio" SortExpression="Servicio" />
                <asp:BoundField DataField="Recibido" HeaderText="Recibido" SortExpression="Recibido" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlGrillaListaPagos" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT CONCAT(C.Nombre,' ',C.Apellido) AS 'Nombre y Apellido', d.cant_dispositivos AS Dispositivos,
d.fecha_vencimiento AS Vencimiento, d.metodoPago AS 'Metodo de Pago', d.precio_final AS 'Precio Final',
s.descripcion AS Servicio, d.recibido AS Recibido FROM Detalle D
INNER JOIN Cliente C ON c.id = d.idCliente
INNER JOIN Servicio S ON s.cod_servicio = d.cod_servicio
ORDER BY d.id desc"></asp:SqlDataSource>
    </section>
</asp:Content>