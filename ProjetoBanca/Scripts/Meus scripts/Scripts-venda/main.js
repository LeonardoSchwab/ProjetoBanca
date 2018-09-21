$("#enviar-carrinho").click(function (event) {
    event.preventDefault();
    var precoTotal = 0;
    precoTotal += ($("#precoUnitario") * $("#quantidade"));
    $("#precoTotal").val(precoTotal);
    novaLinha();
    preencherLinha();
});

function novaLinha() {
    var $tbody = $("tbody");
    var linha = $("<tr>");
    var colunaID = $("<td>").addClass("id");
    var colunaProduto = $("<td>").addClass("produto");
    var colunaPrecoUni = $("<td>").addClass("precoUnitario");
    var colunaQuantidade = $("<td>").addClass("quantidade");

    var colunaRemover = $("<td>");
    var link = $("<a>").addClass("botao-remover").text("D");
    colunaRemover.append(link);

    linha.append(colunaID);
    linha.append(colunaProduto);
    linha.append(colunaPrecoUni);
    linha.append(colunaQuantidade);
    linha.append(colunaRemover);
}

function preencherLinha() {
    colunaProduto.text($("#produto").text());
    colunaQuantidade.text($("#quantidade").text());
    colunaPrecoUni.text($("#precoUnitario").text());
}