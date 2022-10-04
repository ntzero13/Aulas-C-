using System;

namespace Aula_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 2.1
           string numero1,numero2;
           numero1 = Console.ReadLine();
           numero2 = Console.ReadLine();
           Console.WriteLine(numero2);
           Console.WriteLine(numero1);*/

            /* Exercicio 2.2
            Console.WriteLine("Digite um numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero3 = Int32.Parse(Console.ReadLine());
            int total = numero * numero2 * numero3;
            Console.WriteLine("A multiplicaçao dos valores {0} {1} {2} é  {3} ", numero,numero2,numero3, total);*/

            /* Exercicio 2.3*/
            Console.WriteLine("Digite um numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero2 = Int32.Parse(Console.ReadLine());
            int adicao = numero + numero2;
            int subtracao = numero - numero2;
            int mult = numero * numero2;
            int div = numero/ numero2;
            int MOD = numero % numero2;
            Console.WriteLine("A adiçao dos numeros {0} e {1} é = {2}",numero, numero2, adicao);
            Console.WriteLine("A subtração dos numeros {0} e {1} é = {2}", numero, numero2, subtracao);
            Console.WriteLine("A multiplicação dos numeros {0} e {1} é = {2}", numero, numero2, mult);
            Console.WriteLine("A divisão dos numeros {0} e {1} é = {2}", numero, numero2, div);
            Console.WriteLine("O resto da divição dos numeros {0} e {1} é = {2}", numero, numero2, MOD);

        }
    }
}
