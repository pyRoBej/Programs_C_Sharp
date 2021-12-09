using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion_313.cs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var emp1 = new Empleado(1, "Manuel", "Bejarano");
            var emp2 = new Empleado(2, "David", "Cortes");

            //if (emp1 == emp2)
            //    Console.WriteLine("Los empleados tienen el mismo ID");
            //else
            //    Console.WriteLine("Los empleados tienen diferente ID");

            //la siguiente forma es otra version del if anterior, de esta forma queda mucho mas limpio el codigo
            var result = emp1 == emp2 ? "Los empleados tienen el mismo ID" : "Los empleados tienen diferente ID";
            Console.WriteLine(result);

            Console.ReadKey();

        }

        private class Empleado
        {

            public Empleado(int id, string nombre, string apellido)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.id = id;
            }

            private int id { get; set; }
            private string nombre { get; set; }
            private string apellido { get; set; }


            public static bool operator ==(Empleado empl, Empleado emp2) => empl.id == emp2.id;
            
            public static bool operator !=(Empleado empl, Empleado emp2) => empl.id != emp2.id;

            public override string ToString()
            {
                return String.Format ($"ID: {id}, Nombre Completo {nombre} {apellido}");
            }
        }

    }
}
