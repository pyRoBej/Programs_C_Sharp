using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("piensa un numero entre el 1 y el 10");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("pensaste en el 1, prueba de nuevo");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("pensaste en el 2, prueba de nuevo");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
