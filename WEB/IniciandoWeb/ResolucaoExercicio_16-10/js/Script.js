/*Ao carregar nosso site por completo executa o conteudo do documento $(document).ready()*/
$(document).ready(
    function () {
        //Informamos que no botão do click ele ira chamar nosso alerta
        $('input[name="btnboasvindas"]').click(function () {
            /*Aquit obtemos o valor digitado pelo usuario*/
            var nomeusuario = $('input[name="nomeusuario"]').val();
            alert("Seja bem vindo" + nomeusuario + " ao nosso sistema de cervejaria.");                       
        });       
    }
);