<%@ Page Title="Islah Group | Contact" Language="C#" MasterPageFile="~/Masters/MainSite.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="IslahGroup.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-area">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 mx-auto">
                    <div class="card mx-auto mt-5 mb-5">
                        <div class="card-header">Contact Form</div>
                        <div class="card-block p-3">
                            <form>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Full Name</label>
                                    <input type="text" class="form-control" id="exampleInputname" aria-describedby="namehelp" placeholder="Your Name">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputPassword1">Mobile Number</label>
                                    <input type="text" class="form-control" id="exampleInputPhoneNumber" placeholder="Mobile Number">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Email address</label>
                                    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
                                    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputEmail1">Subject</label>
                                    <input type="text" class="form-control" id="exampleInputSubject" aria-describedby="subjectHelp" placeholder="Subject">
                                </div>
                                <div class="form-group">
                                    <label for="exampleInputPassword1">Your Message</label>
                                    <textarea class="form-control" rows="5" id="comment"></textarea>
                                </div>
                                <button type="submit" class="btn btn-primary float-right">Submit</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
