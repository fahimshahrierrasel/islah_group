﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IslahGroup.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
    <title>Islah Group | Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="fdb-block" style="background-image: url(./images/islah_logo.png)">
        <div class="container">
            <div class="row justify-content-end">
                <div class="col-12 col-md-8 col-lg-6 col-xl-5 text-left">
                    <div class="fdb-box">
                        <div class="row">
                            <div class="col">
                                <h1>Log In</h1>
                                <p class="text-h3">Right at the coast of the Semantics, a large language ocean. A small river named Duden.</p>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col mt-4">
                                <input type="text" class="form-control" placeholder="Email">
                            </div>
                        </div>
                        <div class="row mt-4">
                            <div class="col">
                                <input type="password" class="form-control" placeholder="Password">
                            </div>
                        </div>
                        <div class="row mt-4">
                            <div class="col">
                                <button class="btn" type="button">Submit</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>