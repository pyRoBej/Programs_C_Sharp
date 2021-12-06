using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLlamada.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada
            
            Console.WriteLine("Hola bienvenido, Selecciona un numero para hacer operaciones?");
            int numero = Convert.ToInt32(Console.ReadLine()); //lee el valor

            OpsMath ops= new OpsMath();

            Console.WriteLine("El resultado de la operación suma es: " + ops.suma(numero)); //aqui le estoy diciendo que imprima el texto y le concatene la clase ops con su metodo suma
            Console.WriteLine("El resultado de la operación resta es: " + ops.resta(numero));
            Console.WriteLine("El resultado de la operación multiplicación es: " + ops.multp(numero));

            Console.ReadLine();

        }
    }
}
