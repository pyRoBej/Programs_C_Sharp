using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();  //crea un # aleatorio
            int numAleat = numero.Next(0, 100); // establece que el # aleatorio debe estar entre 0 y 100
            int miNumero = 101; // mi 1a entrada debe permitir entrar al bucle, por eso declaramos esta variable mayor a 100
            int intentos = 0; // esta variable va a ir aumentando cada que se entra en el bucle
            Console.WriteLine("Trata de adivinar el numero aleatorio, introduce un numero entre 0 y 100");

            while (numAleat != miNumero) //el bucle establece mi numero es diferente a 0-100
            {
                intentos++; //en este momento se incrementa la variable de intentos
                miNumero = int.Parse(Console.ReadLine()); // el metodo Parse sirve para que considere como numero entero lo que introdujimos en consola, de lo contrario lo considerara texto y no se puede comparar
                // el sig if es para comparar usando el condicional if donde le digo que si mi numero es menor que el aleatorio, escriba que es mas bajo, para asi darle una idea al usuario de que numero siguiente escoja
                if (miNumero < numAleat) Console.WriteLine("El # que introdujiste es mas bajo que el aleatorio");
                // con el sig if le digo que si mi numero es mayor que el aleatorio, escriba que es mas alto, para asi darle una idea al usuario de que numero siguiente escoja
                if (miNumero > numAleat) Console.WriteLine("El # que introdujiste es mas alto que el aleatorio");

            }

            Console.WriteLine($"Acertaste! has necesitado {intentos} intentos");
            Console.ReadLine();
            Random numero2 = new Random();  //crea un # aleatorio
            int numAleat2 = numero2.Next(0, 100); // establece que el # aleatorio debe estar entre 0 y 100
            int miNumero2; // mi 1a entrada debe permitir entrar al bucle, por eso declaramos esta variable mayor a 100
            int intentos2 = 0; // esta variable va a ir aumentando cada que se entra en el bucle
            Console.WriteLine("Trata de adivinar nuevamente el numero aleatorio, introduce un numero entre 0 y 100");

            do
            {
                intentos2++; //en este momento se incrementa la variable de intentos
                miNumero2 = int.Parse(Console.ReadLine()); // el metodo Parse sirve para que considere como numero entero lo que introdujimos en consola, de lo contrario lo considerara texto y no se puede comparar
                // el sig if es para comparar usando el condicional if donde le digo que si mi numero es menor que el aleatorio, escriba que es mas bajo, para asi darle una idea al usuario de que numero siguiente escoja
                if (miNumero2 < numAleat2) Console.WriteLine("El # que introdujiste es mas bajo que el aleatorio");
                // con el sig if le digo que si mi numero es mayor que el aleatorio, escriba que es mas alto, para asi darle una idea al usuario de que numero siguiente escoja
                if (miNumero2 > numAleat2) Console.WriteLine("El # que introdujiste es mas alto que el aleatorio");

            } while (numAleat2 != miNumero2); //el bucle establece mi numero es diferente a 0-100

            Console.WriteLine($"Acertaste! has necesitado {intentos2} intentos");
            Console.ReadLine();
        }
    }
}
