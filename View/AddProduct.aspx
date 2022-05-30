﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="balaitani_psd.View.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-div d-flex align-items-center flex-column m-4">
        <h1>Add Product</h1>
        <div style="min-width: 30%;" class="bg-light p-4 rounded m-2">

            <div class="form-group my-2">
                <label for="name">Name</label>
                <asp:TextBox ID="nameTxt" runat="server" class="form-control my-2" placeholder="Enter product name"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="price">Price</label>
                <div class="input-group my-2">
                    <span class="input-group-text">Rp</span>
                    <asp:TextBox ID="priceTxt" runat="server" class="form-control" placeholder="Enter price"></asp:TextBox>
                </div>
            </div>
            <div class="form-group my-2">
                <label for="stock">Stock</label>
                <asp:TextBox ID="stockTxt" runat="server" class="form-control my-2" placeholder="Enter stock"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="description">Description</label>
                <asp:TextBox ID="descriptionTxt" runat="server" class="form-control my-2" placeholder="Enter description"></asp:TextBox>

            </div>
            <%--            <div class="form-group my-2">
                <label for="image">Image</label>
                <input class="form-control my-2" type="file" name="image">
                <asp:FileUpload ID="imageFile" runat="server" />
            </div>--%>
            <asp:Button ID="submitBtn" runat="server" class="btn btn-success w-100 my-3" Text="Add" OnClick="AddBtn_Click" />
            <asp:Label ID="errorLbl" runat="server" Text="" class="text-danger"></asp:Label>
        </div>

    </div>
</asp:Content>
