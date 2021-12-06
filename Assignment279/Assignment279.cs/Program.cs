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

            Console.WriteLine("El resultado de la operación suma es: " + ops.suma(numero) + "\n"); //aqui le estoy diciendo que imprima el texto y le concatene la clase ops con su metodo suma

            Console.WriteLine("Escriba un numero con decimales para hacer operaciones?");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine()); //lee el valor
            Console.WriteLine("El resultado de la operación resta es: " + ops.resta(numero2) + "\n");

            Console.WriteLine("Escriba un numero para hacer operaciones?");
            string numero3 = Console.ReadLine(); //lee el valor
            Console.WriteLine("El resultado de la operación multiplicación es: " + ops.multp(numero3));

            Console.ReadLine();
        }
    }
}
