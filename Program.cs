using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----Calculadora------");

            bool continuar = true;

            while (continuar)
            {


                Console.WriteLine("Digite um número: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Operador: ");
                string operador = (Console.ReadLine());

                double resultado;







                switch (operador)
                {
                    case "+":
                        resultado = n1 + n2;
                        Console.WriteLine(resultado);
                        break;

                    case "-":
                        resultado = n1 - n2;
                        Console.WriteLine(resultado);
                        break;

                    case "*":
                        resultado = n1 * n2;
                        Console.WriteLine(resultado);
                        break;

                    case "/":
                        resultado = n1 / n2;
                        Console.WriteLine(resultado);
                        break;


                }

                Console.WriteLine("Deseja Continuar? (Sim/Não)");
                string resposta = Console.ReadLine();

                if (resposta != "sim" && resposta != "Sim" && resposta != "SIM")
                {
                    continuar = false;
                    Console.WriteLine("Obrigado!");
                }
            }

        }
    }
}
