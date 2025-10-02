void Exercicio01()
{
    // Crie um programa que solicite ao usuário que informe sua idade e, em seguida, crie as condições abaixo.

    // - Se a idade for maior ou igual a 18 anos, exiba:
    // >>> Você é maior de idade.
    // - Senão, exiba:
    // >>> Você é menor de idade.

    Console.Write("Informe sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    string mensagem = idade >= 18 ? "Você é maior de idade." : "Você é menor de idade.";

    Console.WriteLine(mensagem);
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio01();



void Exercicio02()
{
    // Crie um programa que solicite ao usuário que digite um número e, em seguida, crie as condições abaixo.

    // - Se o número for maior ou igual a zero, exiba:
    // >>> O número é positivo.
    // - Senão, exiba:
    // >>> O número é negativo.

    Console.Write("Informe um número: ");
    int numero = int.Parse(Console.ReadLine());

    string mensagem = numero >= 0 ? "O número é positivo." : "O número é negativo.";

    Console.WriteLine(mensagem);
}

// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();



void Exercicio03()
{
    // Crie um programa que verifique se a senha informada pelo usuário está correta. A senha válida é: 1234.  
    // Após a entrada do usuário, exiba uma das seguintes mensagens:

    // - Se a senha estiver correta, exiba:
    // >>> ACESSO PERMITIDO
    // - Se a senha estiver incorreta, exiba:
    // >>> ACESSO NEGADO

    Console.WriteLine("Informe uma senha: ");
    int senha = Convert.ToInt32(Console.ReadLine());

    string senhaCorreta = senha == 1234 ? "ACESSO PERMITIDO" : "ACESSO NEGADO";

    Console.WriteLine(senhaCorreta);


}

// Descomente o bloco de código abaixo para executar o exercício
//Exercicio03();



void Exercicio04()
{
    // Crie um programa que solicite ao usuário que digite uma senha e, em seguida, solicite que confirme a senha digitada.  
    // Compare as duas entradas e exiba a mensagem correspondente:

    // - Se as senhas forem iguais, exiba:
    // >>> SENHA CORRETA
    // - Se as senhas forem diferentes, exiba:
    // >>> SENHA INCORRETA

    Console.WriteLine("Informe uma senha: ");
    int senha = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Confirme a sua senha: ");
    int senhaConfirmada = Convert.ToInt32(Console.ReadLine());

    string senhaCorreta = senha == senhaConfirmada ? "SENHA CORRETA" : "SENHA INCORRETA";

    Console.WriteLine(senhaCorreta);

}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário que informe a nota final do aluno e, em seguida, crie as condições abaixo.

    // - Se a nota final for maior ou igual a 5, exiba:
    // >>> Você está aprovado.
    // - Se a nota final for menor que 5, exiba:
    // >>> Você está reprovado.

    Console.WriteLine("Informe a nota final do aluno:");
    double nota = Convert.ToDouble(Console.ReadLine());

    string notaFinal = nota >= 5 ? "Você está aprovado!" : "Você está reprovado!";

    Console.WriteLine(notaFinal);
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário que digite dois números inteiros e, em seguida, crie as condições abaixo.

    // - Se os números forem iguais, exiba:
    // >>> Os números digitados são iguais.
    // - Caso contrário, exiba:
    // >>> Os números digitados são diferentes.

    Console.WriteLine("Digite o 1° número inteiro: ");
    int numero1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o 2° número inteiro: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    string osNumeros = numero1 == numero2 ? "Os números digitados são iguais." : "Os números digitados são diferentes.";

    Console.WriteLine(osNumeros);
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário que digite um ano e, em seguida, crie as condições abaixo.

    // - Se o ano informado for maior ou igual a 2001, exiba:
    // >>> Século 21.
    // - Caso contrário, exiba:
    // >>> Século 20 ou anterior.

    Console.WriteLine("Digite um ano: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    string informacaoAno = ano >= 2001 ? " Século 21." : "Século 20 ou anterior.";

    Console.WriteLine(informacaoAno);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário que digite o valor total da sua compra e, em seguida, crie as condições abaixo.

    // - Se o valor total da compra for maior ou igual a 150, exiba:
    // >>> Frete grátis!
    // - Caso contrário, exiba:
    // >>> Frete: R$ 20,00.

    Console.WriteLine("Digite o valor total da compra");
    double compra = Convert.ToDouble(Console.ReadLine());

    string valorFinal = compra >= 150 ? "Frete grátis!" : "Frete: R$ 20,00.";

    Console.WriteLine(compra);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário que digite um número inteiro e, em seguida, crie as condições abaixo.

    // - Se o número for igual, exiba:
    // >>> É zero.
    // - Caso contrário, exiba:
    // >>> Não é zero.

    Console.WriteLine("Digite um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    string oNumeros = numero == 0 ? "É zero." : "Não é zero.";

    Console.WriteLine(oNumeros);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio09();



void Exercicio10()
{
    // Crie um programa que solicite ao usuário que digite a velocidade de um veículo e, em seguida, crie as condições abaixo.

    // - Se a velocidade for maior ou igual a 61, exiba:
    // >>> Acima da velocidade permitida.
    // - Caso contrário, exiba:
    // >>> Dentro do limite.

    Console.WriteLine("Digite a velocidade de um veículo: ");
    double velocidade = Convert.ToDouble(Console.ReadLine());

    string km = velocidade > 61 ? "Acima da velocidade permitida." : "Dentro do limite.";

    Console.WriteLine(km);

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();