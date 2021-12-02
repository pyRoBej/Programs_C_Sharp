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
            //asignacion 1
            Console.WriteLine("The Tech Academy.\n Arrays.");

            string[] datos = { "Manuel", "Bejarano", "Lopez", "36", "años" };

            Console.WriteLine("Hola! ingresa el texto que quieras");
            string text = Console.ReadLine();

            for (int i = 0; i < datos.Length; i++) //con .Length se ocupa para que el for se ejecute tantas veces se necesite mientras sea menor que la longitud del array datos
            {
                Console.Write(datos[i] + " " + text + "  ");
            }
            Console.ReadLine();

            foreach (string dato in datos)
            {
                Console.WriteLine(dato);
            }
            Console.ReadLine();

            ////asignacion 2
            //for (int i = 0; i <4; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            //Console.ReadLine();

            //asignacion 3
            Console.Clear();
            for (int i = 0; i <4; i++) 
            {
                Console.WriteLine(datos[i]);
            }
            Console.ReadLine();

            for (int i = 0; i <=4; i++) 
            {
                Console.WriteLine(datos[i]);
            }
            Console.ReadLine();

            //asignacion 4
            Console.Clear();
            string datos2 = "Manuel Bejarano Lopez 36 años";
            Console.WriteLine("ingresa un texto para buscar en la lista");
            string selecText = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Se encontro el texto en el indice " + datos2.IndexOf(selecText));
            Console.ReadLine();


            //asignacion 5
            Console.Clear();
            //string[] datos3 = { "Manuel", "Bejarano", "Lopez", "36", "años" };

            string datos3 = "Manuel Bejarano Lopez 36 años";
            Console.WriteLine("ingresa un texto para buscar en la lista de cadenas");
            string selecText2 = Console.ReadLine();
            Console.ReadLine();
            for (int i = 0; i < datos3.Length -1; i++)
            {
                int selecText3 = Convert.ToInt32(selecText2);
                ////if (a > b)
                if (datos3[i].CompareTo(datos3[selecText3]) > 0)
                //    {
                //    string selecText4 = Convert.ToString(selecText3);
                //    Console.WriteLine("Se encontro el texto en el indice " + datos3.IndexOf(selecText4));
                //    }
                //}

               

                //if (datos3[i].CompareTo(datos3[selecText2]))
                {
                    Console.WriteLine("Se encontro el texto en el indice " + datos3.IndexOf(selecText2));
                }
                else
                {
                    Console.WriteLine("su entrada no esta en la lista");
                }
            }
            Console.ReadLine();

        }
    }
}
