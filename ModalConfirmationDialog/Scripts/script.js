$(document).ready(function () {
    // Confirmation Dialog
    $('#confirmDialog').dialog({
        autoOpen: false,
        width: 500,
        modal: true,
        resizable: false,
        buttons: {
            "Submit": function () {
                $(".ui-dialog-buttonpane button:contains('Submit')").button("disable");
                $(".ui-dialog-buttonpane button:contains('Edit')").button("disable");
                document.contactForm.submit();
            },
            "Edit": function () {
                $(this).dialog("close");
            }
        }
    });

    $('#contactForm').submit(function (e) {
        e.preventDefault();

        // Validate the fields with MVC validation.
        if ($(this).valid()) {
            var field;
            var confirmDiv;

            // Textbox.
            field = $("#Name");
            confirmDiv = $("#confirmName");
            if (field.val() == '') {
                confirmDiv.parent().hide();
            }
            else {
                confirmDiv.parent().show();
                confirmDiv.html(field.val());
            }

            // Textbox.
            field = $("#Email");
            confirmDiv = $("#confirmEmail");
            if (field.val() == '') {
                confirmDiv.parent().hide();
            }
            else {
                confirmDiv.parent().show();
                confirmDiv.html(field.val());
            }

            // Dropdown list.
            field = $("#Color_ID");
            confirmDiv = $("#confirmColor");
            if (field.val() == '0') {
                confirmDiv.parent().hide();
            }
            else {
                confirmDiv.parent().show();
                confirmDiv.html($("#Color_ID option:selected").text());
            }

            $('#confirmDialog').dialog('open');
        }
    });
});