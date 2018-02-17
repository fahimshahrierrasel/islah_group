<%@ Page Title="Register Investor" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="RegisterInvestor.aspx.cs" Inherits="IslahGroup.Admin.RegisterInvestor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <div class="card-header">Register New Investor</div>
        <div class="card-block p-3">
            <form id="regForm" runat="server">
                <div class="form-group">
                    <label for="TextBoxInvNID" class="col-form-label">NID:</label>
                    <asp:TextBox ID="TextBoxInvNID" CssClass="form-control" runat="server" placeholder="Investor NID"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvFullName" class="col-form-label">Full Name:</label>
                    <asp:TextBox ID="TextBoxInvFullName" CssClass="form-control" runat="server" placeholder="Investor Full Name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvFatherName" class="col-form-label">Father's Name:</label>
                    <asp:TextBox ID="TextBoxInvFatherName" CssClass="form-control" runat="server" placeholder="Investor Father Name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvMotherName" class="col-form-label">Mother's Name:</label>
                    <asp:TextBox ID="TextBoxInvMotherName" CssClass="form-control" runat="server" placeholder="Investor Mother Name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvHusbWifeName" class="col-form-label">Husband/Wife Name:</label>
                    <asp:TextBox ID="TextBoxInvHusbWifeName" CssClass="form-control" runat="server" placeholder="Investor Husband/Wife Name"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxPresentAddress" class="col-form-label">Present Address:</label>
                    <asp:TextBox ID="TextBoxPresentAddress" CssClass="form-control" runat="server" placeholder="Investor Present Address"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxParmanentAddress" class="col-form-label">Parmanent Address:</label>
                    <asp:TextBox ID="TextBoxParmanentAddress" CssClass="form-control" runat="server" placeholder="Investor Parmanent Address"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvDOB" class="col-form-label">Date of Birth:</label>
                    <asp:TextBox ID="TextBoxInvDOB" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxProfession" class="col-form-label">Profession:</label>
                    <asp:TextBox ID="TextBoxProfession" CssClass="form-control" runat="server" placeholder="Investor Profession"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="DropDownListInvGender" class="col-form-label">Gender:</label>
                    <asp:DropDownList ID="DropDownListInvGender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvMobileNo" class="col-form-label">Mobile No:</label>
                    <asp:TextBox ID="TextBoxInvMobileNo" CssClass="form-control" runat="server" placeholder="Investor Mobile No"></asp:TextBox>
                </div>
                <asp:Button ID="ButtonAddInvestor" CssClass="btn btn-primary float-right" runat="server" Text="Register" OnClick="ButtonAddInvestor_Click" />
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#regForm').validate({
                rules: {
                    <%=TextBoxInvNID.UniqueID%>: {
                        required: true,
                        digits: true
                    },
                    <%=TextBoxInvFullName.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxInvFatherName.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxInvMotherName.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxInvHusbWifeName.ClientID%>: {
                        required: true
                    },
                    <%=TextBoxPresentAddress.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxParmanentAddress.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxInvDOB.UniqueID%>: {
                        required: true,
                        date: true
                    },
                    <%=TextBoxProfession.UniqueID%>: {
                        required: true
                    },
                    <%=DropDownListInvGender.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxInvMobileNo.UniqueID%>: {
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
