using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; 

namespace ExFatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Determine number
            Console.WriteLine("Digite um número inteiro positivo, para efetuar seu fatorial: ");
            int n = int.Parse(Console.ReadLine());
            //Make factorial
            int r = fatorial(n);
            //Display result
            Console.WriteLine($"Resultado: {r:n0}");
            //Press to exit
            Console.ReadLine();
        }

        static int fatorial(int n)
        {
            if(n>0)
            {
                return n*fatorial(n-1);
            }
            else
            {
                return 1;
            }
        }

    }
}
