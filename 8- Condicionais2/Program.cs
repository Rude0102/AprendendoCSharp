using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar! ");
        }
        else
        {

            Console.WriteLine("Não pode entrar irmão! >:( ");

        }
    }

    }