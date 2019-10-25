//carregamnto do documento
$(document).ready(function () {
    //adicionando uma função ao clique do botão
    $('#Button1').click(function () {
        //conectando com apri web
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function(data){
            //loop para cada objeto
            $.each(data, function (key, value) {
                //crimamos uma variavel que irá armazenar a informação
                var templateContent ="";
                //iniciamos um separador de informações
                templateContent += "{";
                //outro laço para repetir para cada informação
                $.each(value, function (key, value) {
                    //adicionamos todas as informações do nosso objeto
                    templateContent += key + ":" + value + ",";
                });
                //finalizamos nosso objeto
                templateContent += "}";
                //adicionamos ao nosso ampo de texto
                $('#divContent').append(
                    "<textarea>" + templateContent + "</textarea>"
                );
            });
        });
    });
});