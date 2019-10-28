$(document).ready(function () {
    $('input[name="consultar"]').click(function () {
        //obter as informações dos meus campos
        //Obtemos as informações do nosso formulario web completo
        var informacoes = $('form[name="formImc"]').serializeArray();
        //Obtemos o atributo que indica a pagina que vamos enviar o post
        var obterAtributo = $('form[name="formImc"]').attr('send-post');

        //Enviamos o post para nosso servidor web
        $.post("http://localhost:55013/Api/CalculoImc?" + obterAtributo + ".php?", informacoes, function (data) {
            //aqui como recebemos uma string com formato de JSON
            //temos que passar ela para o JSON parecido com o int.Parse()
            data = JSON.parse(data);
            //Aqui carregamos as informações automaticamente
            $.each(data.CalculoImc, function (key, value) {
                $('p[name="{key}"'.replace("{key}", key)).text(value);
            });
        });
    });
});