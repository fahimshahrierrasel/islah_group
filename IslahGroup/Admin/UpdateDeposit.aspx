<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="UpdateDeposit.aspx.cs" Inherits="IslahGroup.Admin.UpdateDeposit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <form id="formexpn" runat="server">
            <div class="card-header">Update Expenditure</div>
            <div class="card-body p-3">
            <div class="form-group">
                <label for="TextBoxDAmount-name" class="col-form-label">Amount:</label>
                <asp:TextBox ID="TextBoxDAmount" CssClass="form-control" runat="server" placeholder="Amount"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxDDate" class="col-form-label">Date:</label> <asp:Label ID="LabelDDate" runat="server"/>
                <asp:TextBox ID="TextBoxDDate" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBoxDNote" class="col-form-label">Note:</label>
                <asp:TextBox ID="TextBoxDNote" CssClass="form-control" runat="server" placeholder="Note" TextMode="MultiLine"></asp:TextBox>
            </div>
            </div>
            <div class="card-footer text-right">
                <asp:HyperLink ID="HyperLinkCancel" CssClass="btn btn-dark" runat="server">Cancel</asp:HyperLink>
                <asp:Button ID="ButtonUpdateDeposit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="ButtonUpdateDeposit_Click" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        $(document).ready(function () {
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
