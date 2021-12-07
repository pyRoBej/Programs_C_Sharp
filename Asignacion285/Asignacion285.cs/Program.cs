using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion285.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada

            Console.WriteLine("Hola, a continuacion haremos una división, proporcione el número al que vamos a dividir entre 2");
            int num1 = Convert.ToInt32(Console.ReadLine()); //lee el valor

            NumEnt num = new NumEnt();  //es la instancia que llama a mi clase NumEnt y al metodo genNum

            num.genNum(num1);               // aqui estoy haciendo llamar al metodo genNum que esta en la clase NumEnt

            Console.ReadKey();
        }
    }
}
