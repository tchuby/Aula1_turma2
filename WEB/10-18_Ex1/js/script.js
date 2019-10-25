var MinhaBike = { nome:"", idade:"", raca:"", coloracao:"" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="nomedog"]').val(MinhaBike.nome);
        $('input[name="idade"]').val(MinhaBike.idade);
        $('input[name="raca"]').val(MinhaBike.raca);
        $('input[name="coloracao"]').val(MinhaBike.coloracao);


        $('input[name="bntsalvar"]').click(function () {
            MinhaBike.nome = $('input[name="nomedog"]').val();
            MinhaBike.idade = $('input[name="idade"]').val();
            MinhaBike.raca = $('input[name="raca"]').val();
            MinhaBike.coloracao = $('input[name="coloracao"]').val();
            
        });

        $('input[name="bntmostrar"]').click(function () {
            alert("Nome: " + MinhaBike.nome + "\r\n Idade: " + MinhaBike.idade + "\r\n Raça: " + MinhaBike.raca + "\r\n Coloração: " + MinhaBike.coloracao);
            LimparTela();
        });

    }
);
function LimparTela() {
    meusInputs = $('input[type="text"]');
    for (var i = 0; i < meusInputs.length; i++) {
        meusInputs.val("");
    }   
}