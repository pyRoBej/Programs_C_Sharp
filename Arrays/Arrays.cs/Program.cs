using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de arrays
            Console.WriteLine("The Tech Academy.\n Arrays.");

            var datos = new[] { "Manuel", "Bejarano", "Lopez", "36", "años" };
            string[] array1 = new string[] { "Manuel", "Bejarano", "Lopez", "36", "años" };
            Console.WriteLine("Hola, seleccione un indice de la matriz entre 0 y 4");
            int indice = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (indice >= 0 && indice <= 4) {
                Console.WriteLine("seleccionaste: " + datos[indice] + "\n\n");
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");
 
            //array unidimensional de numeros enteros
            int[] numeros = new int[] {15, 27, 19, 80, 1 } ; 
            Console.WriteLine("Hola, seleccione un indice de la matriz de numeros entre 0 y 4");
            int indice2 = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (indice2 >= 0 && indice2 <= 4) {
                Console.WriteLine("seleccionaste: " + numeros[indice2] + "\n\n");
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");

            // lista de cadenas
            //creacion y llenado de la lista
            List<int> intList = new List<int>();
            intList.Add(000); intList.Add(100); intList.Add(200); intList.Add(300); intList.Add(400);
            intList.Add(500);
            Console.WriteLine("Hola, seleccione un indice de la matriz entre 0 y 5");
            int selecIndicelist = Convert.ToInt32(Console.ReadLine());

            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (selecIndicelist >= 0 && selecIndicelist <= 5) {
                Console.WriteLine("seleccionaste: " + intList[selecIndicelist]);
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");
            Console.ReadLine();
        }
    }
}
