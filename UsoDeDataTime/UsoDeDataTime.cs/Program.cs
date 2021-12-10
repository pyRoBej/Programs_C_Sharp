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
            //Console.ReadLine();

            Console.WriteLine("Enter a number to add the hours to the current date");
            //Console.WriteLine("Introduce un numero para sumar las horas a la fecha actual");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //Console.WriteLine(DateTime.Now.AddHours(num));
            //Console.WriteLine("La fecha de hoy es: " + DateTime.Now + num + "horas.");
            Console.WriteLine("Today's date plus " + num + " hours "  + " is: " + DateTime.Now.AddHours(num) );
            Console.ReadLine();
        }
    }
}
