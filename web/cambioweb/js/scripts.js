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

                var url ="https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";
                    $.getJSON(url, function (data) {
                        var valortotal = data.value[0].cotacaoVenda;
                        var real = $('input[name="moeda reais"]').val().replace("R$ ", "").replace(".", "");
                        var realmoeda = $('input[name="Moeda"]').val().replace("R$ ", "").replace(".", "");
                        var valorReal = parseFloat(real) /valortotal;

                        CurrencyFormat(valorReal);

                    });

               
            });


    });
function CurrencyFormat(value) {
   var variavel= new Number(value).toLocaleString("eng", {
        style: "currency",
        currency: "USD"
    });
    return $('input[name="convertido"]').val(variavel);
}