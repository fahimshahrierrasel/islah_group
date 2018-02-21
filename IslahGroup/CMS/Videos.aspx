<%@ Page Title="Videos" Language="C#" MasterPageFile="~/Masters/CMSMaster.Master" AutoEventWireup="true" CodeBehind="Videos.aspx.cs" Inherits="IslahGroup.CMS.Videos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="card mx-auto mt-5 mb-5">
                <form id="formexpn" runat="server">
                    <div class="card-header">Upload Video</div>
                    <div class="card-body p-3">
                        <div class="form-group">
                            <label for="TextBoxVideoText" class="col-form-label">Video Information:</label>
                            <asp:TextBox ID="TextBoxVideoText" CssClass="form-control" TextMode="MultiLine" runat="server" placeholder="Short Information of Video" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="TextBoxVideoUrl" class="col-form-label">Video ID: https://www.youtube.com/watch?v=<label class="text-danger"><u>tf7IEVTDjng</u></label></label><br />
                            <asp:TextBox ID="TextBoxVideoUrl" TextMode="Url" CssClass="form-control" placeholder="Youtube Video ID Ex: tf7IEVTDjng"  runat="server" required="required"></asp:TextBox>
                        </div>
                    </div>
                    <div class="card-footer text-right">
                        <asp:Button ID="ButtonUploadVideo" CssClass="btn btn-warning" runat="server" Text="Upload" OnClick="ButtonUploadVideo_Click" />
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
                                <th>Video URL</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Date</th>
                                <th>Text</th>
                                <th>Status</th>
                                <th>Video URL</th>
                                <th>Action</th>
                            </tr>
                        </tfoot>
                        <tbody>
                            <asp:Repeater ID="RepeaterAllVideos" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("UploadDate", "{0:d}") %></a></td>
                                        <td><%# Eval("VideoText") %></td>
                                        <td><%# Eval("Status") %></td>
                                        <td><%# Eval("VideoUrl") %></td>
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
