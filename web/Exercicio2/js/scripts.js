$(document).ready(
    function () {
        $('input[name="bnconverter"]').click(function () {

            var valordolar = 4.16;
            var valoreal = $('input[name=valorreal]').val();
            .replace(".", "")
                .replace(",", ".");
            var convercao = valoreal / valordolar;
            & ('input[name=valordolar]').val(convercao);
        });
    });


