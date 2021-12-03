using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio manejo de excepciones
            Console.WriteLine("The Tech Academy.\n Excepciones.");

            try
            {
                List<int> numeros = new List<int>() { 20, 50, 60, 85 }; // lista de numeros enteros

                //Console.WriteLine("Hola! ingrese un numero");
                //int numUno = Convert.ToInt32(Console.ReadLine());
                //numeros[0] = numUno;
                //Console.WriteLine("Ingrese un segundo numero");
                //int numDos = Convert.ToInt32(Console.ReadLine());
                //numeros[1] = numDos;
                //Console.WriteLine("Ingrese un tercer numero");
                //int numTres = Convert.ToInt32(Console.ReadLine());
                //numeros[2] = numTres;
                //Console.WriteLine("Ingrese un cuarto numero");
                //int numCuatro = Convert.ToInt32(Console.ReadLine());
                //numeros[3] = numCuatro;
                //Console.WriteLine("Ingrese un quinto numero");
                //int numCinco = Convert.ToInt32(Console.ReadLine());
                //numeros[4] = numCinco;
                Console.WriteLine("Escoja un numero entero con el que se dividiran el resto de numeros");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                for (int i =0; i < numeros.Count; i++)
                {
                    int result =  numeros[i] / numberOne;
                    Console.WriteLine("El numero en el indice " + i + " de la cadena dividido entre " + numberOne + " es gual a " + result);
                }
                Console.ReadLine();
            }
            catch (FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
