$(".botao-remover").click(function () {
    var linha = $(this).parent().parent();

    var id = $(this).parent().parent().find(".id").text();
    var nome = $(this).parent().parent().find(".nome").text();
    var bairro = $(this).parent().parent().find(".bairro").text();
    var rua = $(this).parent().parent().find(".rua").text();
    var numeroLogradouro = $(this).parent().parent().find(".numeroLogradouro").text();
    var complemento = $(this).parent().parent().find(".complemento").text();
    var cpf = $(this).parent().parent().find(".cpf").text();
    var sexo = $(this).parent().parent().find(".sexo").text();
    var dataNascimento = $(this).parent().parent().find(".dataNascimento").text();
    var tipo = $(this).parent().parent().find(".tipo").text();
    var pontos = $(this).parent().parent().find(".pontos").text();

    var dados = {
        ID: id, Nome: nome, Rua: rua, Bairro: bairro, NumeroLogradouro: numeroLogradouro, Complemento: complemento, CPF: cpf, Sexo: sexo,
        DataNascimento: dataNascimento, TipoID: tipo, Pontos: pontos
    };

    linha.remove();

    $.post("http://localhost:62680/PessoaFisica/Remove", dados, function () {
        console.log("Sucesso!");
    }).fail(function () {
        console.log("Falha!");
    });
});