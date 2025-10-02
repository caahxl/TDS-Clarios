// Operadores Lógicos
// Operador & - Operador And
// Retorna True se todas as condições forem verdadeiras

int idade = 18;
bool temCNH = false;

if (idade >= 18 & temCNH)
{
    Console.WriteLine("Pode dirigir");
}
else
{
    Console.WriteLine("Não pode dirigir");
}

Console.WriteLine("\n------------------------------------\n");

// Operador | - OU
// Retorna True se ao menos uma condição for verdadeira

int Loja1 = 0;
int Loja2 = 1;

if (Loja1 > 0 | Loja2 > 0)
{
    Console.WriteLine("O produto está em stock");
}
else
{
    Console.WriteLine("O produto NÃO está em stock");
}

Console.WriteLine(Loja1 > 0 | Loja2 > 0 ? "O produto está em stock" : "O produto NÃO está em stock");

Console.WriteLine("\n------------------------------------\n");

// Operador ! - Operador not
// Inverte um valor booleano

// Inativar aluno SEM NOT
bool alunoativo = true;
alunoativo = false;

Console.WriteLine($"Status {alunoativo}");

// Inativar aluno COM NOT
alunoativo = false;
alunoativo = !alunoativo;

Console.WriteLine($"Status {alunoativo}");
Console.WriteLine($"Status {!alunoativo}");
Console.WriteLine($"Status {!!alunoativo}");

Console.WriteLine("\n------------------------------------\n");

// intervalo devalores
int nota = 2;

Console.WriteLine(nota >= 9 & nota <= 10 ? "Aprovado com exelência" :
    (nota >= 7 & nota < 9) ? "Aprovado" :
    (nota >= 6 & nota < 7) ? "De rapão" :
    (nota >= 3 & nota < 6) ? "Recuperação" : "Reprovado");