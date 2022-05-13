<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="examen_parcial2.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar Pelicula</h1>
<p>
    Ingrese Pelicula
    <asp:TextBox ID="TextBoxPelicual" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
</p>
<p>
    <asp:Button ID="ButtonEliminar" runat="server" OnClick="ButtonEliminar_Click" Text="Eliminar" />
</p>
</asp:Content>
