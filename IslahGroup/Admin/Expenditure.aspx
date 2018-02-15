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
                        <asp:Label ID="LabelCurrentCapital" runat="server" Text="0.00"></asp:Label>
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
                        <asp:Label ID="LabelTotalInvestment" runat="server" Text="0.00"></asp:Label>
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
                        <asp:Label ID="LabelTotalEarn" runat="server" Text="0.00"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col m-3">
                <button type="button" id="AddExpenditureBtn" runat="server" class="btn btn-dark btn-lg" data-toggle="modal" data-target="#addExpenditureModal">Add Expenditure</button>
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
                            <asp:Repeater ID="RepeaterExpenditures" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("ExpnDate", "{0:d}") %></a></td>
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
        <div class="modal fade" id="addExpenditureModal" tabindex="-1" role="dialog" aria-labelledby="addExpenditureModalTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="addExpenditureModalTitle">New Expenditure</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <form runat="server">
                        <div class="modal-body">
                            <div class="form-group">
                                <label for="TextBoxEDate" class="col-form-label">Date:</label>
                                <asp:TextBox ID="TextBoxEDate" CssClass="form-control" TextMode="Date" runat="server" required="required"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="TextBoxEInfo" class="col-form-label">Information:</label>
                                <asp:TextBox ID="TextBoxEInfo" CssClass="form-control" TextMode="MultiLine" runat="server" placeholder="Short Information of expenditure" required="required"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="DropDownListEType" class="col-form-label">Expenditure Type:</label>
                                <asp:DropDownList ID="DropDownListEType" runat="server" required="required" DataTextField="Type" DataValueField="Type"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <label for="TextBoxEAmount" class="col-form-label">Amount:</label>
                                <asp:TextBox ID="TextBoxEAmount" CssClass="form-control" runat="server" onkeypress="return isNumberKey(event)" placeholder="Amount" required="required"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <asp:Button ID="ButtonAddExpenditure" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddExpenditure_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode != 46 && (charCode < 48 || charCode > 57)))
                return false;
            return true;
        }
    </script>
</asp:Content>
