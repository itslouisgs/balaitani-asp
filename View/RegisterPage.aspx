<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="balaitani_psd.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-div d-flex align-items-center flex-column m-4">
        <h1>Register</h1>
        <div style="min-width : 30%;" class="bg-light p-4 rounded m-2">
            <div class="form-group my-2">
                <label for="name">Name</label>
                <asp:TextBox ID="nameTxt" class="form-control my-2" placeholder="Enter your name" runat="server"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="email">Email</label>
                <asp:TextBox ID="emailTxt" class="form-control my-2" placeholder="Enter email" runat="server"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="password">Password</label>
                <asp:TextBox ID="passwordTxt" TextMode="Password" class="form-control my-2" placeholder="Enter password" runat="server"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="address">Address</label>
                <asp:TextBox ID="addressTxt" Height="100" class="form-control my-2 top" placeholder="Enter address" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="registerBtn" runat="server" class="btn btn-success w-100 my-3" Text="Register" OnClick="registerBtn_Click"/>
            <a href="/login" class="btn btn-success w-100" style="opacity: 0.7">Login</a>
            <asp:Label ID="errorLbl" runat="server" Text="" class="text-danger"></asp:Label>
        </div>
    </div>
</asp:Content>
