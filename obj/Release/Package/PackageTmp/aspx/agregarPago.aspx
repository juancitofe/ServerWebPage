<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agregarPago.aspx.cs" Inherits="JuanFer_Servers.ASPX.agregarPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Agregar un nuevo pago</h2>
        <asp:TextBox ID="txtBuscar" CssClass="busqueda" placeholder="Buscar por nombre..." runat="server" AutoPostBack="True" OnTextChanged="txtBuscar_TextChanged"></asp:TextBox>
        <asp:ListBox ID="listClientes" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listClientes_SelectedIndexChanged"></asp:ListBox>
        <ul class="ulPago">
            <li>Nombre del Cliente <br> <asp:TextBox ID="txtNombre" ReadOnly="True" runat="server"></asp:TextBox> </li>
            <li>Cantidad de Dispositivos <br> <asp:TextBox ID="txtCantDisp" placeholder="1" runat="server" AutoPostBack="True" OnTextChanged="txtCantDisp_TextChanged"></asp:TextBox></li>
            <li>Servicio: <br> <div class="cajaSelect"><asp:DropDownList ID="dropServicio" runat="server" DataSourceID="SqlDropServicio" DataTextField="nombre" DataValueField="cod_servicio" OnSelectedIndexChanged="dropServicio_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDropServicio" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT [nombre], [cod_servicio] FROM [Servicio]"></asp:SqlDataSource>
            </div></li>
            <li>Promocion <br> <div class="cajaSelect"> <asp:DropDownList ID="dropPromo" runat="server" DataSourceID="SqlDropPromo" DataTextField="cod_prom" DataValueField="cod_prom" AutoPostBack="True" OnSelectedIndexChanged="dropPromo_SelectedIndexChanged"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDropPromo" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT [cod_prom] FROM [Promocion] ORDER BY [cod_prom] DESC"></asp:SqlDataSource>
                </div></li>
            <li>Precio Final <br> <asp:TextBox ID="txtPrecioFinal" runat="server" ReadOnly="True"></asp:TextBox> </li>
            <li>Fecha Inicio <br> <asp:TextBox ID="txtFecha" runat="server" ReadOnly="True"></asp:TextBox> <asp:Button ID="btnCalendar" class="btnCalendar" runat="server" Text="Elegir Fecha" OnClick="btnCalendar_Click" /> <br /> <asp:Calendar ID="calendarPago" CssClass="nodisplay" runat="server" OnSelectionChanged="calendarPago_SelectionChanged"></asp:Calendar></li>
            <li>Metodo de Pago <br> <div class="cajaSelect"><asp:DropDownList ID="dropPago" runat="server" DataSourceID="SqlDropPago" DataTextField="cod_pago" DataValueField="cod_pago"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDropPago" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT [cod_pago] FROM [Pago]"></asp:SqlDataSource></div>
            </li>
            <li>Recibido <asp:CheckBox ID="chkRecibido" runat="server" /> </li>
        </ul>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </section>
</asp:Content>