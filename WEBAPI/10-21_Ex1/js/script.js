$(document).ready(
    function () {
        $('input[type="button"]').click
        (
            function ()
            {
                var novoCep = $('input[name="cep"]').val()
                if (novoCep == "")
                    alert("CEP Inv�lido");
                else
                {
                    $.get("https://viacep.com.br/ws/" + novoCep + "/json/",function (data)
                        {
                            if (data.erro)
                            {
                                alert("CEP Inv�lido")
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
localidade: "Uberl�ndia"
logradouro: "Avenida A�rton Borges da Silva"
uf: "MG" 
 $('input[name="cpf"]').mask("000.000.000-00")*/