function EventValidations() {
    $.validator.methods.range = function (value, element, param) {
        var globalizedValue = value.replace(",", ".");
        return this.optional(element) || (globalizedValue >= param[0] && globalizedValue <= param[1]);
    };

    $.validator.methods.number = function (value, element) {
        return this.optional(element) || /-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
    };

    toastr.options = {
        closeButton: false,
        debug: false,
        newestOnTop: false,
        progressBar: false,
        positionClass: "toast-top-right",
        preventDuplicates: false,
        onclick: null,
        showDuration: "300",
        hideDuration: "1000",
        timeOut: "5000",
        extendedTimeOut: "1000",
        showEasing: "swing",
        hideEasing: "linear",
        showMethod: "fadeIn",
        hideMethod: "fadeOut"
    };

    $('#BeginDate, #EndDate').datepicker({
        format: "mm/dd/yyyy",
        startDate: "tomorrow",
        language: "en-US",
        orientation: "bottom right",
        autoclose: true
    });

    $(document).ready(function () {
        var $inputOnline = $("#Online");
        var $inputFree = $("#Free");

        function showAddress() {
            if ($inputOnline.is(":checked")) {
                $("#AddressForm").hide();
            } else {
                $("#AddressForm").show();
            }
        }

        function showPrice() {
            if ($inputFree.is(":checked")) {
                $("#Price").val("0").prop("disabled", true);
            } else {
                $("#Price").val("").prop("disabled", false);
            }
        }

        showAddress();
        showPrice();

        $inputOnline.on("click", showAddress);
        $inputFree.on("click", showPrice);
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
        $('form', dialog).submit(function (e) {
            e.preventDefault();

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
