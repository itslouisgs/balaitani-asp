<%@ Page Title="" Language="C#" MasterPageFile="~/View/Template.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="balaitani_psd.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-div d-flex align-items-center flex-column m-4">
        <h1>Login</h1>
        <div style="min-width : 30%;" class="bg-light p-4 rounded m-4" method="post">
            <div class="form-group my-2">
                <label for="email">Email</label>
                <asp:TextBox ID="emailTxt" class="form-control my-2" placeholder="Enter email"  runat="server"></asp:TextBox>
            </div>
            <div class="form-group my-2">
                <label for="password">Password</label>
                <asp:TextBox ID="passwordTxt" runat="server" class="form-control my-2" placeholder="Password"  TextMode="Password"></asp:TextBox>
            </div>
            <asp:Button ID="loginBtn" runat="server" Text="Login" class="btn btn-success w-100 mt-3" OnClick="loginBtn_Click"/>
            <asp:HyperLink ID="registerLink" class="btn btn-success w-100 mt-3" style="opacity: 0.7" runat="server" NavigateUrl="~/View/RegisterPage.aspx">Register</asp:HyperLink>
            <asp:Label ID="errorLbl" runat="server" Text="" class="text-danger"></asp:Label>
        </div>
    </div>
</asp:Content>
