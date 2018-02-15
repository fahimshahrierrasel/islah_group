<%@ Page Title="Management" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="IslahGroup.Admin.Management" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <nav>
            <div class="nav nav-tabs nav-justified" id="nav-tab" role="tablist">
                <a class="nav-item nav-link active" id="nav-user-list-tab" data-toggle="tab" href="#nav-user-list" role="tab" aria-controls="nav-user-list" aria-selected="true">Users</a>
                <a class="nav-item nav-link" id="nav-user-type-tab" data-toggle="tab" href="#nav-user-type" role="tab" aria-controls="nav-user-type" aria-selected="false">User Types</a>
                <a class="nav-item nav-link" id="nav-expn-type-tab" data-toggle="tab" href="#nav-expn-type" role="tab" aria-controls="nav-expn-type" aria-selected="false">Expenditure Types</a>
                <a class="nav-item nav-link" id="nav-invs-type-tab" data-toggle="tab" href="#nav-invs-type" role="tab" aria-controls="nav-invs-type" aria-selected="false">Invest Types</a>
            </div>
        </nav>
        <div class="tab-content" id="nav-tabContent">
            <div class="tab-pane fade show active" id="nav-user-list" role="tabpanel" aria-labelledby="nav-user-list-tab">
                <button class="btn btn-primary btn-lg m-3" data-toggle="modal" data-target="#addUserModal" id="Button1">New User</button>
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable1" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Username</th>
                                <th>Email</th>
                                <th>Type</th>
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
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="tab-pane fade" id="nav-user-type" role="tabpanel" aria-labelledby="nav-user-type-tab">
                <button class="btn btn-lg btn-primary m-3" data-toggle="modal" data-target="#addUserTypeModal" id="Button2">New User Type</button>
                <div class="table-responsive">
                    <table class="table table-bordered  table-dark table-striped" id="dataTable2" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Type</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterUserTypes" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("Type") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="tab-pane fade" id="nav-expn-type" role="tabpanel" aria-labelledby="nav-expn-type-tab">
                <button class="btn btn-primary btn-lg m-3" data-toggle="modal" data-target="#addExpnTypeModal">New Expenditure Type</button>
                <div class="table-responsive">
                    <table class="table table-bordered  table-dark table-striped" id="dataTable3" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Type</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterExpnTypes" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("Type") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="tab-pane fade" id="nav-invs-type" role="tabpanel" aria-labelledby="nav-invs-type-tab">
                <button class="btn btn-primary btn-lg m-3" data-toggle="modal" data-target="#addInvestTypeModal">New Invest Type</button>
                <div class="table-responsive">
                    <table class="table table-bordered  table-dark table-striped" id="dataTable4" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Type</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="RepeaterInvestTypes" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("Type") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
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
                <div class="modal-body">

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
                        <asp:TextBox ID="TextBoxPass" CssClass="form-control" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TextBoxConfPass" class="col-form-label">Confirm Password:</label>
                        <asp:TextBox ID="TextBoxConfPass" CssClass="form-control" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="DropDownListUserType" class="col-form-label">User Type:</label>
                        <asp:DropDownList ID="DropDownListUserType" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="ButtonAddNewUser" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddNewUser_Click" />
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="addUserTypeModal" tabindex="-1" role="dialog" aria-labelledby="addUserTypeModalTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="addUserTypeModalTitle">Add User</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="TextBoxUserType" class="col-form-label">User Type:</label>
                        <asp:TextBox ID="TextBoxUserType" CssClass="form-control" runat="server" placeholder="User Type"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="ButtonAddUserType" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddUserType_Click" />
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="addExpnTypeModal" tabindex="-1" role="dialog" aria-labelledby="addExpnTypeModalTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="addExpnTypeModalTitle">Add Expenditure Type</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="TextBoxExpnType" class="col-form-label">Expenditure Type:</label>
                        <asp:TextBox ID="TextBoxExpnType" CssClass="form-control" runat="server" placeholder="Expenditure Type"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="ButtonAddExpnType" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddExpnType_Click" />
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="addInvestTypeModal" tabindex="-1" role="dialog" aria-labelledby="addInvestTypeModalTitle" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="addInvestTypeModalTitle">Add Invest Type</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="TextBoxInvestType" class="col-form-label">Invset Type:</label>
                        <asp:TextBox ID="TextBoxInvestType" CssClass="form-control" runat="server" placeholder="Invest Type"></asp:TextBox>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <asp:Button ID="ButtonAddInvestType" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddInvestType_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        $(document).ready(function () {
            $('#dataTable1').DataTable();
            $('#dataTable2').DataTable();
            $('#dataTable3').DataTable();
            $('#dataTable4').DataTable();
        });
    </script>
</asp:Content>
