$(document).ready(
    function () {
        $('input[type="button"]').click
        (
            function ()
            {
                var novoCep = $('input[name="cep"]').val()
                if (novoCep == "")
                    alert("CEP Inválido");
                else
                {
                    $.get("https://viacep.com.br/ws/" + novoCep + "/json/",function (data)
                        {
                            if (data.erro)
                            {
                                alert("CEP Inválido")
                            }
                            $('input[name="bairro"]').val(data.bairro);
                            $('input[name="cep"]').val(data.cep);
                            $('input[name="localidade"]').val(data.localidade);
                            $('input[name="logradouro"]').val(data.logradouro);
                            $('input[name="uf"]').val(data.uf);
                        });
                }
            }
        );
    }
);
/*
bairro: "Minas Gerais"
cep: "38402-100"
localidade: "Uberlândia"
logradouro: "Avenida Aírton Borges da Silva"
uf: "MG" 
 $('input[name="cpf"]').mask("000.000.000-00")*/