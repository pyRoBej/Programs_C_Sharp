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

            Employee empleado = new Employee();

            empleado.firstName = "Assigment";
            empleado.lastName = "305";
            empleado.sayName();             //estoy mandando llamar el metodo dentro de la clase employee que me imprime un nombre completo con los valores que meti anteriormente a firstName y lastName

            Console.ReadKey();


        }
    }
}
