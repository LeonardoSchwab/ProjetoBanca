$(document).ready(function () {
    $("#salvar-produto").click(function (event) {
        event.preventDefault();

        //var nome = $("#nome").val();
        //var dados = { Nome: nome };

        //$("#form-categoria").serialize()

        $.post("http://localhost:62680/Produto/Adiciona", $("#cad-produto").serialize(), function (data) {
            alert("Cadastro efetuado com sucesso!");
        }).fail(function () {
            alert("Falha no cadastro!");
        });

        $("form .form-group input").val("");
    });
});

$(".botao-remover").click(function () {

    var confirmacao = confirm("Tem certeza que deseja excluir esse registro?");
    if (confirmacao) {

        var linha = $(this).parent().parent();

        var id = $(this).parent().parent().find(".id").text();

        var dados = { ID: id };

        $.post("http://localhost:62680/Produto/Remove", dados, function () {
            linha.remove();
            alert("Item removido com sucesso!");
        }).fail(function () {
            alert("Falha ao remover item!");
        });
    }
});