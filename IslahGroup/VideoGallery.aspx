<%@ Page Title="Islah Group | Videos" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="VideoGallery.aspx.cs" Inherits="IslahGroup.VideoGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mb-5">
        <div class="row">
            <div class="col-md-12 ig_i2">
                <div class="ig_i1">
                    <h1>VIDEO GALLERY</h1>
                    <hr></hr>
                </div>
            </div>
        </div>
        <div class="row">
            <asp:Repeater ID="RepeaterAllVideos" runat="server">
                <ItemTemplate>
                    <div class="col-sm-4 col-md-4 m-1">
                        <div class="embed-responsive embed-responsive-16by9">
                            <iframe class="embed-responsive-item" src='<%# Eval("VideoUrl")%>' allowfullscreen></iframe>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
