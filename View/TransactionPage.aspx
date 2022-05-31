<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="balaitani_psd.View.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container-fluid py-5 content">
    <h2 class="mb-5">Transactions</h2>
    <table class="table table-hover table-striped align-middle border shadow-sm">
        <thead class="">
          <tr >
            <th scope="col">Date of transaction</th>
            <th scope="col">Status</th>
            <th scope="col">Shipping</th>
            <th scope="col">Payment method</th>
            <th scope="col">Details</th>
          </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="listTransactions" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("transaction_date")  %></td>
                        <td class="@(@status == "success" ? "text-success" : "text-danger")"><%# Eval("status")  %></td>
                        <td><%# Eval("Shipping.name")  %></td>
                        <td><%# Eval("PaymentMethod.name")  %></td>
                        <td>
                            <asp:HyperLink ID="tdLink" NavigateUrl='<%# Eval("id", "~/View/TransactionDetailPage.aspx?id={0}") %>' class="btn btn-outline-success" runat="server">Details</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
      </table>
</div>
</asp:Content>
