<%@ Page Title="Islah Group | Images" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="ImageGallery.aspx.cs" Inherits="IslahGroup.ImageGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <%--<link rel="stylesheet" href="Content/image_gallery_style.css">--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- The Gallery as lightbox dialog, should be a child element of the document body -->


    <div class="container">
        <h1 class="my-4 text-center text-lg-center">Image Gallery</h1>
        <hr></hr>
        <div class="row text-center text-lg-left">
            <asp:Repeater ID="RepeaterAllImages" runat="server">
                <ItemTemplate>
                    <div class="col-sm-3">
                        <a href="#" data-lightbox="<%# Eval("ImageUrl").ToString().Remove(0,2) %>" data-gallery-id="Image1">
                            <asp:Image ID="Image1" ImageUrl='<%# Eval("ImageUrl") %>' runat="server" CssClass="img-responsive" />
                        </a>
                        <p>
                            <%# Eval("ImageText") %>
                        </p>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <!-- /.container -->
    <a class="bloc-button btn btn-d scrollToTop" onclick="scrollToTarget('1')"><span class="fa fa-chevron-up"></span></a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="Scripts/blocs.js"></script>
    <script src="Scripts/jquery.touchSwipe.min.js"></script>
</asp:Content>
