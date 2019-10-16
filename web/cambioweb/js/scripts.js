$(function () {
    $('input[name = "moeda reais"]').maskMoney({
        prefix: 'R$ ',
        thousands: '.',
        decimal: ','
    });

    $('input[name = "Moeda"]').maskMoney({
        prefix: 'R$ ',
        thousands: '.',
        decimal: ','
    });
})


$(document).ready(
    function () {
        $('button[type="button"]').click(
            function () {

                var real = $('input[name="moeda reais"]').val().replace("R$ ", "").replace(".", "");
                var realmoeda = $('input[name="Moeda"]').val().replace("R$ ", "").replace(".", "");
                var valorReal = parseFloat(real) / parseFloat(realmoeda) ;
               
                CurrencyFormat(valorReal);
            });


    });
function CurrencyFormat(value) {
   var variavel= new Number(value).toLocaleString("eng", {
        style: "currency",
        currency: "USD"
    });
    return $('input[name="convertido"]').val(variavel);
}