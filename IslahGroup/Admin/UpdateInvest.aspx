<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="UpdateInvest.aspx.cs" Inherits="IslahGroup.Admin.UpdateInvest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <form id="formexpn" runat="server">
            <div class="card-header">Update Invest</div>
            <div class="card-body p-3">
                <div class="form-group">
                    <label for="TextBoxIDate" class="col-form-label">Date:</label>
                    <asp:TextBox ID="TextBoxIDate" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxIAmount" class="col-form-label">Amount:</label>
                    <asp:TextBox ID="TextBoxIAmount" CssClass="form-control" runat="server" placeholder="Amount"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxIProfit" class="col-form-label">Profit(%):</label>
                    <asp:TextBox ID="TextBoxIProfit" CssClass="form-control" runat="server" placeholder="Profit(%)"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxInvestType" class="col-form-label">Type:</label>
                    <asp:TextBox ID="TextBoxInvestType" CssClass="form-control" runat="server" readonly></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxINote" class="col-form-label">Note:</label>
                    <asp:TextBox ID="TextBoxINote" CssClass="form-control" runat="server" placeholder="Note" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="card-footer text-right">
                <asp:HyperLink ID="HyperLinkCancel" class="btn btn-dark" runat="server">Cancel</asp:HyperLink>
                <asp:Button ID="ButtonUpdateInvest" CssClass="btn btn-warning" runat="server" Text="Update" OnClick="ButtonUpdateInvest_Click" />
            </div>
        </form>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#formexpn').validate({
                rules: {
                    <%=TextBoxINote.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxIAmount.UniqueID%>: {
                        required: true,
                        number: true
                    },
                    <%=TextBoxIProfit.UniqueID%>: {
                        required: true,
                        number: true
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
