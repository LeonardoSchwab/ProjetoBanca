var precoTotal = 0;
var itemsTotal = 0;
$("#enviar-carrinho").click(function (event) {
    event.preventDefault();    

    $preco = $("#precoUnitario option:selected").text();
    $quantidade = $("#quantidade").val();

    if ($preco && $quantidade) {

        precoTotal += (parseInt($("#precoUnitario option:selected").text()) * $("#quantidade").val());
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

    var idPRODUTO = [];
    var quantidades = [];
    var lin = $("tbody").find("tr");
    lin.each(function () {
        /*ARRUMAR*/  idPRODUTO.push( $(this).find(".produto").val() );

        /*ARRUMAR*/  quantidades.push( parseInt($(this).find(".quantidade").text()) );
    });
    
    var dadosVenda = { PrecoTotal: precoTotal, Quantidade: quantidadeTotal, produtosID: idPRODUTO, quantidades: quantidades };
    /////////////////////////////////////////////////////////////////////////////////
    $.post("http://localhost:62680/Produto/VerificaEstoque", dadosVenda, function (data) {
        alert("Venda cadastrada com sucesso!");
        var linhas = $("tbody").find("tr");
        console.log(data);
        linhas.each(function () {
            var produtoId = $(this).find(".produto").val();
            
            var dadoProduto = { idProduto: produtoId };
            $.post("http://localhost:62680/Venda/AdicionaProdutoVenda", dadoProduto, function () {
            });

            var quantidade = $(this).find(".quantidade").text();
            var dados = { id: produtoId, quantidade: quantidade };

            $.post("http://localhost:62680/Produto/BaixaEstoque", dados, function () {
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
    colunaPrecoUni.text($("#precoUnitario option:selected").text());

    var colunaRemover = $("<td>");
    var link = $("<a>").addClass("botao-removerLinha fa fa-close").attr("href", "#");
    colunaRemover.append(link);

    linha.append(colunaProduto);
    linha.append(colunaPrecoUni);
    linha.append(colunaQuantidade);
    linha.append(colunaRemover);

    $tbody.append(linha);
    
    return linha;
}

$("#select-produtos").change(mudarPreco);

function mudarPreco() {
    var $selectProdutos = $("#select-produtos")[0];
    var sProdutosIndex = $selectProdutos.selectedIndex;

    var $precoUnitario = $("#precoUnitario")[0];

    for (var i = 0; i < $precoUnitario.length; i++) {
        if ($selectProdutos.options[sProdutosIndex].value == $precoUnitario.options[i].value) {
            $precoUnitario.selectedIndex = i;
        }
    }
}