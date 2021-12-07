using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment279.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada

            Console.WriteLine("Hola bienvenido, Selecciona un numero para hacer operaciones?");
            int numero = Convert.ToInt32(Console.ReadLine()); //lee el valor

            OpsMath2 ops = new OpsMath2();

            Console.WriteLine("El resultado de la operación suma es: " + ops.suma(numero) + "\n");

            Console.WriteLine("Escriba un numero con decimales para hacer operaciones?");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine()); //lee el valor
            Console.WriteLine("El resultado de la operación resta es: " + ops.suma(numero2) + "\n");

            Console.WriteLine("Escriba un numero para hacer operaciones?");
            string numero3 = Console.ReadLine(); //lee el valor
            Console.WriteLine("El resultado de la operación multiplicación es: " + ops.suma(numero3)); //sobre carga del metodo

            Console.ReadLine();
        }
    }
}
