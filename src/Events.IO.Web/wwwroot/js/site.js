function EventValidations() {
    // Custom validator methods
    $.validator.methods.range = function (value, element, param) {
        var globalizedValue = value.replace(",", ".");
        return this.optional(element) || (globalizedValue >= param[0] && globalizedValue <= param[1]);
    }

    $.validator.methods.number = function (value, element) {
        return this.optional(element) || /^-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
    }

    // Toastr configuration
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    // Datepicker configuration
    $('#BeginDate, #EndDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: new Date(),
        language: "en-US",
        orientation: "bottom right",
        autoclose: true
    });

    // Toggle visibility of address and price fields based on online and free checkboxes
    $(document).ready(function () {
        var $inputOnline = $("#Online");
        var $inputFree = $("#Free");

        ShowPrice();
        ShowAddress();

        $inputOnline.click(function () {
            ShowAddress();
        })
        $inputFree.click(function () {
            ShowPrice();
        })

        function ShowAddress() {
            if ($inputOnline.is(":checked")) $("#AddressForm").hide();
            else $("#AddressForm").show();
        }

        function ShowPrice() {
            if ($inputFree.is(":checked")) {
                $("#Price").prop("disabled", true)
            } else {
                $("#Price").prop("disabled", false)
            }
        }

    });
}

function AjaxModal() {
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                keyboard: true
                            },
                                'show');
                            bindForm(this);
                        });
                    return false;
                });
        });

        function bindForm(diaolog) {
            $('form', dialog).submit(function (){
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#AddressTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            })
        }
    })
}
