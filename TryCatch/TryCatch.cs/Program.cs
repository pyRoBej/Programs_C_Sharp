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

                Console.WriteLine("Escoja un numero entero con el que se dividiran el resto de numeros");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                for (int i =0; i < numeros.Count; i++)
                {
                    int result =  numeros[i] / numberOne;
                    Console.WriteLine("El numero " + " (" + numeros[i] + ") " + " que esta en el indice "+ i + " de la cadena, dividido entre " + numberOne + " es gual a " + result);
                }
                Console.Read();
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Por favor escriba un número entero");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No puede dividir entre cero, seleccione otro.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Ha salido del try/catch");
                Console.ReadLine();
            }

        }
    }
}
