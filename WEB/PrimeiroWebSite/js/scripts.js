$(document).ready(
    function ()
    {
        /*set interval executa a cada 100ms*/
        atualizaData();
    });
/*Criamos nossa primeira fun��o*/
function atualizaData() {

    setInterval(function ()
    {
        /*Agora adicionamos a fun��o dentro de nosso context do setInterval*/
        $('span[name="data_atual"]').text(Date());

    }, 100);
    
}