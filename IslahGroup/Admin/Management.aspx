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
                <button class="btn btn-primary btn-lg m-3">New User</button>
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
                <button class="btn btn-lg btn-primary m-3">New User Type</button>
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
                <button class="btn btn-primary btn-lg m-3">New Expenditure Type</button>
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
                <button class="btn btn-primary btn-lg m-3">New Invest Type</button>
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
