<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agregarCliente.aspx.cs" Inherits="JuanFer_Servers.ASPX.agregarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/funcionesPanel.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fondo">
        <h2>Agregar nuevo Cliente</h2>
        <ul>
            <li>Nombre:     <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></li>
            <li>Apellido:   <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox></li>
            <!-- <li>Celular:    <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox></li> -->
            <li>Provincia:  <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox></li>
            <li>Ciudad:     <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox></li>
            <li>Vencimiento:<asp:TextBox ID="txtVencimiento" runat="server"></asp:TextBox></li>
            <li>Subdominio: <div style = "float: right" class="cajaSelect"><asp:DropDownList ID="dropSubdominio" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_subdominio" DataValueField="cod_subdominio"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:netfreePageConnectionString %>" SelectCommand="SELECT [cod_subdominio] FROM [Subdominio]"></asp:SqlDataSource>
            </div></li>
            <li>Usuario:    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox></li>
            <li>Contraseña: <asp:TextBox ID="txtPass" type="password" runat="server"></asp:TextBox></li>
        </ul>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
    </section>
</asp:Content>