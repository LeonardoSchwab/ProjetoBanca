$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();

    var id = $(this).parent().parent().find(".id").text();
    var nome = $(this).parent().parent().find(".nome").text();
    var preco = $(this).parent().parent().find(".preco").text();
    var unidade = $(this).parent().parent().find(".unidade").text();
    var categoria = $(this).parent().parent().find(".categoria").text();
    var fornecedor = $(this).parent().parent().find(".fornecedor").text();


    var dados = { ID: id, Nome: nome, Preco: preco, Unidade: unidade, CategoriaID: categoria, FornecedorID: fornecedor };

    linha.remove();

    $.post("http://localhost:62680/Produto/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});