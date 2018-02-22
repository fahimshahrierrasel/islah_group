<%@ Page Title="Owners" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Owners.aspx.cs" Inherits="IslahGroup.Admin.Owners" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <!-- Breadcrumbs-->
        <ol class="breadcrumb">
            <li class="breadcrumb-item">
                <a href="Dashboard.aspx">Dashboard</a>
            </li>
            <li class="breadcrumb-item active">Owners</li>
        </ol>
        <div class="mb-3" id="RegisterOwnerArea" runat="server">
            <a class="btn btn-primary" href="../Admin/RegisterOwner.aspx">
                <i class="fa fa-fw fa-plus"></i>
                <span class="nav-link-text">Register Owner</span>
            </a>
        </div>
        <!-- Members DataTables Card-->
        <div class="card mb-3">
            <div class="card-header">
                <i class="fa fa-table"></i>All Owners
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
