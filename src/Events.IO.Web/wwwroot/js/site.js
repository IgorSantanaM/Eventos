function EventValidations() {
    $.validator.methods.range = function (price, element, param) {
        var globalizedPrice = price.replace(",", ".");
        return this.optional(element) || (globalizedPrice >= param[0] && globalizedPrice <= param[1]);
    };

    $.validator.methods.number = function (value, element) {
        return this.optional(element) || /-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
    };
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

    $('#BeginDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: "tomorrow",
        language: "en-US",
        orientation: "bottom right",
        autoclose: true
    });

    $('#EndDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: "tomorrow",
        language: "en-US",
        orientation: "bottom right",
        autoclose: true
    });

    $(document).ready(function () {
        var $inputOnline = $("#Online");
        var $inputFree = $("#Free");

        ShowAddress();
        ShowPrice();

        $inputOnline.click(function () {
            ShowAddress();
        });

        $inputFree.click(function () {
            ShowPrice();
        });

        function ShowAddress() {
            if ($inputOnline.is(":checked")) {
                $("#AddressForm").hide();
            } else {
                $("#AddressForm").show();
            }
        }

        function ShowPrice() {
            if ($inputFree.is(":checked")) {
                $("#Price").val("0");
                $("#Price").prop("disabled", true);
            } else {
                $("#Price").val("");
                $("#Price").prop("disabled", false);
            }
        }
    });
}

function AjaxModal() {
    $(document).ready(function () {
        $.ajaxSetup({ cache: false });

        $("a[data-modal]").on("click", function (e) {
            e.preventDefault();
            var href = this.href;

            $("#myModalContent").load(href, function () {
                $('#myModal').modal({
                    keyboard: true
                }).modal('show');
                bindForm(this);
            });

            return false;
        });
    });

    function bindForm(dialog) {
        $('form', dialog).submit(function () {
            $.ajax({
                url: this.action,
                type: this.method,
                data: $(this).serialize(),
                success: function (result) {
                    if (result.success) {
                        $('#myModal').modal('hide');
                        $('#replacetarget').load(result.url);
                    } else {
                        $('#myModalContent').html(result);
                        bindForm(dialog);
                    }
                }
            });

            return false;
        });
    }
}

