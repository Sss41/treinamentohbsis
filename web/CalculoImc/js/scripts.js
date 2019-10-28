
$(document).ready(function () {
    $('input[name="btnmostrar"]').click(function () {
        var informacoes = $('#Form1').serialize();
        var url = "http://localhost:61170/Api/CalculoImc?" + informacoes;
        $.getJSON(url, function (data) {  
            alert(data);
           
                });
    });



    $('input[name="btnfuncaopost"]').click(function () {
        var informacoes = $('#Form1').serializeArray();



        var url = "http://localhost:61170/Api/CalculoImc";


        $.post(url, informacoes, function (data) {
            alert(data);

        });
    });
    });
