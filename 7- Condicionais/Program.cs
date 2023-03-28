using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar! ");
        }

        else
        {

            if (quantidadePessoas > 0)
            {
                Console.WriteLine("Eles está acompanhado, pode entrar");
            }
            else
            {

                Console.WriteLine("Não pode entrar irmão! >:( ");

            }
        }

        Console.WriteLine("tecle para fechar...");
        Console.ReadLine();
    }
}