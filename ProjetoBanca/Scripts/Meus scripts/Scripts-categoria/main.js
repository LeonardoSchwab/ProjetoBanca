$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();
       
    var id = $(this).parent().parent().find(".id").text();
    var nome = $(this).parent().parent().find(".nome").text();

    var dados = {ID: id, Nome: nome };

    linha.remove();

    $.post("http://localhost:62680/Categoria/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});
