<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="IslahGroup.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
                <div class="row">
            <div class="col-xl-4 col-sm-6 mb-3">
                <div class="card text-white bg-primary o-hidden h-100">
                    <div class="card-header">
                        Current Capital
                    </div>
                    <div class="card-body">
                        <div class="card-body-icon">
                            <i class="fa fa-fw fa-money"></i>
                        </div>
                        <asp:Label ID="LabelCurrentCapital" runat="server" Text="12345.00"></asp:Label>
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
                        Total Earn
                    </div>
                    <div class="card-body">
                        <div class="card-body-icon">
                            <i class="fa fa-fw fa-shopping-cart"></i>
                        </div>
                        <asp:Label ID="LabelTotalEarn" runat="server" Text="12345.00"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>