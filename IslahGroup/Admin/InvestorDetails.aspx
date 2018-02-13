<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="InvestorDetails.aspx.cs" Inherits="IslahGroup.Admin.InvestorDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 210px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="ProfileForm" runat="server">
        <div class="row">
            <div class="container">
                <h1>
                    <asp:Label ID="LabelMemberName" runat="server" Text="Jon Doe"></asp:Label></h1>
            </div>
        </div>
        <div class="row m-4">
            <div class="col-md-9">
                <table class="w-100 p-3">
                    <tr>
                        <td class="auto-style1">NID</td>
                        <td>
                            <asp:Label ID="LabelNID" runat="server" Text="12345678910111213"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Full Name</td>
                        <td>
                            <asp:Label ID="LabelFullName" runat="server" Text="Md. Fahim Shahrier Rasel"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Father's Name</td>
                        <td>
                            <asp:Label ID="LabelFatherName" runat="server" Text="Md. Abul Khair"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Mother's Name</td>
                        <td>
                            <asp:Label ID="LabelMotherName" runat="server" Text="Kalphana Akther"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Husband/Wife's Name</td>
                        <td>
                            <asp:Label ID="LabelHusbWifeName" runat="server" Text="No One"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Date Of Birth</td>
                        <td>
                            <asp:Label ID="LabelDOB" runat="server" Text="11/07/1993"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Present Address</td>
                        <td>
                            <asp:Label ID="LabelPresentAddress" runat="server" Text="Ta-214, Middle Badda, Dhaka-1212"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Parmanent Address</td>
                        <td>
                            <asp:Label ID="LabelParmanentAddress" runat="server" Text="Vill: Metanghar, Post: Pandhughar, Police Station: Muradnagar, District: Comilla"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Gender</td>
                        <td>
                            <asp:Label ID="LabelGender" runat="server" Text="Male"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Nationality</td>
                        <td>
                            <asp:Label ID="LabelNationality" runat="server" Text="Bangladeshi"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Education</td>
                        <td>
                            <asp:Label ID="LabelEducation" runat="server" Text="B.Sc in Computer Science and Engineering"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Profession</td>
                        <td>
                            <asp:Label ID="LabelProfession" runat="server" Text="Student, Developer"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Blood Group</td>
                        <td>
                            <asp:Label ID="LabelBloodGroup" runat="server" Text="A+"></asp:Label></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Registration Date</td>
                        <td>
                            <asp:Label ID="LabelRegistrationDate" runat="server" Text="04/02/2018"></asp:Label></td>
                    </tr>
                </table>
            </div>
            <div class="col-md-3">
                <div class="card text-white bg-primary mb-3" style="max-width: 15rem;">
                    <div class="card-header">Total Investment</div>
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="LabelAmount" runat="server" Text="123,534.00"></asp:Label>
                        </h5>
                    </div>
                </div>

                <div class="card text-white bg-success mb-3" style="max-width: 15rem;">
                    <div class="card-header">Total Repaid</div>
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="Label1" runat="server" Text="123,534.00"></asp:Label>
                        </h5>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="container">
                <div class="card">
                    <div class="card-header">
                        Owners Deposits
                        <button class="btn btn-primary float-right" id="add_modal" runat="server" data-toggle="modal" data-target="#addDepositModal">
                            <i class="fa fa-fw fa-plus"></i>Add
                        </button>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                <thead>
                                    <tr>
                                        <th>Date</th>
                                        <th>Amount</th>
                                        <th>Note</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
                                        <th>Date</th>
                                        <th>Amount</th>
                                        <th>Note</th>
                                    </tr>
                                </tfoot>
                                <tbody>
                                    <asp:Repeater ID="RepeaterOwnerDeposits" runat="server">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%# Eval("DipositDate") %></a></td>
                                                <td><%# Eval("Amount") %></td>
                                                <td><%# Eval("Note") %></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="addDepositModal" tabindex="-1" role="dialog" aria-labelledby="addDepositModalTitle" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="addDepositModalTitle">Add New Investment</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label for="TextBoxDAmount-name" class="col-form-label">Amount:</label>
                            <asp:TextBox ID="TextBoxDAmount" CssClass="form-control" runat="server" placeholder="Amount" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxDDate" class="col-form-label">Date:</label>
                            <asp:TextBox ID="TextBoxDDate" CssClass="form-control" TextMode="Date" runat="server" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxDNote" class="col-form-label">Type:</label>
                            <asp:DropDownList ID="DropDownListInvestType" runat="server"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxDNote" class="col-form-label">Note:</label>
                            <asp:TextBox ID="TextBoxDNote" CssClass="form-control" runat="server" placeholder="Note" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="ButtonAddODeposit" CssClass="btn btn-primary" runat="server" Text="Submit" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        $(document).ready(function () {
            $('#add_modal').click(function (e) {
                e.preventDefault();
            });
        });
    </script>
</asp:Content>
