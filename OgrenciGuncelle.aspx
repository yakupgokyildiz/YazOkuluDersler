<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

  <form id="Form1" runat="server">
        <div class="form-group">
            <asp:Label for="Txtid" runat="server" Text="Öğrenci ID:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="Txtid" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numarası:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğrafı:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            <br />


        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>

</asp:Content>