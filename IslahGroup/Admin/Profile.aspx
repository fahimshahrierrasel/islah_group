<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="IslahGroup.Admin.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 210px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Profile</h1>
        <table class="w-100 p-3">
            <tr>
                <td class="auto-style1">Full Name</td>
                <td>
                    <asp:Label ID="LabelFullName" runat="server" Text="Jon Doe"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <asp:Label ID="LabelEmail" runat="server" Text="example@example.com"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">Username</td>
                <td>
                    <asp:Label ID="LabelUsername" runat="server" Text="Username"></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">UserType</td>
                <td>
                    <asp:Label ID="LabelUserType" runat="server" Text="Type"></asp:Label></td>
            </tr>
        </table>
        <asp:HyperLink runat="server" CssClass="btn btn-warning m-3" Text="Change Password" NavigateUrl="~/Admin/ChangePassword.aspx"></asp:HyperLink>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
