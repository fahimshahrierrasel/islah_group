<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IslahGroup.CMS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | Islah Group</title>
    <link rel="stylesheet" href="../Content/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="../Content/font-awesome/css/font-awesome.css" />
    <link rel="stylesheet" href="../Content/day-night.css" />
    <style>
        .login-btn {
            width: 100%;
        }

        .centered {
            position: fixed;
            top: 50%;
            left: 50%;
            min-width: 25rem;
            transform: translate(-50%, -50%);
        }
    </style>
</head>
<body class="bg-dark">
    <div id="Clouds">
        <div class="Cloud Background1"></div>
        <div class="Cloud Background2"></div>
        <div class="Cloud Background1"></div>
        <div class="Cloud Background2"></div>
        <div class="Cloud Background1"></div>
        <div class="Cloud Background2"></div>
        <div class="Cloud Background2"></div>
        <div class="Cloud Background1"></div>
        <div class="Cloud Background2"></div>
        <div class="Cloud Background2"></div>
    </div>

    <div class="night">
        <div class="stars">
            <div id='star1'></div>
            <div id='star2'></div>
            <div id='star3'></div>
        </div>
        <div class="citynight1"></div>
        <div class="citynight2"></div>
        <div class="content">
            <a class="dayopen" data-target="day">
                <i class="fa fa-moon-o"></i>
            </a>
        </div>
    </div>

    <div id="day" class="day" style="display: none;">
        <div class="cityday1"></div>
        <div class="cityday2"></div>
        <div class="content">
            <a class="dayclose">
                <i class="fa fa-sun-o"></i>
            </a>
        </div>
    </div>

    <div class="container">
        <div class="card card-login text-dark centered">
            <div class="card-header text-dark">Login</div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <img src="../Images/islah_logo.png" class="mx-auto d-block" alt="Islah Logo" style="height: 100px" />
                    <div class="form-group mt-2">
                        <label for="TextboxEmail" class="text-dark">Email</label>
                        <asp:TextBox ID="TextboxEmail" type="email" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="TextPassword" class="text-dark">Password</label>
                        <asp:TextBox ID="TextPassword" type="password" CssClass="form-control" placeholder="Password" runat="server"></asp:TextBox>
                    </div>
                    <asp:Button ID="ButtonSubmit" CssClass="btn btn-primary login-btn" type="button" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                    <asp:Panel ID="PanelLoginMessage" CssClass="alert alert-warning alert-dismissible fade show text-dark mt-4 d-none" runat="server">
                        <strong>Warning!</strong><br />
                        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </asp:Panel>
                </form>
            </div>
        </div>
    </div>
    <script src="../Scripts/jquery-3.0.0.js"></script>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
    <script src="../Scripts/jquery-easing/jquery.easing.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script>
        jQuery(document).ready(function () {
            $('#form1').validate({
                rules: {
                    TextboxEmail: {
                        required: true,
                        email: true
                    },
                    TextPassword: {
                        required: true
                    }
                },
                messages: {
                    TextboxEmail: "You must enter your email!!",
                    TextPassword: "You must put your password!!"
                },
                errorElement: "div",
                errorPlacement: function (error, element) {
                    // Add the `help-block` class to the error element
                    error.addClass("invalid-feedback");
                    error.insertAfter(element);
                },
                highlight: function (element, errorClass, validClass) {
                    $(element).addClass("is-invalid").removeClass("is-valid");
                },
                unhighlight: function (element, errorClass, validClass) {
                    $(element).addClass("is-valid").removeClass("is-invalid");
                }
            });

            $('.dayopen').on('click', function (e) {
                var href, target;
                e.preventDefault();
                target = $(this).data('target');
                href = "#" + target;
                $("#" + target).fadeIn().addClass('activeday');
                return $(document).scrollTop(0);
            });
            return $('.dayclose').on('click', function (e) {
                e.preventDefault();
                return $('.activeday').fadeOut().removeClass('activeday');
            });
        });
    </script>
</body>
</html>
