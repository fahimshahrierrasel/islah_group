<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="IslahGroup.Admin.UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <form id="formuser" runat="server">
            <div class="card-header">Update User</div>
            <div class="card-body p-3">
                <div class="form-group">
                    <label for="TextBoxFullName" class="col-form-label">Full Name:</label>
                    <asp:TextBox ID="TextBoxFullName" CssClass="form-control" runat="server" placeholder="Full Name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxUsername" class="col-form-label">Username:</label>
                    <asp:TextBox ID="TextBoxUsername" CssClass="form-control" runat="server" placeholder="Username"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxEmail" class="col-form-label">Email:</label>
                    <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxPass" class="col-form-label">Password:</label>
                    <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server" placeholder="Password" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="DropDownListUserType" class="col-form-label">User Type:</label>
                    <asp:DropDownList ID="DropDownListUserType" runat="server" required="required"></asp:DropDownList>
                </div>
            </div>
            <div class="card-footer text-right">
                <asp:Button ID="ButtonUpdateUser" CssClass="btn btn-warning" runat="server" Text="Update" OnClick="ButtonUpdateUser_Click" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#formuser').validate({
                rules: {
                    <%=TextBoxFullName.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxUsername.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxEmail.UniqueID%>: {
                        required: true,
                        email: true
                    },
                    <%=TextBoxPass.UniqueID%>: {
                        required: true
                    },
                    <%=DropDownListUserType.UniqueID%>: {
                        required: true
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
