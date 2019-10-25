
$(document).ready(function () {
    $('input[name="btnmostrar"]').click(function () {
        var informacoes = $('#Form1').serialize();
       
      
       
        var url = "http://localhost:61170/Api/CalculoImc?" + informacoes;


        $.getJSON(url, function (data) {  
            alert(data);
           
                });
        });
    });
