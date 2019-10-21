
$(document).ready(function () {
        $('input[type="button"]').click(function () {
                var cep = $('input[name="cep"]').val();
                if (cep == "")
                    $('input[type="text"]').val('');
            $.get("https://viacep.com.br/ws/" + cep + "/json/", function (data, status) {
                if (data.erro) {
                    alert("cep inválido!");
                    $('input[type="text"]').val('');
                    return false;
                }
                   $('input[name="bairro"]').val(data.bairro);                   
                    $('input[name="complemento"]').val(data.complemento);
                    $('input[name="gia"]').val(data.gia);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="localidade"]').val(data.localidade);
                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="uf"]').val(data.bairro);
                    $('input[name="unidade"]').val(data.unidade);
                    
                });
            }
        );
    }
);
