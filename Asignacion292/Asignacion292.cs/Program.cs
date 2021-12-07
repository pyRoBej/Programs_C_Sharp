using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion292.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();  //instancia para llamar a la clase Empleado 

            empleado.firstName = "Muestra";  //le estoy pasando los valores de string que se guardaran en las variables firstName y lastName
            empleado.lastName = "Estudiante";
            empleado.sayName();             //estoy mandando llamar el metodo dentro de la clase persona que me imprime un nombre completo con los valores que meti anteriormente a firstName y lastName

            Console.ReadKey();
        }
    }
}
