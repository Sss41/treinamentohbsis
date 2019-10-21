var NomeDoguinho = {
    nome: $('input[name="nomeusuario"]').val("Bob"),
    coloracao: $('input[name="coloração"]').val("azul"),
    Idade: $('input[name="idade"]').val("9"),
    raça: $('input[name="raça"]').val("pug"),
};

$(document).ready(
    function () {
        /* Carrego defaul name */
        

        $('input[name="btnsalvar"]').click(function () {
           
            NomeDoguinho = {
                nome: $('input[name="nomeusuario"]').val(),
                coloracao: $('input[name="coloração"]').val(),
                Idade: $('input[name="idade"]').val(),
                raça: $('input[name="raça"]').val(),
            };
       
            alert(NomeDoguinho.nome+"\n"+NomeDoguinho.coloracao+"\n"+NomeDoguinho.Idade+"\n"+NomeDoguinho.raça);
            LimparTela();
        });

        $('input[name="btnmostrar"]').click(function () {
            alert(NomeDoguinho.nome+"\n"+NomeDoguinho.coloracao+"\n"+NomeDoguinho.Idade+"\n"+NomeDoguinho.raça);
        });

    }
);
function LimparTela() {
    var meusInputs=$('input[type="text"],input[type="number"]');
    for (var i = 0;i<meusInputs.length;i++){
        meusInputs.val("");
    }
}