$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();

    var id = $(this).parent().parent().find(".id").text();
    var nome = $(this).parent().parent().find(".nome").text();
    var bairro = $(this).parent().parent().find(".bairro").text();
    var rua = $(this).parent().parent().find(".rua").text();
    var numeroLogradouro = $(this).parent().parent().find(".numeroLogradouro").text();
    var complemento = $(this).parent().parent().find(".complemento").text();
    var cnpj = $(this).parent().parent().find(".cnpj").text();
    var preco = $(this).parent().parent().find(".preco").text();


    var dados = { ID: id, Nome: nome, Rua: rua, Bairro: bairro, NumeroLogradouro: numeroLogradouro, Complemento: complemento, CNPJ: cnpj, Preco: preco };

    linha.remove();

    $.post("http://localhost:62680/PessoaJuridica/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});