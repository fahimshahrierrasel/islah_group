<%@ Page Title="Images" Language="C#" MasterPageFile="~/Masters/CMSMaster.Master" AutoEventWireup="true" CodeBehind="Images.aspx.cs" Inherits="IslahGroup.CMS.Images" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="card mx-auto mt-5 mb-5">
                <form id="formexpn" runat="server">
                    <div class="card-header">Upload Image</div>
                    <div class="card-body p-3">
                        <div class="form-group">
                            <label for="TextBoxImageText" class="col-form-label">Image Information:</label>
                            <asp:TextBox ID="TextBoxImageText" CssClass="form-control" TextMode="MultiLine" runat="server" placeholder="Short Information of Image" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="FileUploadImage" class="col-form-label">Image:</label><br />
                            <asp:FileUpload ID="FileUploadImage" runat="server" />
                        </div>
                    </div>
                    <div class="card-footer text-right">
                        <asp:Button ID="ButtonUploadImage" CssClass="btn btn-warning" runat="server" Text="Upload" OnClick="ButtonUploadImage_Click" />
                    </div>
                </form>
            </div>
        </div>
        <div class="row">
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                        <thead>
                            <tr>
                                <th>Date</th>
                                <th>Text</th>
                                <th>Status</th>
                                <th>Image</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Date</th>
                                <th>Text</th>
                                <th>Status</th>
                                <th>Image</th>
                                <th>Action</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="RepeaterAllImages" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("UploadDate", "{0:d}") %></a></td>
                                        <td><%# Eval("ImageText") %></td>
                                        <td><%# Eval("Status") %></td>
                                        <td><asp:Image Width="200px" ImageUrl='<%# Eval("ImageUrl") %>' runat="server" /></td>
                                        <td class="text-center"><a class="btn btn-warning m-1">Toggle Active</a></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
