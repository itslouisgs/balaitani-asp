<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="ProductDetailPage.aspx.cs" Inherits="balaitani_psd.View.ProductDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="details d-flex justify-content-around content py-5">
        <div>
            <img src="" alt="Product Image" class="border"
                style="border-radius:12px" width="300">
        </div>
        <div class="w-50">
            <div class="d-flex justify-content-between align-items-center">
                <h1>
                    <asp:Label ID="nameLbl" runat="server" Text=""></asp:Label></h1>
                    <div class="d-flex">
                        <a href="/product/id/update" class="btn btn-outline-success mx-2"><i
                                class="fal fa-pencil"></i></a>
                        <form action="/product/id/delete" method="POST">
                            
                            <button type="submit" class="btn btn-outline-danger"><i class="fal fa-trash-alt"></i></button>
                        </form>
                    </div>
            </div>
            <p>Seller: <b class="text-success">seller</b>
            </p>
            <p>desc</p>
        </div>
        <div class="action" style="min-width: 20%">
            <div class="border p-3" style="border-radius:12px">
                <h3>Rp.price</h3>
                <p>Stock: stock</p>
                <form action="/cart/add/id" method="POST">
                    <div class="input-group">
                        <span class="input-group-text">Quantity</span>
                        <input type="number" class="form-control" placeholder="0" name="quantity" value="1">
                    </div>
                        <p class="text-danger">qty</p>
                    <button type="submit" class="btn btn-outline-success w-100 my-3">
                        Add to Cart <i class="fal fa-cart-plus mx-1"></i>
                    </button>
                        <div class="alert alert-success mt-3">
                        </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
