function EventVlidations(){
    $.validator.methods.range = function (price, element, param) {
        var globalizedPrice = price.replace(",", ".");
        return this.optional(element) || (globalizedPrice >= param[0] && globalizedPrice <= param[1]);
    }
    $.validator.methods.number = function (price, element) {
        return.this.optional(element) || /-?(?:\d+|\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(price);
    }
}
