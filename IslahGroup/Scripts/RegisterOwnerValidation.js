jQuery(document).ready(function () {
    $('#regForm').validate({
        rules: {
            RegistrationDate: {
                required: true,
                date: true
            },
            ShareNo: {
                required: true,
                digits: true
            },
            NidNo: {
                required: true,
                digits: true
            },
            FullName: {
                required: true
            },
            FatherName: {
                required: true
            },
            MotherName: {
                required: true
            },
            HusbWifeName: {
                required: true
            },
            PresentAddress: {
                required: true
            },
            ParmanentAddress: {
                required: true
            },
            DateOfBirth: {
                required: true,
                date: true
            },
            Education: {
                required: true
            },
            Profession: {
                required: true
            },
            Nationality: {
                required: true
            },
            Gender: {
                required: true
            },
            BloodGroup: {
                required: true
            },
            MobileNo: {
                required: true,
                digits: true,
                maxlength: 12,
                minlength: 11
            },
            Email: {
                required: true,
                email: true
            },
            TextBoxDesignation: {
                required: true
            },
            NomineeNidNo: {
                required: true,
                digits: true
            },
            NomineeName: {
                required: true
            },
            NomineeFatherHusbandName: {
                required: true
            },
            NomineeMotherName: {
                required: true
            },
            NomineeAdderess: {
                required: true
            },
            NomineeDateOfBirth: {
                required: true,
                date: true
            },
            NomineeRelation: {
                required: true
            },
            NomineeProfession: {
                required: true
            },
            NomineeMobileNo: {
                required: true,
                digits: true,
                maxlength: 12,
                minlength: 11
            },
            MemberImageUpload: {
                required: true
            },
            NomineeImageUpload: {
                required: true
            }
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
});