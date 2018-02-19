<%@ Page Title="Owner Details" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="OwnerDetails.aspx.cs" Inherits="IslahGroup.Admin.OwnerDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
        }

        .no_underline {
            text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h1>
            <asp:Label ID="LabelMemberName" runat="server" Text="Jon Doe"></asp:Label></h1>
    </div>
    <div class="row m-2">
        <div class="col-md-3">
            <div id="accordion">
                <div class="card">
                    <div class="card-header" id="headingOne">
                        <a class="no_underline" href="#" data-toggle="collapse" data-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">Member's Photo
                        </a>
                    </div>
                    <div id="collapseOne" class="collapse show" aria-labelledby="headingOne" data-parent="#accordion">
                        <div class="card-body">
                            <asp:Image ID="ImageMember" CssClass="img-thumbnail" ImageUrl="~/Images/admin_page/boy.png" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="card">
                    <div class="card-header" id="headingTwo">
                        <a class="no_underline collapsed" href="#" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">Nominee's Photo
                        </a>
                    </div>
                    <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordion">
                        <div class="card-body">
                            <asp:Image ID="ImageNominee" CssClass="img-thumbnail" ImageUrl="~/Images/landing_page/boss.png" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <nav>
                <div class="nav nav-tabs" id="nav-tab-info" role="tablist">
                    <a class="nav-item nav-link active" id="nav-personal-tab" data-toggle="tab" href="#nav-personal" role="tab" aria-controls="nav-personal" aria-selected="true">Personal</a>
                    <a class="nav-item nav-link" id="nav-nominee-tab" data-toggle="tab" href="#nav-nominee" role="tab" aria-controls="nav-nominee" aria-selected="false">Nominee</a>
                    <a class="nav-item nav-link" id="nav-contact-tab" data-toggle="tab" href="#nav-contact" role="tab" aria-controls="nav-contact" aria-selected="false">Contact</a>
                </div>
            </nav>
            <div class="tab-content" id="nav-tabInfoContent">
                <div class="tab-pane fade show active" id="nav-personal" role="tabpanel" aria-labelledby="nav-personal-tab">
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
                <div class="tab-pane fade" id="nav-nominee" role="tabpanel" aria-labelledby="nav-nominee-tab">
                    <table class="w-100 p-3">
                        <tr>
                            <td class="auto-style1">NID</td>
                            <td>
                                <asp:Label ID="LabelNomineeNID" runat="server" Text="123456789101112"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Name</td>
                            <td>
                                <asp:Label ID="LabelNomineeName" runat="server" Text="Kalphana Akther"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Father's Name</td>
                            <td>
                                <asp:Label ID="LabelNomineeFatherHusbandName" runat="server" Text="Abul Khair"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Mother's Name</td>
                            <td>
                                <asp:Label ID="LabelNomineeMotherName" runat="server" Text="Fulnahar"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Address</td>
                            <td>
                                <asp:Label ID="LabelNomineeAddress" runat="server" Text="Vill: Metanghar, Post: Pandughar, Police Station: Muradnagar, Disrict: Comilla"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Date of Birth</td>
                            <td>
                                <asp:Label ID="LabelNomineeDOB" runat="server" Text="01-08-1975"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Relation</td>
                            <td>
                                <asp:Label ID="LabelNomineeRelation" runat="server" Text="Mother"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Profession</td>
                            <td>
                                <asp:Label ID="LabelNomineeProfession" runat="server" Text="Housewife"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Mobile No</td>
                            <td>
                                <asp:Label ID="LabelNomineeMobileNo" runat="server" Text="01941451840"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab">
                    <table class="w-100 p-3">
                        <tr>
                            <td class="auto-style1">Mobile No</td>
                            <td>
                                <asp:Label ID="LabelMobileNo" runat="server" Text="01554070646"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Email</td>
                            <td>
                                <asp:HyperLink ID="HyperLinkEmail" runat="server"></asp:HyperLink>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div class="col-md-3">
            <div class="card text-white bg-info mb-3" style="max-width: 15rem;">
                <div class="card-header">Membership Id</div>
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="LabelMemberShipId" runat="server" Text="MEMXXX"></asp:Label>
                    </h5>
                </div>
            </div>
            <div class="card text-white bg-dark mb-3" style="max-width: 15rem;">
                <div class="card-header">Action</div>
                <div class="card-body text-center">
                    <a href="UpdateOwner.aspx" class="btn btn-warning">Update</a>
                </div>
            </div>
            <div class="card text-white bg-primary mb-3" style="max-width: 15rem;">
                <div class="card-header">Amount</div>
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="LabelAmount" runat="server" Text="123,534.00"></asp:Label>
                    </h5>
                </div>
            </div>
            <div class="card text-white bg-success mb-3" style="max-width: 15rem;">
                <div class="card-header">Profit</div>
                <div class="card-body">
                    <h5 class="card-title">
                        <asp:Label ID="LabelProfit" runat="server" Text="123,534.00"></asp:Label>
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
                        <button class="btn btn-primary float-right" id="add_modal" data-toggle="modal" data-target="#addDepositModal">
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
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th>Date</th>
                                    <th>Amount</th>
                                    <th>Note</th>
                                    <th>Action</th>
                                </tr>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="RepeaterOwnerDeposits" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                            <td><%# Eval("DepositDate", "{0:d}") %></a></td>
                                            <td><%# Eval("Amount") %></td>
                                            <td><%# Eval("Note") %></td>
                                            <td class="text-center"><a href="UpdateDeposit.aspx?MemId=<%#memberId%>&DepId=<%#Eval("DepositId") %>" class="btn btn-warning m-1">Update</a><a href="DeleteDeposit.aspx?ExpnId=<%# memberId %>" class="btn btn-danger">Delete</a></td>
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
                    <h5 class="modal-title" id="addDepositModalTitle">Add Expenditure</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <form id="DepositForm" runat="server">
                    <div class="modal-body">
                        <div class="form-group">
                            <label for="TextBoxDAmount" class="col-form-label">Amount:</label>
                            <asp:TextBox ID="TextBoxDAmount" CssClass="form-control" runat="server" placeholder="Amount" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxDDate" class="col-form-label">Date:</label>
                            <asp:TextBox ID="TextBoxDDate" CssClass="form-control" TextMode="Date" runat="server" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxDNote" class="col-form-label">Note:</label>
                            <asp:TextBox ID="TextBoxDNote" CssClass="form-control" runat="server" placeholder="Note" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <asp:Button ID="ButtonAddODeposit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonAddODeposit_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        $(document).ready(function () {
            $('#add_modal').click(function (e) {
                e.preventDefault();
            });

            $('#DepositForm').validate({
                rules: {
                    <%=TextBoxDAmount.UniqueID%>: {
                    required: true,
                    number: true

                },
                    <%=TextBoxDDate.UniqueID%>: {
                    required: true,
                    date: true
                },
                    <%=TextBoxDNote.UniqueID%>: {
                        required: true
                    }
                },
            errorElement: "div",
            errorPlacement: function (error, element) {
                error.addClass("invalid-feedback");
                error.insertAfter(element);
            },
            highlight: function (element, errorClass, validClass) {
                $(element).addClass("is-invalid").removeClass("is-valid");
            },
            unhighlight: function (element, errorClass, validClass) {
                $(element).addClass("is-valid").removeClass("is-invalid");
            }
            });

        });
    </script>
</asp:Content>
