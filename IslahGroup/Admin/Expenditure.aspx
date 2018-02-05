<%@ Page Title="Expenditure" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="Expenditure.aspx.cs" Inherits="IslahGroup.Admin.Expenditure" %>

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

        <div class="row">
            <div class="col m-3">
                <button type="button" class="btn btn-dark btn-lg" data-toggle="modal" data-target="#addDepositModal">Add Expenditure</button>
            </div>
        </div>

        <div class="row">
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Date</th>
                                <th>Type</th>
                                <th>Amount</th>
                                <th>Note</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Date</th>
                                <th>Type</th>
                                <th>Amount</th>
                                <th>Note</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="RepeaterOwnerDeposits" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("ExpnDate") %></a></td>
                                        <td><%# Eval("ExpnType") %></td>
                                        <td><%# Eval("ExpnAmount") %></td>
                                        <td><%# Eval("ExpnNote") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="addDepositModal" tabindex="-1" role="dialog" aria-labelledby="addDepositModalTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="addDepositModalTitle">New Expenditure</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <form runat="server">
                        <div class="modal-body">
                            <div class="form-group">
                                <label for="TextBoxDDate" class="col-form-label">Date:</label>
                                <asp:TextBox ID="TextBoxEDate" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="TextBoxEInfo" class="col-form-label">Information:</label>
                                <asp:TextBox ID="TextBoxEInfo" CssClass="form-control" TextMode="MultiLine" runat="server" placeholder="Short Information of expenditure"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="DropDownListEType" class="col-form-label">Expenditure Type:</label>
                                <asp:DropDownList ID="DropDownListEType" runat="server">
                                    <asp:ListItem>Invest</asp:ListItem>
                                    <asp:ListItem>Earn</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="TextBoxDAmount-name" class="col-form-label">Amount:</label>
                                <asp:TextBox ID="TextBoxEAmount" CssClass="form-control" runat="server" placeholder="Amount"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <asp:Button ID="ButtonAddODeposit" CssClass="btn btn-primary" runat="server" Text="Submit" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
