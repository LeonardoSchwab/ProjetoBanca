var precoTotal = 0;
var itemsTotal = 0;
$("#enviar-carrinho").click(function (event) {
    event.preventDefault();    

    $preco = $("#precoUnitario").val();
    $quantidade = $("#quantidade").val();

    if ($preco && $quantidade) {

        precoTotal += ($("#precoUnitario").val() * $("#quantidade").val());
        $("#precoTotal").val(precoTotal);

        itemsTotal += parseInt($("#quantidade").val());
        $("#quantidadeTotal").val(itemsTotal);

        var linha = novaLinha();
        linha.find(".botao-removerLinha").click(function () {
            
            precoTotal -= parseInt($(this).parent().parent().find(".precoUnitario").text() * $(this).parent().parent().find(".quantidade").text());
            $("#precoTotal").val(precoTotal);

            itemsTotal -= parseInt($(this).parent().parent().find(".quantidade").text());
            $("#quantidadeTotal").val(itemsTotal);

            linha.remove();
        });

        $("#precoUnitario").val("");
        $("#quantidade").val("");
        $(".erro").hide();
    }
    else {
        $(".erro").show();
    }
});

$("#finalizar-compra").click(function (event) {
    //event.preventDefault();

    //var linhaS = $("tbody").find("tr");

    var precoTotal = $("#precoTotal").val();
    var quantidadeTotal = $("#quantidadeTotal").val();
    var idPRODUTO = $("tbody").find("tr").find(".produto").val();
    var quantidades = $("tbody").find("tr").find(".quantidade").text();    
    
    var dadosVenda = { PrecoTotal: precoTotal, Quantidade: quantidadeTotal, produtosID: idPRODUTO, quantidades: quantidades };
    /////////////////////////////////////////////////////////////////////////////////
    $.post("http://localhost:62680/Produto/VerificaEstoque", dadosVenda, function () {
        alert("Venda cadastrada com sucesso!");
        var linhas = $("tbody").find("tr");

        linhas.each(function () {
            var produtoId = $(this).find(".produto").val();
            var dadoProduto = { idProduto: produtoId };

            $.post("http://localhost:62680/Venda/AdicionaProdutoVenda", dadoProduto, function () {
                var quantidade = $(this).find(".quantidade").val();
                var dados = { id: produtoId, quantidade: quantidade };

                $.post("http://localhost:62680/Produto/BaixaEstoque", dados, function () {
                });
            });

            

        });
    }).fail(function () {
        alert("Falha ao cadastrar a venda!");
    });   

});

$(".botao-remover").click(function () {

    var confirmacao = confirm("Tem certeza que deseja excluir esse registro?");
    if (confirmacao) {

        var linha = $(this).parent().parent();

        var id = $(this).parent().parent().find(".id").text();

        var dados = { ID: id };

        $.post("http://localhost:62680/Venda/Remove", dados, function () {
            linha.remove();
            alert("Item removido com sucesso!");
        }).fail(function () {
            alert("Falha ao remover item!");
        });
    }
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
    var link = $("<a>").addClass("botao-removerLinha").attr("href", "#").text("D");
    colunaRemover.append(link);

    linha.append(colunaProduto);
    linha.append(colunaPrecoUni);
    linha.append(colunaQuantidade);
    linha.append(colunaRemover);

    $tbody.append(linha);
    
    return linha;
}