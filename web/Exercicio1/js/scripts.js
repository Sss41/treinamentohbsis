$(document).ready(
    function () {
        $('input[name="btnboasvindas"]').click(function () {
            $('button[name="nomeusuario"]').val();
			$('span[name="usuariotext"]').text(nomeusuario)
            
            
        });

    });
$(document).on('Keypress', function (e) {
    if (e.which === 13) {
        $('input[name="btnboasvindas"]').click();
    }
});