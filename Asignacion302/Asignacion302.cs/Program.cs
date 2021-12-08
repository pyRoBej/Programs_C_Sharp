using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee empleado1 = new Employee();
            IQuitTable empleado = new Employee();

            
            empleado1.firstName = "Assigment";
            empleado1.lastName = "305";
            empleado1.sayName();             //estoy mandando llamar el metodo dentro de la clase employee que me imprime un nombre completo con los valores que meti anteriormente a firstName y lastName

            empleado.Quit();

            Console.ReadKey();


        }
    }
}
