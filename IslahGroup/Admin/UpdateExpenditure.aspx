<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="UpdateExpenditure.aspx.cs" Inherits="IslahGroup.Admin.UpdateExpenditure" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-register mx-auto mt-5 mb-5">
        <form id="formexpn" runat="server">
            <div class="card-header">Update Expenditure</div>
            <div class="card-body p-3">
                <div class="form-group">
                    <label for="TextBoxEDate" class="col-form-label">Date:</label>
                    <asp:TextBox ID="TextBoxEDate" CssClass="form-control" runat="server" Text="Label" readonly></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxEInfo" class="col-form-label">Information:</label>
                    <asp:TextBox ID="TextBoxEInfo" CssClass="form-control" TextMode="MultiLine" runat="server" placeholder="Short Information of expenditure" required="required"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxEType" class="col-form-label">Expenditure Type:</label>
                    <asp:TextBox ID="TextBoxEType" CssClass="form-control" runat="server" Text="Type" ReadOnly></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBoxEAmount" class="col-form-label">Amount:</label>
                    <asp:TextBox ID="TextBoxEAmount" CssClass="form-control" runat="server" onkeypress="return isNumberKey(event)" placeholder="Amount" required="required"></asp:TextBox>
                </div>
            </div>
            <div class="card-footer text-right">
                <a href="Expenditure.aspx" class="btn btn-dark">Cancel</a>
                <asp:Button ID="ButtonUpdateExpenditure" CssClass="btn btn-warning" runat="server" Text="Update" OnClick="ButtonUpdateExpenditure_Click" />
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
                    <%=TextBoxEInfo.UniqueID%>: {
                        required: true
                    },
                    <%=TextBoxEAmount.UniqueID%>: {
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
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode != 46 && (charCode < 48 || charCode > 57)))
                return false;
            return true;
        }
    </script>
</asp:Content>
