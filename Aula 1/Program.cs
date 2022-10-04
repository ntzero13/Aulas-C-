using System;

namespace Aula_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 1.1
             Console.WriteLine("Hello\n");
            Console.WriteLine("Leoncio"); */

            /* Exercicio 1.2 
             int valor1, valor2;
             valor1 = 5;
             valor2 = 6;
             Console.WriteLine(valor2 + valor1);*/

            /*Exercicio 1.3
            string numero;
            numero = Console.ReadLine();
            Console.WriteLine(numero);*/

            /* Exercicio 2.1
            string numero1,numero2;
            numero1 = Console.ReadLine();
            numero2 = Console.ReadLine();
            Console.WriteLine(numero2);
            Console.WriteLine(numero1);*/

            /* Exercicio 2.2*/
            Console.WriteLine("Digite um numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero3 = Int32.Parse(Console.ReadLine());
            int total = numero * numero2 * numero3;
            Console.WriteLine("A multiplicaçao dos valores {0} {1} {2} é  {3} ", numero,numero2,numero3, total);

        }
    }
}
