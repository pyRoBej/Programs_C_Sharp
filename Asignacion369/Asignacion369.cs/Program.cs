using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion369.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Fecha y hora actual.");
            Console.WriteLine("Current date and time.");
            Console.WriteLine(DateTime.Now.DayOfWeek + " " + DateTime.Now + "\n");

            Console.WriteLine("Enter a number to add the hours to the current date");
            //Console.WriteLine("Introduce un numero para sumar las horas a la fecha actual");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //Console.WriteLine("La fecha de hoy  mas " + num + " hs " + " es: " + DateTime.Now.AddHours(num));
            Console.WriteLine("Today's date plus " + num + " hours " + " is: " + DateTime.Now.AddHours(num));
            Console.ReadLine();

        }
    }
}
