<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="balaitani_psd.View.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-fluid py-5 content">
        <h2 class="mb-5">My Cart</h2>

        <div class="w-100">
            <asp:Label runat="server" class="details d-flex gap-5" ID="emptyCartErrorContainer">
                <div class="alert alert-danger w-100" role="alert">
                    Your cart is empty! Back to <a href="HomePage.aspx" class="underline" style="color: inherit;">Main Menu</a>?
                </div>
            </asp:Label>
            <asp:Label ID="cartContainer" class="details d-flex gap-5" runat="server">

                <ul class="list-group" style="min-width: 72.5%">
                    <asp:Repeater ID="rptCarts" runat="server" OnItemCommand="rptCarts_ItemCommand">
                        <ItemTemplate>
                            <li class="list-group-item shadow rounded d-flex align-items-center w-100 p-4 gap-4 mb-3">
                                <div class="d-flex gap-5 w-100" style="">
                                    <div class="" style="width: 15%">
                                        <asp:Image ID="Image1" runat="server" alt="Product Image" class="w-100" style="border-radius: 12px;" ImageUrl='<%# "~/Asset/" +  Eval("Product.image")  %>'/>
                                    </div>
                                    <div class="" style="width: 85%">
                                        <h5 class="fw-normal"><%# Eval("Product.name")  %></h5>
                                        <p class="fw-bold">Rp <%# Eval("Product.price")  %></p>
                                        <div class="d-flex justify-content-between">
                                            <asp:HyperLink ID="detailLink" NavigateUrl='<%# Eval("Product.id", "~/View/ProductDetailPage.aspx?id={0}") %>' class="btn btn-success" runat="server">Details</asp:HyperLink>
                                            <div class="d-flex gap-3">
                                                <asp:LinkButton ID="deleteBtn" class="btn btn-outline-danger" runat="server" CommandName="deleteCart" CommandArgument='<%# Eval("Product.id")  %>'><i
                                                        class="fal fa-trash-alt"></i></asp:LinkButton>
                                                <div class="input-group" style="width: 150px">
                                                    <span class="input-group-text">Quantity</span>
                                                    <asp:TextBox ID="quantityTxt" TextMode="Number" Text='<%# Eval("quantity")  %>' class="form-control" OnTextChanged="quantityTxt_TextChanged" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <div class="card shadow p-4" style="min-width: 27.5%; height: fit-content;">
                    <h5>Summary</h5>
                    <ul class="my-3 p-0 d-flex flex-column gap-2">
                        <li class="d-flex justify-content-between">
                            <span>Subtotal</span>
                            <span>Rp <asp:Label ID="subTotalLbl" runat="server" Text=""></asp:Label></span>
                        </li>
                        <li class="d-flex justify-content-between">
                            <span>Tax</span>
                            <span>Rp <asp:Label ID="taxLbl" runat="server" Text=""></asp:Label></span>
                        </li>
                        <li class="d-flex justify-content-between">
                            <span>Discount</span>
                            <span>-Rp 0,00</span>
                        </li>
                        <hr class="my-2" />
                        <li class="d-flex justify-content-between">
                            <span class="fw-bold">Total</span>
                            <span class="fw-bold">Rp <asp:Label ID="totalLbl" runat="server" Text=""></asp:Label></span>
                        </li>
                    </ul>

                    <a href="/checkout" class="btn btn-success mt-2 w-100"><i class="fas fa-cash-register me-2"></i>Check
                        out</a>
                </div>
            </asp:Label>

        </div>

    </div>

</asp:Content>
