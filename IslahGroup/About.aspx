<%@ Page Title="Islah Group | About" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="IslahGroup.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="parallax">
        <div class="aboutus">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h1>About US</h1>
                        <hr />
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-12">
                        <div class="person" style="float: left; display: inline-block;">
                            <span style="float: left; width: 20%;">
                                <img src="https://placeimg.com/640/480/any" width="570" height="500" />
                            </span>
                            <span style="float: right; width: 80%;">
                                <p style="float: right; display: block; padding-left: 10px;">
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliquaUt enim adminim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip commodo consequat.Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliquaUt enim adminim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip commodo consequat.Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliquaUt enim adminim veniam.adminim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip commodo consequat.Lorem ipsum dolor sit amet, consectetur adipisicing elit, do eiusmod tempor incididunt ut labore et dolore magna aliquaUt enim adminim veniam.
                                </p>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Main content  -->
    <div class="contact-body">
        <div class="container">
            <div class="team-member">
                <div class="row">
                    <div class="col-md-12">
                        <div class="heading-title">
                            <h4>Meet Our Managing Directores</h4>
                            <hr />
                        </div>
                    </div>
                </div>
                <div class="row">
                    <asp:Repeater ID="RepeaterOwners" runat="server">
                        <ItemTemplate>
                            <div class="col-md-3 col-sm-6 col-xs-12">
                                <div class="our-team">
                                    <div class="image">
                                        <asp:Image ImageUrl='<%# Eval("ImageUrl") %>' AlternateText='<%# Eval("FullName") %>' runat="server"/>
                                    </div>
                                    <div class="member">
                                        <h4><%# Eval("FullName") %></h4>
                                        <h6><%# Eval("Designation") %></h6>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
