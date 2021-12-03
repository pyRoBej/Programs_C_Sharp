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

            //string[] datos = { "Manuel", "Bejarano", "Lopez", "36", "años" };

            //Console.WriteLine("1a parte \n Hola! ingresa el texto que quieras");
            //string text = Console.ReadLine();

            //for (int i = 0; i < datos.Length; i++) //con .Length se ocupa para que el for se ejecute tantas veces se necesite mientras sea menor que la longitud del array datos
            //{
            //    Console.Write(datos[i] + " " + text + "  ");
            //}
            //Console.ReadLine();

            //foreach (string dato in datos)
            //{
            //    Console.WriteLine(dato);
            //}
            //Console.ReadLine();

            //////asignacion 2
            ////for (int i = 0; i <4; i++)
            ////{
            ////    Console.WriteLine(datos[i]);
            ////}
            ////Console.ReadLine();

            ////asignacion 3
            //Console.Clear();
            //Console.WriteLine("3a parte");
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            //Console.ReadLine();

            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(datos[i]);
            //}
            //Console.ReadLine();

            //////asignacion 4
            ////Console.Clear();
            ////var datos2 = new[] { "Manuel", "Bejarano", "Lopez", "36", "años" }; //array implicito
            ////Console.WriteLine("ingresa un texto para buscar en la lista");
            ////string selecText = Console.ReadLine();
            ////Console.ReadLine();
            ////for (int i = 0; i < datos2.Length; i++)
            ////{
            ////    if (datos2[i] == selecText)
            ////    {
            ////        Console.WriteLine("Se encontro el texto en el indice " + datos2[i]);
            ////    }
            ////    else
            ////        Console.WriteLine("el texto que ingresaste no existe en esta matriz\n\n");
            ////    Console.ReadLine();
            ////    Environment.Exit(0);
            ////}
            ////Console.ReadLine();

            ////asignacion 4.2
            //Console.Clear();
            //Console.WriteLine("4a parte"); 
            //List<string> strList = new List<string>() { "Manuel", "Bejarano", "Lopez", "36", "años" }; // lista de cadenas
            //Console.WriteLine("ingresa un texto para buscar en la lista");
            //string selecText = Console.ReadLine(); //almacena el texto ingresado del usuario en la variable selecText
            //Console.ReadLine();
            //int contador = 0;
            //for (int i = 0; i < strList.Count; i++) //. count es igual que length pero para for y no foreach
            //{
            //    if (selecText == strList[i])
            //    {
            //        contador = 1;
            //        Console.WriteLine("Se encontro el texto en el indice " + i);
            //    }
            //}
            //if (contador == 0)
            //{
            //    Console.WriteLine("el texto que ingresaste no existe en esta matriz\n\n");
            //    Console.ReadLine();
            //    //Environment.Exit(0);
            //}
            //Console.ReadLine();


            ////asignacion 5
            //Console.Clear();
            //Console.WriteLine("5a parte"); 
            //List<string> strList2 = new List<string>() { "Manuel", "Bejarano", "Lopez", "36", "años", "Bejarano" }; // lista de cadenas
            //Console.WriteLine("ingresa un texto para buscar en la lista de cadenas");
            //string selecText2 = Console.ReadLine();
            //Console.ReadLine();
            //int contador2 = 0;
            //for (int i = 0; i < strList2.Count - 1; i++)
            //{
            //    if (strList2[i] == selecText2)
            //    {
            //        contador2 = 1;
            //        Console.WriteLine("Se encontro el texto en el indice " + i);
            //        Console.ReadLine();
            //    }
            //}
            //if (contador2 == 0)
            //{
            //    Console.WriteLine("el texto que ingresaste no existe en esta matriz\n\n");
            //    Console.ReadLine();
            //    //Environment.Exit(0);
            //}
            //Console.ReadLine();

            ////asignacion 6.2
            Console.WriteLine("6a parte \n");
            List<string> strList3 = new List<string>() { "Manuel", "Bejarano", "Lopez", "36", "años", "Bejarano" }; // lista de cadenas
            List<string> strList4 = new List<string>() { "", "", "", "", "", "" };

            foreach (string datos in strList3)
            {
                if (strList4.Contains(datos))
                {
                    Console.WriteLine(datos + " ya se ha visto en la lista \n");
                }
                else if (!strList4.Contains(datos))
                {
                    strList4.Add(datos);
                    Console.WriteLine(datos + " No se ha visto en la lista \n");
                }
            }
            Console.Read();

            //Console.ReadLine();
            //int i = 0, cont = 0;
            //foreach (var dato in strList3)
            //{
            //    cont = 0;
            //    foreach (var datos2 in strList3)
            //    {
            //        if (dato == datos2 && cont == 1)
            //        {
            //            Console.WriteLine("la cadena" + datos2 + " no aparece en la lista");
            //            if (cont > 1)
            //            {
            //                Console.WriteLine("la cadena que se repite es " + datos2);

            //            }
            //        }
            //        cont++;

            //    }

            //}
            //Console.ReadLine();
        }
    }
}
