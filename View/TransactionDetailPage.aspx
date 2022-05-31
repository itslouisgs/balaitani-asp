<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="balaitani_psd.View.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-fluid py-5 content">
        <h2 class="mb-5">
            Details
        </h2>

        <div class="shadow rounded p-5 w-100" style="overflow-x: scroll">
            <ul class="d-flex flex-column gap-2 w-50 px-0 pb-4">
                <li class="d-flex">
                    <span class="w-50 fw-bold">Date of transaction</span>
                    <asp:Label ID="tDate" runat="server" Text=""></asp:Label>
                </li>
                <li class="d-flex">
                    <span class="w-50 fw-bold">Status</span>
                    <asp:Label ID="tStatus" runat="server" Text=""></asp:Label>
                </li>
                <li class="d-flex">
                    <span class="w-50 fw-bold">Shipping</span>
                    <asp:Label ID="tShipping" runat="server" Text=""></asp:Label>
                </li>
                <li class="d-flex">
                    <span class="w-50 fw-bold">Payment method</span>
                    <asp:Label ID="tPaymentMethod" runat="server" Text=""></asp:Label>
                </li>
            </ul>
            <table class="table table-hover align-middle border">
                <thead class="table-secondary">
                    <tr>
                        <th scope="col" class="border-bottom-0 ps-4">Product</th>
                        <th scope="col" class="border-bottom-0 text-end ps-3">Price</th>
                        <th scope="col" class="border-bottom-0 text-end ps-3">Quantity</th>
                        <th scope="col" class="border-bottom-0 text-end ps-3 pe-4">Total Price</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th scope="row" class="ps-4 pe-3 d-flex align-items-center gap-4 w-fit-content">
                                    <asp:Image ID="Image1" runat="server" AlternateText="Product Image" Width="100" CssClass="my-2" style="border-radius:12px;" />
                                    <p class="mb-0"><asp:Label ID="tName" runat="server" Text=""></asp:Label></p>
                                </th>
                                <td class="text-end ps-3">Rp <asp:Label ID="tPrice" runat="server" Text=""></asp:Label></td>
                                <td class="text-end ps-3">
                                    <asp:Label ID="tQuantity" runat="server" Text=""></asp:Label>
                                </td>
                                <td class="text-end ps-3 pe-4">Rp <asp:Label ID="tTotal" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="3" class="text-end ps-4 fw-bold">Subtotal</td>
                        <td class="text-end pe-4">Rp {{ number_format($total, 2) }}</td>
                    </tr>
                    <tr>
                        <td colspan="3" class="text-end fw-bold">Shipping Fee</td>
                        <td class="text-end pe-4">Rp <asp:Label ID="tShippingFee" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="3" class="text-end fw-bold">Discount</td>
                        <td class="text-end pe-4">-Rp 0.00</td>
                    </tr>
                    <tr>
                        <td colspan="3" class="text-end fw-bold">Net Total</td>
                        <td class="text-end pe-4 fw-bold">Rp
                            {{ number_format($total + $detail->first()->shipping->price, 2) }}</td>
                    </tr>
                </tfoot>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </table>
        </div>

    </div>
</asp:Content>
