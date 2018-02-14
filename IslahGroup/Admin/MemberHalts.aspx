<%@ Page Title="Member Halts" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="MemberHalts.aspx.cs" Inherits="IslahGroup.Admin.MemberHalts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <!-- Breadcrumbs-->
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <a>Members</a>
            </li>
            <li class="breadcrumb-item active">Member Halts</li>
        </ol>
        <!-- Members DataTables Card-->
        <div class="card mb-3">
            <div class="card-header">
                <i class="fa fa-table"></i> Member Halts
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Name</th>
                                <th>Date of Birth</th>
                                <th>Mobile No</th>
                                <th>Amount</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Name</th>
                                <th>Date of Birth</th>
                                <th>Mobile No</th>
                                <th>Amount</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="OwnerDetails.aspx?MemId=<%# Eval("MemberId") %>"><%# Eval("FullName") %></a></td>
                                        <td><%# Eval("DateOfBirth", "{0:d}") %></td>
                                        <td><%# Eval("MobileNo") %></td>
                                        <td><%# Eval("Amount") %></td>
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
