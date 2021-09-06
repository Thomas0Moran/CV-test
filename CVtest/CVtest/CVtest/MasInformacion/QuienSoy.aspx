<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site.Master" AutoEventWireup="true" CodeBehind="QuienSoy.aspx.cs" Inherits="CVtest.MasInformación.QuienSoy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
            <h1>¿quien soy?</h1>
            <p>Vitae tortor condimentum lacinia quis vel eros. Facilisi nullam vehicula ipsum a arcu cursus. Enim nunc faucibus a pellentesque sit amet porttitor eget. Lectus arcu bibendum at varius vel. Ac feugiat sed lectus vestibulum mattis. Id cursus metus aliquam eleifend. Facilisis sed odio morbi quis commodo. Facilisi etiam dignissim diam quis. Lorem mollis aliquam ut porttitor leo. Justo nec ultrices dui sapien eget mi proin. Leo a diam sollicitudin tempor id eu nisl nunc mi. Sodales ut eu sem integer vitae justo.</p>
    </div>
    <hr />
    <div class="row">
        <div class="col">
            <asp:ListView runat="server" ID="lstComentarios">
             <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="ItemPlaceHolder"></asp:PlaceHolder>
             </LayoutTemplate>

             <ItemTemplate>
              <div class="card">
               <div class="card-body">
                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                <p class="card-text"><%#Eval("Texto") %></p>
                <a href ="/MasInformacion/BorrarComentarios.aspx?id=<%#Eval("id")%>" class="btn btn-danger">Borar</a>
               </div>
              </div>
             </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
   <hr />

    <div class="row">
        <div class="col">
            <div class="form-group">
                <label>Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Comentarios</label>
                <asp:TextBox runat="server" ID="txtComentario" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-success" Text="Agregar comentario" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>


</asp:Content>
