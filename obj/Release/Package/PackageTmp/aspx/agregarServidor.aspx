<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agregarServidor.aspx.cs" Inherits="JuanFer_Servers.agregarServidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Agregar nuevo Servidor</h2>
        <ul>
            <li><div class="Texto">Codigo:</div>             <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox></li>
            <li><div class="Texto">IP:</div>                 <asp:TextBox ID="txtIP" runat="server"></asp:TextBox></li>
            <li><div class="Texto">Proveedor:</div>          <asp:TextBox ID="txtProveedor" runat="server"></asp:TextBox></li>
            <li><div class="Texto">Precio:</div>             <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></li>
            <li><div class="Texto">vCPU:</div>               <asp:TextBox ID="txtvCPU" runat="server"></asp:TextBox></li>
            <li><div class="Texto">RAM:</div>                <asp:TextBox ID="txtRAM" runat="server"></asp:TextBox></li>
            <li><div class="Texto">Transferencia:</div>      <asp:TextBox ID="txtTransferencia" runat="server"></asp:TextBox></li>
            <li><div class="Texto">Bandwith:</div>           <asp:TextBox ID="txtBandwith" runat="server"></asp:TextBox></li>
            <li class="SO"><div class="Texto">Sistema Operativo:</div>  <div style = "float: right" class="cajaSelect">
                <asp:DropDownList ID="dropSO" runat="server">
                    <asp:ListItem Value="none">Ninguno</asp:ListItem>
                    <asp:ListItem>Ubuntu 14.04</asp:ListItem>
                    <asp:ListItem>Ubuntu 16.04</asp:ListItem>
                    <asp:ListItem>Ubuntu 18.04</asp:ListItem>
                    <asp:ListItem>Ubuntu 20.04</asp:ListItem>
                    <asp:ListItem>Debian 8</asp:ListItem>
                    <asp:ListItem>Debian 9</asp:ListItem>
                    <asp:ListItem>Debian 10</asp:ListItem>
                </asp:DropDownList>
            </div></li>
        </ul>
        <asp:Label ID="lblError" CssClass="mensaje error nodisplay" runat="server" Text="Error"></asp:Label>
        <asp:Label ID="lblConfirmacion" CssClass="mensaje confirmacion nodisplay" runat="server" Text="Servidor Agregado Correctamente"></asp:Label>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </section>
</asp:Content>