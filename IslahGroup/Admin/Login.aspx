<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IslahGroup.Views.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Islah Group | Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fdb-block" style="background-image: linear-gradient(27deg, #4d919b 0%, #85da75 100%)">
        <div class="container">
            <div class="row justify-content-end">
                <div class="col-12 col-md-8 col-lg-6 col-xl-5 text-left">
                    <div class="fdb-box">
                        <div class="row">
                            <div class="col">
                                <h1>Log In</h1>
                                <asp:Panel ID="PanelLoginMessage" CssClass="alert alert-warning d-none" runat="server" role="alert"></asp:Panel>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col mt-4">
                                <asp:TextBox ID="TextboxUsername" type="text" CssClass="form-control" placeholder="Username" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mt-4">
                            <div class="col">
                                <asp:TextBox ID="TextPassword" type="password" CssClass="form-control" placeholder="Password" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="row mt-4">
                            <div class="col">
                                <asp:Button ID="ButtonSubmit" CssClass="btn" type="button" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
