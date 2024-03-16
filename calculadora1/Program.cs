using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                while (true)
                {
                    Console.WriteLine("Escolha uma operação:");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Sair");

                    Console.Write("Opção: ");
                    string escolha = Console.ReadLine();

                    if (escolha == "5")
                    {
                        break;
                    }

                    Console.Write("Digite o primeiro número: ");
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double numero2 = Convert.ToDouble(Console.ReadLine());

                    switch (escolha)
                    {
                        case "1":
                            Console.WriteLine($"Resultado: {numero1} + {numero2} = {numero1 + numero2}");
                            break;
                        case "2":
                            Console.WriteLine($"Resultado: {numero1} - {numero2} = {numero1 - numero2}");
                            break;
                        case "3":
                            Console.WriteLine($"Resultado: {numero1} * {numero2} = {numero1 * numero2}");
                            break;
                        case "4":
                            if (numero2 != 0)
                            {
                                Console.WriteLine($"Resultado: {numero1} / {numero2} = {numero1 / numero2}");
                            }
                            else
                            {
                                Console.WriteLine("Não é possível dividir por zero!");
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    Console.WriteLine();
                }
            
        }

    }
}

