<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="examen_parcial2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Pelicula</h1>
        <p>
            Titulo<asp:TextBox ID="TextBoxTitulo" runat="server"></asp:TextBox>
        </p>
        <p>
            Año<asp:TextBox ID="TextBoxLanzamiento" runat="server"></asp:TextBox>
        </p>
        <p>
            Genero<asp:TextBox ID="TextboxGenero" runat="server"></asp:TextBox>
        </p>
        <p>
            Estudio<asp:TextBox ID="TextBoxEstudio" runat="server"></asp:TextBox>
        </p>
        <p>
            Elenco</p>
        <p>
            Actor<asp:TextBox ID="TextBoxActor" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha de Nacimiento<asp:TextBox ID="TextboxFechaActor" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonAgregaActor" runat="server" OnClick="ButtonAgregaActor_Click" Text="Agregar Actor" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:Button ID="ButtonGuardar" runat="server" OnClick="ButtonGuardar_Click" Text="Guardar" />
        </p>
    </div>

    </asp:Content>
