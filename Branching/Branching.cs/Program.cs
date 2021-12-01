using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("cual es tu numero favorito");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "you have an awesome fav number." : "you dont have an awesome fav numbes";

            Console.WriteLine(result);
            Console.ReadLine();

            /* int roomTemperature = 80;

            Console.WriteLine("Hola, cual es tu nombre");
            string name = Console.ReadLine();

            Console.WriteLine("Hola " + name + ",  cual es la temperatura donde estas?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("its excatly room temperature.");
            } else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("it is warmer than room temp");
            } else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("Room temperature is warmer than current temperature");
            }
            else
            {
                Console.WriteLine("it isnt exactly room temperature.");
            }
            Console.ReadLine(); */


            /* int currentTemperature = 80;
            int roomTemperature = 70;

            string comparisonResult = currentTemperature == roomTemperature ? "it is room temp" : "it is not room temp";

            Console.WriteLine(comparisonResult);
            Console.ReadLine();

             if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("its exactly room temperature.");
            } else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("its warmer than room temperature");
            } else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("Room temperature is warmer than current temperature");
            } else
            {
                Console.WriteLine("it isnt exactly room temperature.");
            } */
            Console.ReadLine();


        }
    }
}
