using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucas_mauricio__luan 
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, resultado;
            int opcao;

            do
            {
                Console.WriteLine("selecione uma opção");
                Console.WriteLine("1- calcular média");
                Console.WriteLine("2- calcular área");
                Console.WriteLine("0- sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("insira o primeiro valor");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("insira o segundo valor");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    resultado = n1 * n2 / 2;

                    Console.WriteLine("a média é:" + resultado);
                    Console.ReadKey();
                }

                else if (opcao == 2) 
                {
                    do
                    {
                        Console.WriteLine("1- calcular área do quadrilatero");
                        Console.WriteLine("2- calcular área do trapézio");
                        Console.WriteLine("3- calcular área do triangulo");

                        if (opcao == 1)
                        {

                        }
                    } while (opcao != 0);
                }

                else if (opcao == 0) 
                {
                    Console.WriteLine("encerrando o programa...");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("voce inseriu um valor invalido");
                    Console.ReadKey();


                }

            } while (opcao != 0);
            Console.ReadKey();

        }
    }
}
