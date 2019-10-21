var Nomebicicleta = {
    nome: $('input[name="marca"]').val("Caloi"),
    valor: $('input[name="valor"]').val("1200"),
    peso: $('input[name="peso"]').val("12kg"),
    
};

$(document).ready(
    function () {
        /* Carrego defaul name */


        $('input[name="btnsalvar"]').click(function () {

            Nomebicicleta = {
                nome: $('input[name="marca"]').val(),
                valor: $('input[name="valor"]').val(),
                peso: $('input[name="peso"]').val(),

            };

            alert(Nomebicicleta.nome + "\n" + Nomebicicleta.valor + "\n" + Nomebicicleta.peso);
            LimparTela();
        });
        $('input[name="btnmostrar"]').click(function () {
            alert(Nomebicicleta.nome + "\n" + Nomebicicleta.valor + "\n" + Nomebicicleta.peso);
        });

    });
function LimparTela() {
    var meusInputs = $('input[type="text"],input[type="number"]');
   
        meusInputs.val("");
    
}