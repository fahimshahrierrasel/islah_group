<%@ Page Title="Update" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="UpdateOwner.aspx.cs" Inherits="IslahGroup.Admin.UpdateOwner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <div class="card-header">Update Owner</div>
        <div class="card-block p-3">
            <form id="regform" runat="server">
                <h3>Owner's Information</h3>
                <div class="form-group">
                    <label for="RegistrationDate">Registration Date (dd-mm-yyyy)</label>
                    <asp:TextBox ID="RegistrationDate" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="ShareNo">Share No</label>
                    <asp:TextBox ID="ShareNo" CssClass="form-control" type="text" placeholder="Share No" runat="server" Text="1"></asp:TextBox>
                </div>
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
                            <label for="DateOfBirth">Date of Birth (dd-mm-yyyy)</label>
                            <asp:TextBox ID="DateOfBirth" CssClass="form-control" runat="server"></asp:TextBox>
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
                <div class="form-group">
                    <label for="TextBoxDesignation">Designation</label>
                    <asp:TextBox ID="TextBoxDesignation" CssClass="form-control" placeholder="Owner Designnation" Text="Owner" runat="server"></asp:TextBox>
                </div>
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
                            <label for="NomineeDateOfBirth">Date of Birth (dd-mm-yyyy)</label>
                            <asp:TextBox ID="NomineeDateOfBirth" CssClass="form-control" runat="server"></asp:TextBox>
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
                <h3>Photos</h3>
                
                
                <div class="row">
                    <div class="col-4">
                        <p>Member Photo</p>
                        <asp:Label ID="HiddenImageLabel" runat="server" Visible="false"></asp:Label>
                        <asp:Image ID="ImageMember" Height="200px" CssClass="img-thumbnail" runat="server" />
                    </div>
                    <div class="col-4">
                        <p>Nominee Photo</p>
                        <asp:Label ID="HiddenNomineeImageLabel" runat="server" Visible="false"></asp:Label>
                        <asp:Image ID="ImageNominee" Height="200px" CssClass="img-thumbnail" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="MemberImageUpload">Member's Photo</label>
                    <asp:FileUpload ID="MemberImageUpload" CssClass="form-control-file" runat="server" />
                </div>
                <div class="form-group">
                    <label for="NomineeImageUpload">Nominee's Image</label>
                    <asp:FileUpload ID="NomineeImageUpload" CssClass="form-control-file" runat="server" />
                </div>
                <asp:Button ID="UpdateFormSubmit" runat="server" CssClass="btn btn-primary float-right" Text="Submit" OnClick="UpdateFormSubmit_Click"/>
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#regform').validate({
                rules: {
                    <%=RegistrationDate.UniqueID%>: {
                        required: true
                    },
                    <%=ShareNo.UniqueID%>: {
                        required: true,
                        digits: true
                    },
                    <%=NidNo.UniqueID%>: {
                        required: true,
                        digits: true
                    },
                    <%=FullName.UniqueID%>: {
                        required: true
                    },
                    <%=FatherName.UniqueID%>: {
                        required: true
                    },
                    <%=MotherName.UniqueID%>: {
                        required: true
                    },
                    <%=HusbWifeName.ClientID%>: {
                        required: true
                    },
                    <%=PresentAddress.UniqueID%>: {
                        required: true
                    },
                    <%=ParmanentAddress.UniqueID%>: {
                        required: true
                    },
                    <%=DateOfBirth.UniqueID%>: {
                        required: true
                    },
                    <%=Education.UniqueID%>: {
                        required: true
                    },
                    <%=Profession.UniqueID%>: {
                        required: true
                    },
                    <%=Nationality.UniqueID%>: {
                        required: true
                    },
                    <%=Gender.UniqueID%>: {
                        required: true
                    },
                    <%=BloodGroup.UniqueID%>: {
                        required: true
                    },
                    <%=MobileNo.UniqueID%>: {
                        required: true,
                        digits: true,
                        maxlength: 12,
                        minlength: 11
                    },
                    <%=Email.UniqueID%>: {
                        required: true,
                        email: true
                    },
                    <%=TextBoxDesignation.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeNidNo.UniqueID%>: {
                        required: true,
                        digits: true
                    },
                    <%=NomineeName.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeFatherHusbandName.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeMotherName.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeAddress.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeDateOfBirth.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeRelation.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeProfession.UniqueID%>: {
                        required: true
                    },
                    <%=NomineeMobileNo.UniqueID%>: {
                        required: true,
                        digits: true,
                        maxlength: 12,
                        minlength: 11
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

