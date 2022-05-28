<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="balaitani_psd.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Products</p>
    <asp:GridView ID="gvProducts" runat="server">
    </asp:GridView>
</asp:Content>
