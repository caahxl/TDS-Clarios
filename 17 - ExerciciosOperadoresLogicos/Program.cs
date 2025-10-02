void Exercicio01()
{
    // Pessoas com idade entre 18 e 70 anos, inclusive, são obrigadas a votar.  
    // Crie um programa que solicite ao usuário que informe sua idade e, em seguida, verifique a idade informada e exiba uma das mensagens abaixo:

    // - Se a idade for maior ou igual a 18 e menor ou igual a 70, exiba:
    // >>> O voto é obrigatório.
    // - Senão, exiba:
    // >>> O voto não é obrigatório.

    Console.WriteLine("Informe a sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18 & idade <= 70)
    {
        Console.WriteLine("O voto é obrigatório.");
    }
    else
    {
        Console.WriteLine("O voto não é obrigatório.");
    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio01();



void Exercicio02()
{
    // Para determinar o tipo de ingresso adequado, o usuário deve informar seu perfil.
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1.Estudante
    // 2.Idoso
    // 3.PCD
    // 4.Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Ingresso com meia-entrada.
    // - Se o usuário digitar 4, exiba:
    // >>> Ingresso com valor integral.
    // - Senão, exiba:
    // >>> Opção inválida.

    Console.WriteLine("Escolha uma das opções abaixo: \n1.Estudante\n2.Idoso\n3.PCD\n4.Público geral\n ");
    int escolha = Convert.ToInt32(Console.ReadLine());

    if (escolha == 1 | escolha == 2 | escolha == 3)
    {
        Console.WriteLine("Ingresso com meia - entrada.");
    }

    else if (escolha == 4)
    {
        Console.WriteLine("Ingresso com valor integral.");
    }

    else
    {
        Console.WriteLine("Opção inválida.");
    }

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio02();



void Exercicio03()
{
    // Crie um programa que solicite ao usuário que digite H se for do homem ou M se for mulher e, em seguida, peça que informe a sua idade.  
    // Com base nas informações fornecidas, verifique as seguintes condições:

    // - Se o usuário digitar H e tiver idade maior ou igual a 65 anos, exiba:
    // >>> Você pode se aposentar.
    // - Se o usuário digitar M e tiver idade maior ou igual a 62 anos, exiba:
    // >>> Você pode se aposentar.
    // - Senão, exiba:
    // >>> Você ainda precisa trabalhar.

    Console.WriteLine("Digite H se for do homem ou M se for mulher:");
    string genero = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Informe a sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    if (genero == "H" & idade >= 65 & genero == "h" & idade >= 65)
    {
        Console.WriteLine("Você pode se aposentar.");
    }

    else if (genero == "F" & idade >= 62 | genero == "f" & idade >= 62)
    {
        Console.WriteLine("Você pode se aposentar.");
    }

    else
    {
        Console.WriteLine("Você ainda precisa trabalhar.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio03();



void Exercicio04()
{
    // Para ter direito à fila prioritária, o usuário deve se enquadrar em pelo menos uma das seguintes condições: idoso, gestante ou cadeirante.  
    // Crie um programa que solicite ao usuário que escolha uma das opções abaixo, digitando o número correspondente:

    // 1. Idoso
    // 2. Gestante
    // 3. Cadeirante
    // 4. Público geral

    // Em seguida, verifique a condição escolhida:
    // - Se o usuário digitar 1, 2 ou 3, exiba:
    // >>> Fila prioritária.
    // - Se o usuário digitar 4, exiba:
    // >>> Fila comum.
    // - Senão, exiba:
    // >>> Opção inválida.

    Console.WriteLine("Escolha uma das opções abaixo: \n1.Idoso\n2.Gestante\n3.Cadeirante\n4.Público geral\n ");
    int escolha = Convert.ToInt32(Console.ReadLine());

    if (escolha == 1 | escolha == 2 | escolha == 3)
    {
        Console.WriteLine("Fila prioritária.");
    }

    else if (escolha == 4)
    {
        Console.WriteLine("Fila comum.");
    }

    else
    {
        Console.WriteLine("Opção inválida.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio04();



void Exercicio05()
{
    // Crie um programa que solicite ao usuário sua idade e se ele possui CNH (Carteira Nacional de Habilitação)
    // com base nas informações fornecidas, aplique a seguinte condição:

    // - Se o usuário tiver 18 anos ou mais e responder que possui CNH, exiba:
    // >>> Você está apto a dirigir.
    // - Senão, exiba:
    // >>> Você não está apto a dirigir.

    Console.WriteLine("Informe a sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Tem CNH: \n1- Sim\n2 - Não");
    int CNH = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18 & CNH == 1)
    {
        Console.WriteLine("Você está apto a dirigir.");
    }
    else
    {
        Console.WriteLine("Você não está apto a dirigir.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio05();



void Exercicio06()
{
    // Crie um programa que solicite ao usuário que digite um login e uma senha. Após a entrada dos dados, verifique as informações e exiba uma das mensagens abaixo:

    // - Se o login for igual a admin e a senha for igual a 123456, exiba:
    // >>> SEJA BEM-VINDO, ADMIN!
    // - Senão, exiba:
    // >>> LOGIN OU SENHA INCORRETOS.

    Console.WriteLine("Digite um Login:");
    string login = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Digite uma senha:");
    int senha = Convert.ToInt32(Console.ReadLine());

    string resultado = login == "Admin" & senha == 12345 ? "SEJA BEM-VINDO, ADMIN!" : "LOGIN OU SENHA INCORRETOS.";

    Console.WriteLine(resultado);
}
// Descomente o bloco de código abaixo para executar o exercício
//Exercicio06();



void Exercicio07()
{
    // Crie um programa que solicite ao usuário a nota final e o número de faltas de um aluno. 
    // Com base nas informações fornecidas, verifique a situação do aluno conforme as regras abaixo:

    // - Se a nota for maior ou igual a 5 e o número de faltas for menor ou igual a 5, exiba:
    // >>> Aluno aprovado.
    // - Senão, exiba:
    // >>> Aluno reprovado.

    Console.WriteLine("Digite a nota final do aluno:");
    int notaFinal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o número de faltas do aluno:");
    int faltas = Convert.ToInt32(Console.ReadLine());

    string resultado = notaFinal >= 5 & faltas <= 5 ? "Aluno aprovado." : " Aluno reprovado.";

    Console.WriteLine(resultado);
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio07();



void Exercicio08()
{
    // Crie um programa que solicite ao usuário sua idade e se ele possui carteira de estudante, respondendo com **SIM** ou **NÃO**.
    // Com base nas informações fornecidas, aplique as seguintes regras:

    // - Se a idade for maior ou igual a 18 anos e o usuário responder SIM, exiba: 
    // >>> Ingresso com meia-entrada.
    // - Se a idade for maior ou igual a 18 anos e a resposta for NÃO, exiba:
    // >>> Ingresso com valor integral
    // - Senão, exiba:
    // >>> Venda não permitida.

    Console.WriteLine("Digite a sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Possuí carteira de estudante: \n1- Sim\n2 - Não\n");
    int carteira = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18 & carteira == 1)
    {
        Console.WriteLine("Ingresso com meia-entrada.");
    }
    else if (idade >= 18 & carteira == 2)
    {
        Console.WriteLine("Ingresso com valor integral");
    }

    else
    {
        Console.WriteLine("Venda não permitida.");
    }
}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio08();



void Exercicio09()
{
    // Crie um programa que solicite ao usuário o preço de um produto e,
    // com base no valor informado, classifique o produto em uma das categorias abaixo:

    // Se o preço for menor que R$ 50,00, classifique como: "Produto barato"
    // Se o preço estiver entre R$ 50,00 e R$ 150,00, classifique como: "Produto normal"
    // Se o preço estiver entre R$ 150,01 e R$ 300,00, classifique como: "Produto caro"
    // Se o preço for acima de R$ 300,00, classifique como: "Produto de luxo"

    Console.WriteLine("Preço do produto: ");
    double preco = double.Parse(Console.ReadLine());

    Console.WriteLine(preco < 50 ? "Produto barato" :
        (preco >= 50 & preco < 150) ? "Produto normal" :
        (preco >= 150.01 & preco < 300) ? "Produto caro" : "Produto de luxo");
}
// Descomente o bloco de código abaixo para executar o exercício
Exercicio09();



void Exercicio10()
{
    // Crie um programa que solicite ao usuário a distância (em km) que ele deseja viajar e,
    // com base nessa distância, classifique o valor da passagem da seguinte maneira:

    // Se a distância for menor ou igual a 100 km, exiba: "Passagem econômica: R$ 50,00"
    // Se estiver entre 101 km e 300 km, exiba: "Passagem padrão: R$ 100,00"
    // Se for acima de 300 km, exiba: "Passagem executiva: R$ 200,00"

    Console.WriteLine("Digite a distância em km que você deseja viajar:");
    double km = double.Parse(Console.ReadLine());

    Console.WriteLine(km <= 100 ? "Passagem econômica: R$ 50,00" :
        (km >= 101 & km < 300) ? "Passagem padrão: R$ 100,00" :
        (km > 300) ? "Passagem executiva: R$ 200,00" : "valor inválido");

}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio10();



void Exercicio11()
{
    // Crie um programa que solicite ao usuário a temperatura corporal (em °C) e classifique a situação de acordo com os valores abaixo:

    // Se a temperatura for menor que 35°C, exiba: "Hipotermia"
    // Se estiver entre 35°C e 37°C, exiba: "Temperatura normal"
    // Se estiver entre 37,1°C e 38°C, exiba: "Estado febril leve"
    // Se for acima de 38°C, exiba: "Febre alta"

    Console.WriteLine("Digite a temperatura corporal (em °C)");
    double temperatura = double.Parse(Console.ReadLine());

    Console.WriteLine(temperatura < 35 ? "Hipotermia" :
        (temperatura >= 35 & temperatura < 37) ? "Estado febril leve" :
        (temperatura >= 37.1 & temperatura <= 38) ? "Febre alta" : "Temperatura inválida");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio11();



void Exercicio12()
{
    // Crie um programa que solicite ao usuário o consumo mensal de água (em metros cúbicos) de uma residência e,
    // com base no valor informado, classifique o consumo da seguinte forma:

    // Se o consumo for menor que 10 m³, exiba: "Baixo consumo"
    // Se o consumo estiver entre 10 e 20 m³, exiba: "Consumo dentro da média"
    // Se o consumo estiver entre 20,01 e 30 m³, exiba: "Consumo elevado"
    // Se o consumo for acima de 30 m³, exiba: "Alto consumo"

    Console.WriteLine("Digite consumo mensal de água (em metros cúbicos) de uma residência");
    double consumoAgua = double.Parse(Console.ReadLine());

    Console.WriteLine(consumoAgua < 10 ? "Baixo consumo" :
        (consumoAgua >= 10 & consumoAgua < 20) ? "Consumo dentro da média" :
        (consumoAgua >= 20.01 & consumoAgua < 30) ? "Consumo elevado" :
        (consumoAgua > 30) ? "Alto consumo" : "Informação inválida");


}
// Descomente o bloco de código abaixo para executar o exercício
// Exercicio12();