using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            double resultado;
            Console.Clear();

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("Soma");
            Console.WriteLine("Divisão");
            Console.WriteLine("Subtração");
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Menu");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("..............................");

            Console.WriteLine("Selecione a opção desejada:");
            string opcao = (Console.ReadLine());
            Console.WriteLine("Insira o primeiro valor");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:");
        

            switch (opcao)
            {

                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine(resultado);
                    break;
                case "/":
                    resultado = num1 / num2;
                    Console.WriteLine(resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine(resultado);
                    break;
                case "Sair":
                    System.Environment.Exit(0);
                    break;
                default:
                    break;

            }
            Console.ReadKey();
        }

    }
}
