using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeDataTime.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fecha y hora actual");
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Introduce un numero para sumar en horas a la fecha actual");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();



        }
    }
}
