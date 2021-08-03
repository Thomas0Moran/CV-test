<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CVtest.MasInformacion.Ocupacion.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Enim praesent elementum facilisis leo vel fringilla est ullamcorper. Ullamcorper morbi tincidunt ornare massa. Risus pretium quam vulputate dignissim suspendisse in est ante in. Neque convallis a cras semper auctor. Lorem ipsum dolor sit amet consectetur adipiscing. Morbi non arcu risus quis varius. Diam volutpat commodo sed egestas egestas fringilla phasellus faucibus scelerisque.Natoque penatibus et magnis dis. Sapien eget mi proin sed libero enim. In iaculis nunc sed augue lacus viverra. Eget lorem dolor sed viverra. Dignissim convallis aenean et tortor at risus viverra adipiscing at. In nibh mauris cursus mattis molestie a iaculis. Auctor eu augue ut lectus arcu bibendum at varius.
    <hr />
    <h5>Contador de variables con ViewState</h5>
    <asp:Label runat="server" ID="iblContadorViewState">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContadorViewState" CssClass="btn btn-primary" Text="Incrementar (con View State)" OnClick="btnContadorViewState_Click" />
    <hr />
    <h5>Contador de variables con Sessions</h5>
    <asp:Label runat="server" ID="lblContadorSessions">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContarSession" CssClass="btn btn-primary" Text="Incrementar (con Session)" OnClick="btnContarSession_Click" />
    <hr />
    <h5>Contador de variables con Cookies</h5>
    <asp:Label runat="server" ID="iblContadorCookies">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContarCookies" CssClass="btn btn-primary" Text="Incrementar (DESACTIVADO*error*)" OnClick="btnContarCookies_Click" />
    <hr />


</asp:Content>
