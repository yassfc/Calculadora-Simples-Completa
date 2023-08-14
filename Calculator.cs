using System;

public class Calculator
{
    public static void Main()
    {
        int num1;
        int num2;
        int resultado = 0;
        string sn;
        int es1;

    inicio:
        Console.Clear();

        Console.WriteLine("1 - adição");
        Console.WriteLine("2 - subtração");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - divisão");
        Console.WriteLine(" ");

        Console.WriteLine("Escolha o cálculo de acordo com os números");
        es1 = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Digite o primeiro número");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número");
        num2 = int.Parse(Console.ReadLine());

        switch (es1)
        {
            case 1:
                resultado = num1 + num2;
                break;

            case 2:
                resultado = num1 - num2;
                break;

            case 3:
                resultado = num1 * num2;
                break;

            case 4:
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Não é possível dividir por zero.");
                break;
        }

        Console.WriteLine(" ");
        Console.WriteLine("O resultado é {0}", resultado);
        Console.WriteLine(" ");
        Console.WriteLine("Deseja continuar? Sim/Não");
        sn = Console.ReadLine();

        switch (sn)
        {
            case "Sim":
                goto inicio;

            case "Não":
                Console.Clear();
                Console.WriteLine("Sair");
                Console.ReadLine();
                break;
        }
    }
}
