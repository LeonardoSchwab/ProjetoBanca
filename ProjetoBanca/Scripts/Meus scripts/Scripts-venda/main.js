var precoTotal = 0;
$("#enviar-carrinho").click(function (event) {
    event.preventDefault();    
    precoTotal += ($("#precoUnitario").val() * $("#quantidade").val());
    $("#precoTotal").val(precoTotal);
    var linha = novaLinha();
    linha.find(".botao-remover").click(function () {

    });
});

function novaLinha() {
    var $tbody = $("tbody");
    
    var linha = $("<tr>");
    var colunaID = $("<td>").addClass("id");
    var colunaProduto = $("<td>").addClass("produto");
    var colunaPrecoUni = $("<td>").addClass("precoUnitario");
    var colunaQuantidade = $("<td>").addClass("quantidade");
        
    colunaProduto.text($("#produto").val());
    colunaQuantidade.text($("#quantidade").val());
    colunaPrecoUni.text($("#precoUnitario").val());

    var colunaRemover = $("<td>");
    var link = $("<a>").addClass("botao-remover").attr("href", "#").text("D");
    colunaRemover.append(link);

    linha.append(colunaID);
    linha.append(colunaProduto);
    linha.append(colunaPrecoUni);
    linha.append(colunaQuantidade);
    linha.append(colunaRemover);

    $tbody.append(linha);
    
    return linha;
}

function preencherLinha() {    
}