<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="ProductDetailPage.aspx.cs" Inherits="balaitani_psd.View.ProductDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="details d-flex justify-content-around content py-5">
        <div>
            <asp:Image ID="productImg" runat="server" alt="Product Image" class="border" style="border-radius:12px" width="300"/>
        </div>
        <div class="w-50">
            <div class="d-flex justify-content-between align-items-center">
                <h1>
                    <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label>
                </h1>
                <div class="d-flex">
                    <%--<a href="/product/id/update" class="btn btn-outline-success mx-2">
                        <i class="fal fa-pencil"></i>
                    </a>--%>
                    <asp:LinkButton ID="editBtn" OnClick="editBtn_Click" runat="server" class="btn btn-outline-success mx-2"><i class="fal fa-pencil"></i></asp:LinkButton>
                    <asp:LinkButton ID="trashBtn" runat="server" class="btn btn-outline-danger"><i class="fal fa-trash-alt"></i></asp:LinkButton>
                </div>
            </div>
            <p>
                Seller: <b class="text-success"><asp:Label ID="sellerLbl" runat="server" Text=""></asp:Label></b>
            </p>
            <asp:Label ID="descLbl" runat="server" Text="Label"></asp:Label>
            
            </div>
        <div class="action" style="min-width: 20%">
            <div class="border p-3" style="border-radius:12px">

                <h3>Rp. <asp:Label ID="priceLbl" runat="server" Text=""></asp:Label></h3>
                <p>Stock: <asp:Label ID="stockLbl" runat="server" Text=""></asp:Label></p>
                <div class="input-group">
                    <span class="input-group-text">Quantity</span>
                    <asp:TextBox ID="quantityTxt" class="form-control" placeholder="0" runat="server"></asp:TextBox>
                </div>
                <%--<p class="text-danger">The product quantity must be atleast 1</p>--%>
                <asp:Label ID="errorLbl" runat="server" Text="" class="text-danger"></asp:Label>
                <asp:LinkButton ID="cartBtn" runat="server" class="btn btn-outline-success w-100 my-3">Add to Cart <i class="fal fa-cart-plus mx-1"></i></asp:LinkButton>
                <div class="alert alert-success mt-3">
                    <p class=" text-success" style="text-align: center; margin:auto">Item succesfully added to cart!</p>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
