<%@ Page Title="Register Member" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="RegisterMember.aspx.cs" Inherits="IslahGroup.RegisterMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="card card-register mx-auto mt-5 mb-5">
                <div class="card-header">Member Registration</div>
                <div class="card-block p-3">
                    <form id="regForm" action="#" runat="server">
                        <h3>Your Information</h3>
                        <div class="form-group">
                            <label for="NidNo">National Identification Number (NID)</label>
                            <asp:TextBox ID="NidNo" CssClass="form-control" type="text" placeholder="NID No" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="FullName">Full Name</label>
                            <asp:TextBox ID="FullName" CssClass="form-control" type="text" placeholder="Full Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="FatherName">Father Name</label>
                            <asp:TextBox ID="FatherName" CssClass="form-control" type="text" placeholder="Father Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="MotherName">Mother Name</label>
                            <asp:TextBox ID="MotherName" CssClass="form-control" type="text" placeholder="Mother Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="HusbWifeName">Husband/Spouse Name</label>
                            <asp:TextBox ID="HusbWifeName" CssClass="form-control" type="text" placeholder="Husband/Spouse Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="PresentAddress">Present Address</label>
                            <asp:TextBox ID="PresentAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Present Address" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="ParmanentAddress">Parmanent Address</label>
                            <asp:TextBox ID="ParmanentAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Parmanent Address" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="DateOfBirth">Date of Birth</label>
                                    <asp:TextBox ID="DateOfBirth" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="Education">Education</label>
                                    <asp:TextBox ID="Education" CssClass="form-control" type="text" placeholder="Education" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="Profession">Profession</label>
                                    <asp:TextBox ID="Profession" CssClass="form-control" type="text" placeholder="Profession" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="Nationality">Nationality</label>
                                    <asp:TextBox ID="Nationality" CssClass="form-control" type="text" placeholder="Nationality" runat="server">Bangladeshi</asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="Gender">Gender</label>
                                    <asp:DropDownList ID="Gender" CssClass="form-control" runat="server">
                                        <asp:ListItem>Male</asp:ListItem>
                                        <asp:ListItem>Female</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-6">
                                    <label for="BloodGroup">Blood Group</label>
                                    <asp:DropDownList ID="BloodGroup" CssClass="form-control" runat="server">
                                        <asp:ListItem>A+</asp:ListItem>
                                        <asp:ListItem>A-</asp:ListItem>
                                        <asp:ListItem>B+</asp:ListItem>
                                        <asp:ListItem>B-</asp:ListItem>
                                        <asp:ListItem>AB+</asp:ListItem>
                                        <asp:ListItem>AB-</asp:ListItem>
                                        <asp:ListItem>O+</asp:ListItem>
                                        <asp:ListItem>O-</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="MobileNo">Mobile Number</label>
                                    <asp:TextBox ID="MobileNo" CssClass="form-control" TextMode="Phone" placeholder="Mobile Number" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="Email">Email</label>
                                    <asp:TextBox ID="Email" CssClass="form-control" TextMode="Email" placeholder="Email" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <hr />
                        <h3>Nominee's Information</h3>
                        <div class="form-group">
                            <label for="NomineeNidNo">National Identification Number (NID)</label>
                            <asp:TextBox ID="NomineeNidNo" CssClass="form-control" type="text" placeholder="NID No" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="NomineeName">Nominee Name</label>
                            <asp:TextBox ID="NomineeName" CssClass="form-control" type="text" placeholder="Nominee Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="NomineeFatherHusbandName">Father/Husband Name</label>
                            <asp:TextBox ID="NomineeFatherHusbandName" CssClass="form-control" type="text" placeholder="Father/Husband Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="NomineeMotherName">Mother Name</label>
                            <asp:TextBox ID="NomineeMotherName" CssClass="form-control" type="text" placeholder="Mother Name" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="NomineeAddress">Nominee's Address</label>
                            <asp:TextBox ID="NomineeAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Nominee's Address" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="NomineeDateOfBirth">Date of Birth</label>
                                    <asp:TextBox ID="NomineeDateOfBirth" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="NomineeRelation">Relation with Nominee</label>
                                    <asp:TextBox ID="NomineeRelation" CssClass="form-control" type="text" placeholder="Relation" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-6">
                                    <label for="NomineeProfession">Profession</label>
                                    <asp:TextBox ID="NomineeProfession" CssClass="form-control" type="text" placeholder="Profession" runat="server"></asp:TextBox>
                                </div>
                                <div class="col-md-6">
                                    <label for="NomineeMobileNo">Mobile No</label>
                                    <asp:TextBox ID="NomineeMobileNo" CssClass="form-control" TextMode="Phone" placeholder="Mobile No" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <hr />
                        <h3>Introducer's Information</h3>
                        <div class="form-group">
                            <label for="IntroducerMembershipId">Introducer Membership Id</label>
                            <asp:TextBox ID="IntroducerMembershipId" CssClass="form-control" type="text" placeholder="Introducer Membership Id" runat="server"></asp:TextBox>
                        </div>
                        <hr />
                        <h3>Photos</h3>
                        <div class="form-group">
                            <label for="MemberImageUpload">Member's Photo</label>
                            <asp:FileUpload ID="MemberImageUpload" CssClass="form-control-file" runat="server" />
                        </div>
                        <div class="form-group">
                            <label for="NomineeImageUpload">Nominee's Image</label>
                            <asp:FileUpload ID="NomineeImageUpload" CssClass="form-control-file" runat="server" />
                        </div>
                        <asp:Button ID="FormSubmit" runat="server" CssClass="btn btn-primary float-right" Text="Submit" OnClick="FormSubmit_Click"/>
                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
