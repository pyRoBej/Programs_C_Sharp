using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2 de arrays 
            Console.WriteLine("The Tech Academy.\n Arrays.");

            var datos = new[] { "Manuel", "Bejarano", "Lopez", "36", "años" };
            string[] array1 = new string[] { "Manuel", "Bejarano", "Lopez", "36", "años" };
            Console.WriteLine("Hola, seleccione un indice de la matriz entre 0 y 4");
            int indice = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (indice >= 0 && indice <= 4)
            {
                Console.WriteLine("seleccionaste: " + datos[indice] + "\n\n");
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");

            //array unidimensional de numeros enteros
            int[] numeros = new int[] { 15, 27, 19, 80, 1 };
            Console.WriteLine("Hola, seleccione un indice de la matriz de numeros entre 0 y 4");
            int indice2 = Convert.ToInt32(Console.ReadLine());
            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (indice2 >= 0 && indice2 <= 4)
            {
                Console.WriteLine("seleccionaste: " + numeros[indice2] + "\n\n");
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");

            // lista de cadenas
            //creacion y llenado de la lista
            List<string> strList = new List<string>();
            strList.Add("Manuel"); strList.Add("Cesar"); strList.Add("Fernando"); strList.Add("David"); strList.Add("Mayra");
            strList.Add("Ubaldo");
            Console.WriteLine("Hola, seleccione un indice de la matriz entre 0 y 5");
            int selecIndice = Convert.ToInt32(Console.ReadLine());

            //seleccion de condicion para ingresar al intervalo ingreado correcto
            if (selecIndice >= 0 && selecIndice <= 5)
            {
                Console.WriteLine("seleccionaste: " + strList[selecIndice]);
            }
            else
                Console.WriteLine("el indice que ingreso no existe en esta matriz\n\n");
            Console.ReadLine();

        }
    }

    //class Arrays2_0
    //{
    //    public Array(String x, int y )
    //    {

    //    }
    //    //array implicito
    //    var datos = new[] { };
    //}
}
