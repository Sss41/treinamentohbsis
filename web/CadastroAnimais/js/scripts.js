var NomeDoguinho= { nome: "Bob" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomeusuario"]').val(NomeDoguinho.nome);


        $('input[name="bntsalvar"]').click(function () {
            NomeDoguinho.nome = $('input[name="nomeusuario"]').val();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(NomeDoguinho.nome);
        });

    }
);