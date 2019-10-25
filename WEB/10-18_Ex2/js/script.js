var MinhaBike = { marca: "", valor: "", peso: "" };

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="marca"]').val(MinhaBike.marca);
        $('input[name="valor"]').val(MinhaBike.valor);
        $('input[name="peso"]').val(MinhaBike.peso);


        $('input[name="bntsalvar"]').click(function () {
            MinhaBike.marca = $('input[name="marca"]').val();
            MinhaBike.valor = $('input[name="valor"]').val();
            MinhaBike.peso = $('input[name="peso"]').val();

        });

        $('input[name="bntmostrar"]').click(function () {
            alert("Marca: " + MinhaBike.marca + "\r\n Valor: " + MinhaBike.valor + "\r\n Peso: " + MinhaBike.peso);
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