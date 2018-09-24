$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();

    var id = $(this).parent().parent().find(".id").text();

    var dados = { ID: id };

    linha.remove();

    $.post("http://localhost:62680/Produto/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});