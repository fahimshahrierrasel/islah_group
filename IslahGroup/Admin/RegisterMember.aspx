<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/AdminSite.Master" AutoEventWireup="true" CodeBehind="RegisterMember.aspx.cs" Inherits="IslahGroup.Admin.RegisterMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #regForm {
            background-color: #ffffff;
            padding: 10px;
            min-width: 300px;
        }

        /* Mark input boxes that gets an error on validation: */
        input.invalid {
            background-color: #ffdddd;
        }

        /* Hide all steps by default: */
        .tab {
            display: none;
        }

        button:hover {
            opacity: 0.8;
        }

        /* Make circles that indicate the steps of the form: */
        .step {
            height: 15px;
            width: 15px;
            margin: 0 2px;
            background-color: #bbbbbb;
            border: none;
            border-radius: 50%;
            display: inline-block;
            opacity: 0.5;
        }

            .step.active {
                opacity: 1;
            }

            /* Mark the steps that are finished and valid: */
            .step.finish {
                background-color: #4CAF50;
            }
    </style>

    <div class="card card-register mx-auto mt-5 mb-5">
        <div class="card-header">Register New Member</div>
        <div class="card-block">
            <form id="regForm" action="#" runat="server">
                <!-- One "tab" for each step in the form: -->
                <div class="tab">
                    <h4>Personal Information:</h4>
                    <br />
                    <div class="form-group">
                        <label for="RegistrationDate">Registration Date</label>
                        <asp:TextBox ID="RegistrationDate" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ShareNo">Share No</label>
                        <asp:TextBox ID="ShareNo" CssClass="form-control" type="text" placeholder="Share No" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NidNo">National Identification Number (NID)</label>
                        <asp:TextBox ID="NidNo" CssClass="form-control" type="text" placeholder="NID No" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="FullName">Full Name</label>
                        <asp:TextBox ID="FullName" CssClass="form-control" type="text" placeholder="Full Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="FatherName">Father Name</label>
                        <asp:TextBox ID="FatherName" CssClass="form-control" type="text" placeholder="Father Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="MotherName">Mother Name</label>
                        <asp:TextBox ID="MotherName" CssClass="form-control" type="text" placeholder="Mother Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="HusbWifeName">Husband/Spouse Name</label>
                        <asp:TextBox ID="HusbWifeName" CssClass="form-control" type="text" placeholder="Husband/Spouse Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="PresentAddress">Present Address</label>
                        <asp:TextBox ID="PresentAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Present Address" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="ParmanentAddress">Parmanent Address</label>
                        <asp:TextBox ID="ParmanentAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Parmanent Address" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="DateOfBirth">Date of Birth</label>
                                <asp:TextBox ID="DateOfBirth" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="Education">Education</label>
                                <asp:TextBox ID="Education" CssClass="form-control" type="text" placeholder="Education" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="Profession">Profession</label>
                                <asp:TextBox ID="Profession" CssClass="form-control" type="text" placeholder="Profession" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="Nationality">Nationality</label>
                                <asp:TextBox ID="Nationality" CssClass="form-control" type="text" placeholder="Nationality" runat="server">Bangladeshi</asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="Gender">Gender</label>
                                <asp:DropDownList ID="Gender" CssClass="form-control" runat="server">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6">
                                <label for="BloodGroup">Blood Group</label>
                                <asp:DropDownList ID="BloodGroup" CssClass="form-control" runat="server">
                                    <asp:ListItem>A+</asp:ListItem>
                                    <asp:ListItem>A-</asp:ListItem>
                                    <asp:ListItem>B+</asp:ListItem>
                                    <asp:ListItem>B-</asp:ListItem>
                                    <asp:ListItem>AB+</asp:ListItem>
                                    <asp:ListItem>AB-</asp:ListItem>
                                    <asp:ListItem>O+</asp:ListItem>
                                    <asp:ListItem>O-</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="MobileNo">Mobile Number</label>
                                <asp:TextBox ID="MobileNo" CssClass="form-control" TextMode="Phone" placeholder="Mobile Number" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="Email">Email</label>
                                <asp:TextBox ID="Email" CssClass="form-control" TextMode="Email" placeholder="Email" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="tab">
                    <h4>Nominee Information:</h4>
                    <br />
                    <div class="form-group">
                        <label for="NomineeNidNo">National Identification Number (NID)</label>
                        <asp:TextBox ID="NomineeNidNo" CssClass="form-control" type="text" placeholder="NID No" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NomineeName">Nominee Name</label>
                        <asp:TextBox ID="NomineeName" CssClass="form-control" type="text" placeholder="Nominee Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NomineeFatherHusbandName">Father/Husband Name</label>
                        <asp:TextBox ID="NomineeFatherHusbandName" CssClass="form-control" type="text" placeholder="Father/Husband Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NomineeMotherName">Mother Name</label>
                        <asp:TextBox ID="NomineeMotherName" CssClass="form-control" type="text" placeholder="Mother Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="NomineeAddress">Nominee's Address</label>
                        <asp:TextBox ID="NomineeAddress" CssClass="form-control" TextMode="MultiLine" placeholder="Nominee's Address" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="NomineeDateOfBirth">Date of Birth</label>
                                <asp:TextBox ID="NomineeDateOfBirth" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="NomineeRelation">Relation with Nominee</label>
                                <asp:TextBox ID="NomineeRelation" CssClass="form-control" type="text" placeholder="Relation" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <label for="NomineeProfession">Profession</label>
                                <asp:TextBox ID="NomineeProfession" CssClass="form-control" type="text" placeholder="Profession" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-md-6">
                                <label for="NomineeMobileNo">Mobile No</label>
                                <asp:TextBox ID="NomineeMobileNo" CssClass="form-control" TextMode="Phone" placeholder="Mobile No" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="tab">
                    <h4>Introducer Information:</h4>
                    <br />
                    <div class="form-group">
                        <label for="IntroducerName">Introducer Name</label>
                        <asp:TextBox ID="IntroducerName" CssClass="form-control" type="text" placeholder="Introducer Name" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="IntroducerShareNo">Share No</label>
                        <asp:TextBox ID="IntroducerShareNo" CssClass="form-control" TextMode="Search" placeholder="Share No" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="tab">
                    <div class="form-group">
                        <label for="MemberImageUpload">Member's Photo</label>
                        <asp:FileUpload ID="MemberImageUpload" CssClass="form-control-file" runat="server" />
                    </div>
                    <div class="form-group">
                        <label for="NomineeImageUpload">Nominee's Image</label>
                        <asp:FileUpload ID="NomineeImageUpload" CssClass="form-control-file" runat="server" />
                    </div>
                </div>

                <div style="overflow: auto;">
                    <div style="float: right;">
                        <button class="btn btn-primary" type="button" id="prevBtn" onclick="nextPrev(-1)">Previous</button>
                        <button class="btn btn-success" type="button" id="nextBtn" onclick="nextPrev(1)">Next</button>
                        <asp:Button ID="FormSubmit" runat="server" CssClass="btn btn-danger d-none" Text="Submit" OnClick="FormSubmit_Click" />
                    </div>
                </div>

                <!-- Circles which indicates the steps of the form: -->
                <div style="text-align: center; margin-top: 40px;">
                    <span class="step"></span>
                    <span class="step"></span>
                    <span class="step"></span>
                    <span class="step"></span>
                </div>

            </form>

        </div>
    </div>
    <script>
        var currentTab = 0; // Current tab is set to be the first tab (0)
        showTab(currentTab); // Display the current tab

        function showTab(n) {
            // This function will display the specified tab of the form ...
            var x = document.getElementsByClassName("tab");
            x[n].style.display = "block";
            // ... and fix the Previous/Next buttons:
            if (n == 0) {
                document.getElementById("prevBtn").style.display = "none";
            } else {
                document.getElementById("prevBtn").style.display = "inline";
            }
            if (n == (x.length - 1)) {
                document.getElementById("nextBtn").classList.add("d-none");
                document.getElementById("ContentPlaceHolder1_FormSubmit").classList.remove("d-none");
            } else {
                document.getElementById("nextBtn").innerHTML = "Next";
                document.getElementById("nextBtn").classList.remove("d-none");
                document.getElementById("ContentPlaceHolder1_FormSubmit").classList.add("d-none");
            }
            // ... and run a function that displays the correct step indicator:
            fixStepIndicator(n)
        }

        function nextPrev(n) {
            // This function will figure out which tab to display
            var x = document.getElementsByClassName("tab");
            // Exit the function if any field in the current tab is invalid:
            if (n == 1 && !validateForm()) return false;
            // Hide the current tab:
            x[currentTab].style.display = "none";
            // Increase or decrease the current tab by 1:
            currentTab = currentTab + n;
            // if you have reached the end of the form... :
            if (currentTab >= x.length) {
                //...the form gets submitted:
                document.getElementById("regForm").submit();
                return false;
            }
            // Otherwise, display the correct tab:
            showTab(currentTab);
        }

        function validateForm() {
            // This function deals with validation of the form fields
            var x, y, i, valid = true;
            x = document.getElementsByClassName("tab");
            y = x[currentTab].getElementsByTagName("input");
            // A loop that checks every input field in the current tab:
            for (i = 0; i < y.length; i++) {
                // If a field is empty...
                if (y[i].value == "") {
                    // add an "invalid" class to the field:
                    y[i].className += " invalid";
                    // and set the current valid status to false:
                    valid = false;
                }
            }
            // If the valid status is true, mark the step as finished and valid:
            if (valid) {
                document.getElementsByClassName("step")[currentTab].className += " finish";
            }
            return valid; // return the valid status
        }

        function fixStepIndicator(n) {
            // This function removes the "active" class of all steps...
            var i, x = document.getElementsByClassName("step");
            for (i = 0; i < x.length; i++) {
                x[i].className = x[i].className.replace(" active", "");
            }
            //... and adds the "active" class to the current step:
            x[n].className += " active";
        }
    </script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
