
$(document).ready
(
    function ()
    {
        $('input[name="btnboasvindas"]').click(function ()
        {
            var nomeusuario = $('input[name="nome"]').val();
            $('span[name="usuariotext"]').text(nomeusuario);
        });
    }  
);

/*
$("#buttonEnviar").click(function (){alert("Bem vindo ao meu site " + $("#nome").val());});
*/

  
