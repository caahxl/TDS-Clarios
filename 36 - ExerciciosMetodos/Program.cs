// Crie um método que receba três números como parâmetros, e que retorne a soma desses três números.
using System.Drawing;

int Exercicio01(int n1, int n2, int n3)
{
    int soma = n1 + n2 + n3;
    return soma;
}
//Console.WriteLine(Exercicio01(5, 6, 15));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba um número como parâmetro, e com uma condicional if/else crie a condição abaixo:

// - Se o número informado for maior que 0, então retorne 'Positivo'
// - Se o número informado for menor que 0, então retorne 'Negativo'
// - Se o número informado for igual a zero, então retorne 'Neutro'
string Exercicio02( int number)
{
    if (number > 0)
        return "Número Positivo!";

    else if (number < 0)
        return "Número Negativo!";

    else
        return "Número neutro!";
}
//Console.WriteLine("Digite um número inteiro:");
//int respostaUsuario = int.Parse(Console.ReadLine());
//Console.WriteLine(Exercicio02(respostaUsuario));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba um número como parâmetro, e que retorne o dobro do número.
int Exercicio03(int number)
{
    return number * 2;
}
//Console.WriteLine("Digite um número:");
//int dobro = int.Parse(Console.ReadLine());
//Console.WriteLine(Exercicio03(dobro));

/////////////////////////////////////////////////////////////////////////////////////////////////

// No Brasil, 1 arroba equivale a 15 kg.
// Com base nessa informação, crie um método que receba um valor em quilogramas (kg) e retorne o valor correspondente em arrobas.

// Entrada: 150 kgs
// Saída: 10 arrobas
double Exercicio04(double kg)
{
    double valor = kg / 15;
    return valor;
}
//Console.WriteLine("Digite um valor em kg:");
//double rUsuario = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(Exercicio04(rUsuario));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba um valor de salário como parâmetro e retorne o valor do salário acrescido de um reajuste de 10%.

// Dica:
// 10%  * 1000 = 100 (Não é válido)
// 0.10 * 1000 = 100 (Equivamente, é válido)

string Exercicio05(double salario)
{
    double conta = salario * 1.10;
    return $"O seu salário teve um acrescimo! Seu salário atual é: {conta}";
}
//Console.WriteLine("Insira o valor do seu salário:");
//double novoSalario = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(Exercicio05(novoSalario));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que:
// 1. Receba quatro notas como parâmetros.
// 2. Calcule a soma das quatro notas.
// 3. Calcule a média aritmética das notas, dividindo a soma por 4.
// 4. Retorne a média final.
string Exercicio06(double nota1, double nota2, double nota3, double nota4)
{
   double soma = nota1 + nota2 + nota3 + nota4;
   double media = soma / 4;

   return $"A média das notas é: {media}";
}
//Console.WriteLine(Exercicio06(5, 4, 10, 7));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba dois parâmetros: altura (em metros) e peso (em quilogramas).
// O método deve calcular e retornar o valor do IMC(Índice de Massa Corporal), utilizando a seguinte fórmula:

// Formúla: IMC = Peso / (Altura * Altura)
string Exercicio07(double altura, double kg)
{
   double imc = kg / (altura * altura);
   return $"Seu índice de massa corporal é: {Math.Round(imc)}";

}
//Console.WriteLine("Digite a sua Altura:");
//double alturaUsuario = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite o seu peso:");
//double kgUsuario = Convert.ToDouble(Console.ReadLine());

//string resultado = Exercicio07(alturaUsuario, kgUsuario);
//Console.WriteLine(resultado);

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba uma temperatura em Celsius e retorne o valor convertido para Fahrenheit.

// Fórmula: Fahrenheit = (Celsius * 9/5) + 32
string Exercicio08(double celsius)
{
    double conta = celsius * 9 / 5 + 32;
    return $"O valor covertido é {conta}"; ;
}
Console.WriteLine(Exercicio08(23.6));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba largura, altura e profundidade (em cm) e retorne o volume da caixa em litros.

// Fórmula: volume = (largura × altura × profundidade) / 1000
string Exercicio09(double largura, double altura, double profuncm)
{
    double volume = largura * altura * profuncm / 1000;

    return $"O volume em litros é: {volume}";

}
//Console.WriteLine(Exercicio09(10, 1.51, 1));

/////////////////////////////////////////////////////////////////////////////////////////////////

// Crie um método que receba o valor total de uma compra e o número de parcelas,
// e retorne o valor de cada parcela com duas casas decimais.
string Exercicio10(double total, int parcelas)
{
    double qtdparcelas = total / parcelas;
    return $"Cada parcela será de: R$ {qtdparcelas:F2}";
}
Console.Write("Digite o valor total da compra: R$ ");
double valorTotal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o número de parcelas: ");
int parcelas = Convert.ToInt32(Console.ReadLine());

string resultado = Exercicio10(valorTotal, parcelas);
Console.WriteLine(resultado);

//Console.ReadKey();