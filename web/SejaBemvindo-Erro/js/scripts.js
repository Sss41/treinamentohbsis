$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {

                var nome = $('input[name="nome"]').val();
                alert("Olá" + nome + "bem vindo a cervejaria");
            }
    });