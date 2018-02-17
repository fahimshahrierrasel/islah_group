<%@ Page Title="Management" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="IslahGroup.Admin.Management" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <button class="btn btn-primary btn-lg m-3" data-toggle="modal" data-target="#addUserModal" id="Button1">New User</button>
        <div class="table-responsive">
            <table class="table table-bordered" id="dataTable1" width="100%" cellspacing="0">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Username</th>
                        <th>Email</th>
                        <th>Type</th>
                        <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeaterIGUserList" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("Name") %></td>
                                <td><%# Eval("Username") %></td>
                                <td><%# Eval("Email") %></td>
                                <td><%# Eval("Type") %></td>
                                <td class="text-center"><a class="btn btn-warning m-1">Update</a><a class="btn btn-danger">Delete</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        </div>
    </div>
    <div class="modal fade" id="addUserModal" tabindex="-1" role="dialog" aria-labelledby="addUserModalTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="addUserModalTitle">Add New User</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <form id="Form1" runat="server">
                    <div class="modal-body">

                        <div class="form-group">
                            <label for="TextBoxFullName" class="col-form-label">Full Name:</label>
                            <asp:TextBox ID="TextBoxFullName" CssClass="form-control" runat="server" placeholder="Full Name"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxUsername" class="col-form-label">Username:</label>
                            <asp:TextBox ID="TextBoxUsername" CssClass="form-control" runat="server" placeholder="Username" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxEmail" class="col-form-label">Email:</label>
                            <asp:TextBox ID="TextBoxEmail" CssClass="form-control" runat="server" placeholder="Email" TextMode="Email" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxPass" class="col-form-label">Password:</label>
                            <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server" placeholder="Password" TextMode="Password" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxConfPass" class="col-form-label">Confirm Password:</label>
                            <asp:TextBox ID="TextBoxConfPass" CssClass="form-control" runat="server" placeholder="Confirm Password" TextMode="Password" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="DropDownListUserType" class="col-form-label">User Type:</label>
                            <asp:DropDownList ID="DropDownListUserType" runat="server" required="required"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="ButtonAddNewUser" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddNewUser_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#Form1').validate({
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
                    <%=TextBoxConfPass.ClientID%>: {
                        required: true,
                        equalTo: "#<%=TextBoxPass.UniqueID%>"
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

            $('#dataTable1').DataTable();
        });
    </script>
</asp:Content>
