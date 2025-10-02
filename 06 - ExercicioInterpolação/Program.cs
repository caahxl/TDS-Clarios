void Exercicio01()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'usuario' do tipo string com o nome de um usuário.
    // 2. Use interpolação para exibir: "Bem-vindo ao sistema, [usuario]!"

    string usuario = "Milly";
    Console.WriteLine($"Bem-vindo ao sistema, {usuario}!");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();


void Exercicio02()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'nome' do tipo string.
    // 2. Declare uma variável chamada 'idade' do tipo int.
    // 3. Use interpolação para exibir a mensagem: "Olá, meu nome é [nome] e tenho [idade] anos."

    string nome = "Camilly";
    int idade = 18;

    Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();


void Exercicio03()
{
    // Crie um algoritmo que:
    // 1. Declare uma variável chamada 'produto' do tipo string.
    // 2. Declare uma variável chamada 'preco' do tipo double.
    // 3. Use interpolação para exibir: "O produto [produto] custa R$ [preco]."

    string produto = "Morango do Amor";
    int preco = 15;

    Console.WriteLine($"O produto {produto:c2} custa {preco: c2}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();


void Exercicio04()
{
    // Crie um algoritmo que:
    // 1. Declare três variáveis chamadas 'nota1', 'nota2' do tipo double.
    // 2. Calcule a média das notas e armazene em uma variável 'media'.
    // 3. Use interpolação para exibir: "As notas foram: [nota1], [nota2]. A média final é [media]."

    double nota1 = 8.5;
    double nota2 = 9.0;
    double media = (nota1 + nota2) / 2;

    Console.WriteLine($"As notas foram {nota1}, {nota2}. A média é {media}");

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio04();


void Exercicio05()
{
    // Crie um algoritmo que:
    // 1. Declare as variáveis: 'nomeFuncionario' (string), 'cargo' (string), 'salario' (double).
    // 2. Use interpolação para exibir: "[nomeFuncionario] ocupa o cargo de [cargo] e recebe R$ [salario]."

    string nomeFuncionario = "Milly";
    string cargo = "Aprendiz Dev";
    double salario = 2.000;

    Console.WriteLine($"{nomeFuncionario} ocupa o cargo {cargo} e recebe {salario:cs}");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();


void Exercicio06()
{
    // Crie um algoritmo que:
    // 1. Declare variáveis: 'marca' (string), 'modelo' (string) e 'ano' (int).
    // 2. Use interpolação para exibir: "Veículo: [marca] [modelo] - Ano [ano]."

    string marca = "Fiat";
    string modelo = "Uno";
    int ano = 2013;

    Console.WriteLine($"Veículo: {marca} {modelo} - {ano}.");
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();


void Exercicio07()
{
    // Crie um algoritmo que:
    // 1. Declare as variáveis: 'produto' (string), 'quantidade' (int), 'precoUnitario' (double).
    // 2. Calcule o total da compra e armazene em 'valorTotal'.
    // 3. Use interpolação para exibir: "[quantidade] x [produto] a R$ [precoUnitario] cada. Total: R$ [valorTotal]."

    string produto = "Morango do Amor";
    int quantidade = 2;
    double precoUnitario = 15.35;
    double valortotal = quantidade * precoUnitario;

    Console.WriteLine($"{quantidade} x {produto} a {precoUnitario:c2} cada. Total: {valortotal}.");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();


void Exercicio08()
{
    // Arredonde o número abaixo para duas casas decimais e, em seguida, utilize interpolação de
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.

    double interpolacao = 129.99451654;
    Console.WriteLine(Math.Round(interpolacao, 2));

    Console.WriteLine($"O valor final da sua compra é de: {interpolacao}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();


void Exercicio09()
{
    // Arredonde o número abaixo para três casas decimais e, em seguida, utilize interpolação de 
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.

    double interpolacao = 0.8754321;
    Console.WriteLine(Math.Round(interpolacao, 3));

    Console.WriteLine($"A diferença entre os corredores foi de apenas: {interpolacao}");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();


void Exercicio10()
{
    // Arredonde o número abaixo para uma casa decimal e, em seguida, utilize interpolação de 
    // strings para substituir o texto "interpolacao" pelo valor da variável "interpolacao" no texto exibido.

    double interpolacao = 0.629874;
    Console.WriteLine(Math.Round(interpolacao, 1));

    Console.WriteLine($"A piscina tem apenas {interpolacao} metros de profundidade.");
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();
