<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="panel.aspx.cs" Inherits="JuanFer_Servers.ASPX.panel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/panel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="panel">
        <h2>Panel de control para administradores</h2>
        <!-- <hr> -->
        <ul>
            <li><a href="agregarPago.aspx">Agregar Nuevo Pago</a></li>
            <li><a href="listaPagos.aspx">Lista de Ultimos Pagos</a></li>
            <!-- <hr> -->
            <li><a href="agregarCliente.aspx">Agregar Nuevo Cliente</a></li>
            <li><a href="listaClientes.aspx">Lista de Clientes</a></li>
            <!-- <hr> -->
            <li class="ultima"><a href="agregarServidor.aspx">Agregar Nuevo Servidor</a></li>
            <li class="ultima"><a href="listaServidores.aspx">Lista de Servidores</a></li>
        </ul>
    </section>
</asp:Content>