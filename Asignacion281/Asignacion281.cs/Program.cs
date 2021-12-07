using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion281.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada

            Console.WriteLine("Hola, a continuacion haremos una multiplicación, proporcione el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine()); //lee el valor
            Console.WriteLine("...proporcione el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine()); //lee el valor

            Ops ops = new Ops();

            //Console.WriteLine("El resultado de la multiplicación es: "  ops.multp(num1, num2) "\n");
            Console.WriteLine(ops.multp(num1, num2);
            Console.ReadLine();

        }

    }
}
