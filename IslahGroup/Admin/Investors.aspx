<%@ Page Title="Investors" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Investors.aspx.cs" Inherits="IslahGroup.Admin.Investors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xl-4 col-sm-6 mb-3">
                <div class="card text-white bg-primary o-hidden h-100">
                    <div class="card-header">
                        Total Investors
                    </div>
                    <div class="card-body">
                        <div class="card-body-icon">
                            <i class="fa fa-fw fa-money"></i>
                        </div>
                        <asp:Label ID="LabelTotalInvestor" runat="server" Text="12"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-xl-4 col-sm-6 mb-3">
                <div class="card text-white bg-warning o-hidden h-100">
                    <div class="card-header">
                        Total Investment
                    </div>
                    <div class="card-body">
                        <div class="card-body-icon">
                            <i class="fa fa-fw fa-list"></i>
                        </div>
                        <asp:Label ID="LabelTotalInvestment" runat="server" Text="12345.00"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-xl-4 col-sm-6 mb-3">
                <div class="card text-white bg-success o-hidden h-100">
                    <div class="card-header">
                        Total Returned
                    </div>
                    <div class="card-body">
                        <div class="card-body-icon">
                            <i class="fa fa-fw fa-shopping-cart"></i>
                        </div>
                        <asp:Label ID="LabelTotalReturned" runat="server" Text="12345.00"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col m-3" id="RegisterInvestorBtn" runat="server">
                <a class="btn btn-primary" href="../Admin/RegisterInvestor.aspx">
                    <i class="fa fa-fw fa-plus"></i>
                    <span class="nav-link-text">Register Investor</span>
                </a>
            </div>
        </div>

        <div class="row">
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Full Name</th>
                                <th>Mobile No</th>
                                <th>Total Invest</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Full Name</th>
                                <th>Mobile No</th>
                                <th>Total Invest</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="RepeaterAllInvestors" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><a href="InvestorDetails.aspx?InvId=<%# Eval("InvId") %>"><%# Eval("InvFullName") %></a></td>
                                        <td><%# Eval("InvMobileNo") %></td>
                                        <td><%# Eval("InvInvest") %></td>
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
