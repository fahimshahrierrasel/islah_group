<%@ Page Title="Islah Group | Images" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="ImageGallery.aspx.cs" Inherits="IslahGroup.ImageGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <link rel="stylesheet" href="Content/blueimp-gallery.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Content -->
    <div class="parallax1">
        <div class="container">
            <h1 class="my-4 text-center text-lg-center">Image Gallery</h1>
            <hr></hr>
            <div class="row text-center text-lg-left links" id="links">
                <asp:Repeater ID="RepeaterAllImages" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-4 col-xs-6">
                            <a href='<%# Eval("ImageUrl") %>' class="d-block mb-4 h-100">
                                <asp:Image CssClass="img-fluid img-thumbnail" Width="200px" ImageUrl='<%# Eval("ImageUrl") %>' runat="server" />
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!-- /.container -->
    </div>

    <!-- The Gallery as lightbox dialog, should be a child element of the document body -->
    <div id="blueimp-gallery" class="blueimp-gallery blueimp-gallery-controls">
        <div class="slides"></div>
        <h3 class="title"></h3>
        <!-- The placeholder for the description label: -->
        <p class="description"></p>
        <a class="prev">‹</a>
        <a class="next">›</a>
        <a class="close">×</a>
        <a class="play-pause"></a>
        <ol class="indicator"></ol>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="Scripts/blueimp-gallery.js"></script>
    <script>
        document.getElementById('links').onclick = function (event) {
            event = event || window.event;
            var target = event.target || event.srcElement,
                link = target.src ? target.parentNode : target,
                options = { index: link, event: event },
                links = this.getElementsByTagName('a');
            blueimp.Gallery(links, options);
        };
    </script>
</asp:Content>
