<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="balaitani_psd.View.UpdateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-div d-flex align-items-center flex-column m-4">
    <h1>Update Product</h1>
        <div class="form-group my-2">
            <label for="name">Name</label>
            <input value="Test" type="text" class="form-control my-2" placeholder="Enter product name"
                name="name">
        </div>
        <div class="form-group my-2">
            <label for="price">Price</label>
            <div class="input-group my-2">
                <span class="input-group-text">Rp</span>
                <input value="123" type="number" class="form-control" placeholder="Enter Price"
                    name="price">
            </div>
        </div>
        <div class="form-group my-2">
            <label for="stock">Stock</label>
            <input value="123" type="number" class="form-control my-2" placeholder="Enter stock"
                name="stock">
        </div>
        <div class="form-group my-2">
            <label for="description">Description</label>
            <textarea type="password" class="form-control my-2" placeholder="Description"
                name="description">Test</textarea>
        </div>
        <div class="form-group my-2">
            <label for="image">Image</label>
            <input class="form-control my-2" type="file" name="image">
        </div>

        <button type="submit" class="btn btn-success w-100 my-3">Update</button>
</div>

</asp:Content>
