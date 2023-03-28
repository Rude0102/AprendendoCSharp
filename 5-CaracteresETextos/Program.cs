using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5");
        char letra = 'a';
        Console.WriteLine(letra);

        string primeirafrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeirafrase + 2023);
        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis: 
    -Python
    -Java
    -HTML
";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}