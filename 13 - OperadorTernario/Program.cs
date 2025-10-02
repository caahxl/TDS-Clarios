//Texto de múltiplas linhas
Console.WriteLine("""
    Hola
    Pendejo(a)!
    """);

// Outra forma de se declarar
Console.WriteLine(@"Texto de]
Múltiplas 
linha");

// Múltiplas linhas com interpolação
string nome = "Santiana";
string curso = "Programação C#";

Console.WriteLine($"""
    Nome: {nome}
    Curso {curso}
    """);

Console.WriteLine("\n------------------------------\n");

Console.WriteLine("Texto de\nMúltiplas\nLinhas");

Console.WriteLine("Texto de\n" + 
    "Múltiplas\n" +
    "Linhas");
