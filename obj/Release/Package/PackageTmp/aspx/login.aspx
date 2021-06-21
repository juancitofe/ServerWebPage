<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="JuanFer_Servers.ASPX.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilos/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login">
        <div class="contenedor">
            <h2>Iniciar Sesión</h2>

            <label for="user">Usuario</label>
            <asp:TextBox ID="txtUser" class="escribe" placeholder="Ingrese el Usuario" runat="server"></asp:TextBox>
            <!-- <input class="escribe" type="text" placeholder="Ingrese el Usuario"> -->

            <label for="password">Contraseña</label>
            <asp:TextBox ID="txtPass" CssClass="escribe" type="password" placeholder="Ingrese la Contraseña" runat="server"></asp:TextBox>
            <!-- <input class="escribe " type="password" placeholder="Ingrese la Contraseña"> -->

            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" onclick="loginClick" />
            <!-- <input type="submit" value="Ingresar">     -->

            <a href="admin.aspx">Ingresar como Administrador</a>
        </div>
    </div>
</asp:Content>