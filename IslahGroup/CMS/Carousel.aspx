<%@ Page Title="Carousel" Language="C#" MasterPageFile="~/Masters/CMSMaster.Master" AutoEventWireup="true" CodeBehind="Carousel.aspx.cs" Inherits="IslahGroup.CMS.Carousel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="card mx-auto card-register">
            <div class="card-header">Carousel Uploader</div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label for="DropDownListCarouselSelector">Carousel Selector</label>
                        <asp:DropDownList ID="DropDownListCarouselSelector" CssClass="form-control" runat="server">
                            <asp:ListItem>Carousel 1</asp:ListItem>
                            <asp:ListItem>Carousel 2</asp:ListItem>
                            <asp:ListItem>Carousel 3</asp:ListItem>
                            <asp:ListItem>Carousel 4</asp:ListItem>
                            <asp:ListItem>Carousel 5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group mb-3">
                        <label for="CarouselUpload">Carousel File Input (Recommened Size: 1920 X 850, File Format: .jpg)</label>
                        <asp:FileUpload ID="CarouselUpload" class="form-control-file" runat="server" accept=".jpg"/>
                    </div>
                    <asp:Button ID="ButtonCarouselUpload" CssClass="btn btn-primary float-right" runat="server" Text="Upload" OnClick="ButtonCarouselUpload_Click" />
                </form>
            </div>
        </div>
        <div class="card mx-auto mb-3 mt-3">
            <div class="card-header">Carousels</div>
            <div class="card-body">
                <table class="table">
                    <caption>List of carousels</caption>
                    <thead>
                        <tr>
                            <th scope="col">#</th>
                            <th scope="col">Name</th>
                            <th scope="col">Image</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row">1</th>
                            <td>Carousel 1</td>
                            <td>
                                <asp:Image ID="Image1" Width="300px" ImageUrl="~/Upload/Images/Carousels/carousel1.jpg" AlternateText="Carousel 1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">2</th>
                            <td>Carousel 2</td>
                            <td>
                                <asp:Image ID="Image2" Width="300px" ImageUrl="~/Upload/Images/Carousels/carousel2.jpg" AlternateText="Carousel 2" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">3</th>
                            <td>Carousel 3</td>
                            <td>
                                <asp:Image ID="Image3" Width="300px" ImageUrl="~/Upload/Images/Carousels/carousel3.jpg" AlternateText="Carousel 3" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">4</th>
                            <td>Carousel 4</td>
                            <td>
                                <asp:Image ID="Image4" Width="300px" ImageUrl="~/Upload/Images/Carousels/carousel4.jpg" AlternateText="Carousel 4" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <th scope="row">5</th>
                            <td>Carousel 5</td>
                            <td>
                                <asp:Image ID="Image5" Width="300px" ImageUrl="~/Upload/Images/Carousels/carousel5.jpg" AlternateText="Carousel 5" runat="server" />
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
