<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="servidor.aspx.cs" Inherits="JuanFer_Servers.aspx.editsv" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Editar Servidor <asp:Label ID="lblCodigo" runat="server" Text=""></asp:Label></h2>
        <asp:Label ID="lblMensaje" CssClass="nodisplay" runat="server"></asp:Label>
        <asp:Label ID="lblError" CssClass="mensaje error nodisplay" runat="server" Text="Error"></asp:Label>
        <ul>
            <li>Codigo: (*)<asp:TextBox ID="txtCod" runat="server"></asp:TextBox></li>
            <li>IP del Servidor: (*)<asp:TextBox ID="txtIP" runat="server"></asp:TextBox></li>
            <li>Proveedor: (*)<asp:TextBox ID="txtProveedor" runat="server"></asp:TextBox></li>
            <li>Precio: <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox></li>
            <li>vCPU: <asp:TextBox ID="txtvCPU" runat="server"></asp:TextBox></li>
            <li>RAM: <asp:TextBox ID="txtRAM" runat="server"></asp:TextBox></li>
            <li>Transferencia: <asp:TextBox ID="txtTransferencia" runat="server"></asp:TextBox></li>
            <li>Bandwith: <asp:TextBox ID="txtBandwith" runat="server"></asp:TextBox></li>
            <li class="SO"><div class="Texto">Sistema Operativo:</div> <div style = "float: right" class="cajaSelect">
                <asp:DropDownList ID="dropSO" runat="server" AutoPostBack="True">
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
            <li class="campoObligatorio"><label class="campoObligatorio">(*) Campo Obligatorio</label></li>      
        </ul>

        <section class="CRUD">
            <a class="btn btnVolver" href="listaServidores.aspx"> Volver</a>
            <asp:Button ID="btnEditar" class="btn btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
            <asp:Button ID="btnBorrar" class="btn btnBorrar" runat="server" Text="Eliminar" OnClientClick="if(!confirm('¿Está seguro de eliminar el servidor?'))return false" OnClick="btnBorrar_Click"/>            
        </section>
    </section>
</asp:Content>
