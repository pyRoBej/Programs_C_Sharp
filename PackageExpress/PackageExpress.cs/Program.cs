using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Package Express
            Console.WriteLine("The Tech Academy.\n Package Express S.A. de C.V.");
            Console.WriteLine("Hola, Bienvenido a Package Express, por favor siga las instrucciones");
            Console.WriteLine("Cual es el peso de tu paquete?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight >= 50)
            {
                Console.WriteLine("ERROR!!!, \n Paquete demasiado pesado para ser enviado a travez de Package Express; que tenga un buen dia. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Cual es el ancho de tu paquete?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la altura de tu paquete?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la longitud de tu paquete?");
            int length = Convert.ToInt32(Console.ReadLine());

            double dimension = width + height + length;
            if (dimension >= 50)
            {
                Console.WriteLine("ERROR!!!, \n Paquete demasiado grande para enviarse a travez de Package Express; que tenga un buen dia. ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            double dimension2 = width * height * length;
            double cotizacion = dimension2 * weight / 100.0;
            Console.WriteLine("Su total estimado para enviar este paquete es: $" + cotizacion + " Gracias!");
            Console.ReadLine();

        }
    }
}
