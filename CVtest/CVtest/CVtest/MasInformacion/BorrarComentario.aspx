<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="BorrarComentario.aspx.cs" Inherits="CVtest.MasInformacion.BorrarComentarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="pnlError" Visible="false" CssClass="alert alert-danger">
        No se ha podido borrar ningun registro con los parametros enviados.
    </asp:Panel>
</asp:Content>
