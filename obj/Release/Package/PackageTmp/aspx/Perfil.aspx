<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="JuanFer_Servers.ASPX.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/perfil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="perfil">
        <h2>Bienvenido <asp:Label ID="lblNombreUsr" runat="server" Text=""></asp:Label> </h2>
        <div class="contenedor">
            <section class="sct1">
                <div>
                    <img src="../Imagenes/perfil-vacio.jpg" alt="foto de perfil">
                </div>
                <asp:Button ID="btnCargarImg" runat="server" Text="Cargar Imagen" />
                <br />
                <asp:Button class="logout" ID="btnLogout" runat="server" Text="Cerrar Sesión" OnClick="btnLogout_Click" />
            </section>
            <section class="sct2">
                <h3>Datos del Usuario</h3>
                <ul>
                    <li>Nombre <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True"></asp:TextBox></li>
                    <li>Apellido <asp:TextBox ID="txtApellido" runat="server" ReadOnly="True"></asp:TextBox></li>
                    <%-- <li>Celular <asp:TextBox ID="txtCelular" runat="server" ReadOnly="True"></asp:TextBox></li> --%>
                    <li>Provincia <asp:TextBox ID="txtProvincia" runat="server" ReadOnly="True"></asp:TextBox></li>
                    <li>Ciudad <asp:TextBox ID="txtCiudad" runat="server" ReadOnly="True"></asp:TextBox></li>
                    <li>Vencimiento <asp:TextBox ID="txtUVenc" runat="server" ReadOnly="True"></asp:TextBox></li>
                </ul>
            </section>
        </div>
    </div>
</asp:Content>