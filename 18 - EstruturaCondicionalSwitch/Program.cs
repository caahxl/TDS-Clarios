//Calculadora com Switch

Console.WriteLine("Digite o 1° número:");
double n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2° número:");
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("""
    1. Soma
    2. Subtração
    3. Multiplicação
    4. Divisão
    """);
Console.WriteLine("Escolha uma das operações acima:");
int opcao = int .Parse(Console.ReadLine());

//match python
switch (opcao)
{
    case 1:
        Console.WriteLine($"Resultado: {n1 + n2}");
        break;

    case 2:
      Console.WriteLine($"Resultado: {n1 - n2}");
      break;

    case 3:
        Console.WriteLine($"Resultado: {n1 * n2}");
        break;

    case 4:
        Console.WriteLine($"Resultado: {n1 / n2}");
        break;

    default:
        Console.WriteLine("Operação inválida");

        Console.ReadKey();


    // Vogal ou Consoamte com switch

    char letra = char.Parse(Console.ReadLine());

     switch (letra)
     {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':

          Console.WriteLine("voce digitou uma vogal");
          break;
            default:
            Console.WriteLine("Voce digitou uma consoante");
            break;




        }
}