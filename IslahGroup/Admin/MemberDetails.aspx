﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="MemberDetails.aspx.cs" Inherits="IslahGroup.Admin.MemberDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 200px;
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
            <div class="col-md-3">
                <asp:Image ID="ImageMember" Width="300px" ImageUrl="~/Images/admin_page/boy.png" runat="server" />
            </div>
            <div class="col-md-6">
                <nav>
                    <div class="nav nav-tabs" id="nav-tab" role="tablist">
                        <a class="nav-item nav-link active" id="nav-personal-tab" data-toggle="tab" href="#nav-personal" role="tab" aria-controls="nav-personal" aria-selected="true">Personal</a>
                        <a class="nav-item nav-link" id="nav-nominee-tab" data-toggle="tab" href="#nav-nominee" role="tab" aria-controls="nav-nominee" aria-selected="false">Nominee</a>
                        <a class="nav-item nav-link" id="nav-contact-tab" data-toggle="tab" href="#nav-contact" role="tab" aria-controls="nav-contact" aria-selected="false">Contact</a>
                    </div>
                </nav>
                <div class="tab-content" id="nav-tabContent">
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
                                    <a href="mailto:<%=memberInfo.Rows[0]["Email"]%>"><%=memberInfo.Rows[0]["Email"]%></a>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="card text-white bg-primary mb-3" style="max-width: 15rem;">
                    <div class="card-header">Amount</div>
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="LabelAmount" runat="server" Text="123,534.00"></asp:Label>
                        </h5>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>