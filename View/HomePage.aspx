<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="balaitani_psd.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner position-relative overflow-hidden text-center d-flex flex-column justify-content-center align-items-center"
        style="height: 60vh;">
        <h1 class="text-light display-2 position-relative">Welcome to BalaiTani !</h1>
        <p class="text-light position-relative"><i>No. 1 App to support Indonesian local farmers</i></p>
        <a class="btn btn-outline-light position-relative" href="/about-us">About Us</a>
    </div>
    <div class="d-flex justify-content-center flex-wrap p-3">
        <asp:Repeater ID="rptProducts" runat="server">
            <ItemTemplate>
                <div class="card m-3 border-0 shadow" style="width: 18rem;border-radius: 15px;">
                    <img class="card-img-top" style="object-fit: cover;border-radius: 15px 15px 0 0;" height="280"
                        src="" alt="Product Image">
                    <div class="card-body">
                        <h5 class="card-title"> <%# Eval("name")  %></h5>
                        <i class="card-subtitle mb-2 text-success">
                            <%# Eval("User.name")  %>
                        </i>
                        <p class="card-text text-justify w-100" style="height: 50px;overflow: hidden;text-overflow: ellipsis;">
                            <%# Eval("description")  %>
                        </p>
                        <div class="d-flex justify-content-between align-items-center text-center">
                            <p class="m-0">Rp.<%# Eval("price")  %></p>
                            <asp:HyperLink ID="detailLink" NavigateUrl='<%# Eval("id", "~/View/ProductDetailPage.aspx?id={0}") %>' class="btn btn-outline-success" runat="server">Details</asp:HyperLink>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>    
</asp:Content>
