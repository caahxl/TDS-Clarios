//Estrutura Condicional If/Else

Console.Write("Hoje vai chover: ");
string resposta = Console.ReadLine();

if (resposta == "sim!")
{
    Console.WriteLine("Deu ruim =(");
}

else 
{
    Console.WriteLine("Deu boom!");
}

Console.WriteLine("\n-----------------------------\n");
}

Console.WriteLine("Tem Coxinha");
string resposta2 = Console.ReadLine();

bool temCoxinha = resposta2 == "sim";

if (temCoxinha)
{
    Console.WriteLine("Deu bom para o Jean");
}
else
{
    Console.WriteLine("Deu ruim para o Jean");
}

Console.WriteLine("\n-----------------------------\n");
//else if - Validar duas ou mais condições

Console.Write("Digite o dia da entrega do trabalho");
int dia = int.Parse(Console.ReadLine());

if (dia > 5);
{
    Console.WriteLine("O trabalho foi entregue com atraso");
}
else if (dia == 5)
{
    Console.WriteLine("O trabalho foi entregue dentro do prazo");
}
else if (dia < 5)
{
    Console.WriteLine("O trabalho foi entregue antecipado");
}