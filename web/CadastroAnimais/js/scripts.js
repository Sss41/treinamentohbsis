var NomeDoguinho = {
    nome: $('input[name="nomeusuario"]').val("Bob"),
    coloracao: $('input[name="colora��o"]').val("azul"),
    Idade: $('input[name="idade"]').val("9"),
    ra�a: $('input[name="ra�a"]').val("pug"),
};

$(document).ready(
    function () {
        /* Carrego defaul name */
        

        $('input[name="btnsalvar"]').click(function () {
           
            NomeDoguinho = {
                nome: $('input[name="nomeusuario"]').val(),
                coloracao: $('input[name="colora��o"]').val(),
                Idade: $('input[name="idade"]').val(),
                ra�a: $('input[name="ra�a"]').val(),
            };
       
            alert(NomeDoguinho.nome+"\n"+NomeDoguinho.coloracao+"\n"+NomeDoguinho.Idade+"\n"+NomeDoguinho.ra�a);
            LimparTela();
        });

        $('input[name="btnmostrar"]').click(function () {
            alert(NomeDoguinho.nome+"\n"+NomeDoguinho.coloracao+"\n"+NomeDoguinho.Idade+"\n"+NomeDoguinho.ra�a);
        });

    }
);
function LimparTela() {
    var meusInputs=$('input[type="text"],input[type="number"]');
    for (var i = 0;i<meusInputs.length;i++){
        meusInputs.val("");
    }
}