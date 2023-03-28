using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        switch (salario)
        {
            case 1:
                salario >= 1900.0 && salario <= 2800.0
                break;


        }

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("O seu IR pode reduzir 7.5% sendo um valor de R$142");
        }
        else if (salario >= 2800.1 && salario <= 3751.00)
        {
            Console.WriteLine("O seu IR pode reduzir 15% sendo um valor de R$350");
        }
        else if (salario >= 3751.1 && salario <= 4664.0)
        {
            Console.WriteLine("O seu IR pode reduzir 22.5% sendo um valor de R$636");
        }
    }

}
}