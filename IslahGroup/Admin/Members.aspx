<%@ Page Title="Members" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="IslahGroup.Admin.Members" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <!-- Breadcrumbs-->
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <a>Members</a>
            </li>
            <li class="breadcrumb-item active">Member Lists</li>
        </ol>
        <!-- Members DataTables Card-->
        <div class="card mb-3">
            <div class="card-header">
                <i class="fa fa-table"></i> Member Lists
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Membership ID</th>
                                <th>Full Name</th>
                                <th>Registration Date</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Membership ID</th>
                                <th>Full Name</th>
                                <th>Registration Date</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="RepeaterMemberLists" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="MemberDetails.aspx?MemId=<%# Eval("MemberId") %>"><%# Eval("MembershipId") %></a></td>
                                        <td><%# Eval("FullName") %></td>
                                        <td><%# Eval("RegistrationDate", "{0:d}") %></td>
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
</asp:Content>
