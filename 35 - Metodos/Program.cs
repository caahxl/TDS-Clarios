// Métodos

/* SINTAXE para declarar um metodo
  tipoDoretorno nomeDometodo() 
{instruçãço}
*/

// Declarando um metodo
//void executa um conjunto de ações, como alterar um campo, atualizar um valor ou imprimir algo na tela. 
void Exemplo01()
{
    Console.WriteLine("Meu Primeirto Método!");
}
// Executando
Exemplo01();

// Medotos com retorno

int Exemplo02()
{
    int a = 2;
    int b = 3;
    int c = a + b;

    return (c);
}
Exemplo02();

//Tipo do dado do retorno do método precisa ser
//igual ao inicio da declaração do m´todo e
//após a instrução "return"
string Exemplo03()
{
    return "Retorno";

}
Exemplo03();

// Métodos podem receber parâmetros
string Exemplo04(string nome)
{
    string frase = $"Seja Be-vindo(a) {nome}";
    return frase;
}
Console.WriteLine(Exemplo04("Thiago"));
Console.WriteLine(Exemplo04("Chamito"));
Console.WriteLine(Exemplo04("Benefício"));

// Exemplo sem parâmetro
string Exemplo04Anterior()
{
    string nome = "Thiago";
    string frase = $"Seja Be-vindo(a) {nome}";
    return frase;
}
Console.WriteLine(Exemplo04Anterior());

// 01 - Exemplo com 2 parâmetros (string, int)
string Exemplo05(string nome, int idade)
{
    string frase = $"{nome} tem {idade} anos.";
    return frase;
}
Exemplo05("Milly", 20);

// 02 - Exemplo com 2 parâmetros (int, int)
string Exemplo06(int x, int y)
{
    string soma = $"Soma x + y = {x + y}";
    return soma;
}
Exemplo06(7, 8);

//Reutilização de métodos
int Exemplo07(int n)
{
    return n * 2;
}
int calc1 = Exemplo07(2);
int calc2 = Exemplo07(calc1);

Console.WriteLine(calc2);

string Exercicio01(string nome, double nota1, double nota2)
{
    string media = $"A média da aluna {nome} é {(nota1 + nota2) / 2}";
    return media;
}
Console.WriteLine(Exercicio01("Camilly", 5.8, 7.3));

// Pesoas com idade entre 18 e 70 anos, inclusive, são obrigadas a votar.
// Crie um programa que solicite ao úsuario que informe sua idade e,
// Em seguida, verifique a idade informada e axiba uma das mensagens abaixo:

// Se a idade for maior ou igual a 18 e menor ou igual a 70, exiba
// >>> O voto é orbigatório
// Senão, exiba:
// O voto não é obrigatório.

string Pessoas(int idade)
{

    if (idade >= 18 && idade < 70)
        return "Voto obrigatorio";
    else
        return "o voto não é obrigatorio";
}

Console.WriteLine("Digite a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pessoas(idade));

Console.ReadKey();
