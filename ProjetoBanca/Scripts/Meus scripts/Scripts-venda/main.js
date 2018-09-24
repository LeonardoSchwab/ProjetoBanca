var precoTotal = 0;
var itemsTotal = 0;
$("#enviar-carrinho").click(function (event) {
    event.preventDefault();    
    precoTotal += ($("#precoUnitario").val() * $("#quantidade").val());
    $("#precoTotal").val(precoTotal);

    itemsTotal += parseInt($("#quantidade").val());
    $("#quantidadeTotal").val(itemsTotal);

    var linha = novaLinha();
    linha.find(".botao-remover").click(function () {
        linha.remove();
    });
});

$("#finalizar-compra").click(function (event) {
    event.preventDefault();

    var precoTotal = $("#precoTotal").val();
    var quantidadeTotal = $("#quantidadeTotal").val();

    var dadosVenda = { PrecoTotal: precoTotal, Quantidade: quantidadeTotal };

    $.post("http://localhost:62680/Venda/Adiciona", dadosVenda, function () {
        console.log("Sucesso!");
        var linhas = $("tbody").find("tr");

        linhas.each(function () {
            var produtoId = $(this).find(".produto").val();
            var dadoProduto = { idProduto: produtoId }

            $.post("http://localhost:62680/Venda/AdicionaProdutoVenda", dadoProduto, function () {
                console.log("SUCESSO!");
            }).fail(function () {
                console.log("FALHA!");
            });
        });
    }).fail(function () {
            console.log("Falha!");
        });       

});

$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();

    var id = $(this).parent().parent().find(".id").text();

    var dados = { ID: id };
    
    linha.remove();

    $.post("http://localhost:62680/Venda/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});

function novaLinha() {
    var $tbody = $("tbody");
    
    var linha = $("<tr>");
    var colunaProduto = $("<td>").addClass("produto");
    var colunaPrecoUni = $("<td>").addClass("precoUnitario");
    var colunaQuantidade = $("<td>").addClass("quantidade");

    colunaProduto.text($('#select-produtos option:selected').text());
    colunaProduto.val($("#select-produtos").val());

    colunaQuantidade.text($("#quantidade").val());
    colunaPrecoUni.text($("#precoUnitario").val());

    var colunaRemover = $("<td>");
    var link = $("<a>").addClass("botao-remover").attr("href", "#").text("D");
    colunaRemover.append(link);

    linha.append(colunaProduto);
    linha.append(colunaPrecoUni);
    linha.append(colunaQuantidade);
    linha.append(colunaRemover);

    $tbody.append(linha);
    
    return linha;
}