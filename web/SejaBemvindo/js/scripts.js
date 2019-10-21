$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {

                var nome = $('input[name="nome"]').val();
                alert("Ola "  +  nome + "Bem vindo ao site.");
            })
    });
$(document).ready(
    function () {
        $('button[type="button"]').click(
            function () {

                var nome = $('input[name="nome"]').val();
                $('span[name="nspam"]').text("Bem vindo " + nome);
            })
    });