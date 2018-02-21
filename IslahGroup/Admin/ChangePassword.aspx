<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="IslahGroup.Admin.ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <form id="formexpn" runat="server">
            <div class="card-header">Update Profile</div>
            <div class="card-body p-3">
                <div class="form-group">
                    <label for="TextBoxCurrentPass" class="col-form-label">Current Password:</label>
                    <asp:TextBox ID="TextBoxCurrentPass" CssClass="form-control" runat="server" placeholder="Current Password" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxPass" class="col-form-label">New Password:</label>
                    <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxConfPass" class="col-form-label">Confirm Password:</label>
                    <asp:TextBox ID="TextBoxConfPass" CssClass="form-control" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="card-footer text-right">
                <asp:HyperLink ID="HyperLinkCancel" CssClass="btn btn-success" runat="server">Cancel</asp:HyperLink>
                <asp:Button ID="ButtonUpdateUser" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonUpdateUser_Click"/>
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#formexpn').validate({
                rules: {
                    <%=TextBoxCurrentPass.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxPass.UniqueID%>: {
                        required: true,
                        minlength: 8
                    },
                    <%=TextBoxConfPass.ClientID%>: {
                        required: true,
                        minlength: 8,
                        equalTo: "#<%=TextBoxPass.UniqueID%>"
                    }
                },
                errorElement: "div",
                errorPlacement: function (error, element) {
                    error.addClass("invalid-feedback");
                    error.insertAfter(element);
                },
                highlight: function (element, errorClass, validClass) {
                    $(element).addClass("is-invalid").removeClass("is-valid");
                },
                unhighlight: function (element, errorClass, validClass) {
                    $(element).addClass("is-valid").removeClass("is-invalid");
                }
            });
        });
    </script>
</asp:Content>
