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
            //Empleado empleado = new Empleado(1, "Manuel", "Bejarano");
            //Empleado emp2 = new Empleado(2, "Manuel", "Bejarano");

            ////empleado.nombreCompleto(1, "Manuel", "Bejarano");
            //empleado.idEmpleado(1);
            //emp2.idEmpleado(2);

            //Console.WriteLine(empleado);
            //Console.WriteLine(emp2);
            var emp1 = new Empleado(1, "Manuel", "Bejarano");
            var emp2 = new Empleado(2, "David", "Cortes");

            if (emp1 == emp2)
                Console.WriteLine("Los empleados tienen el mismo ID");
            else
                Console.WriteLine("Los empleados tienen diferente ID");

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


            //public void nombreCompleto (int ID, string name, string lastName)
            //{
            //    ID = id; nombre = name; apellido = lastName;
            //}

            //public void idEmpleado (int Id)
            //{
            //    Id = id;
            //    Id++;
            //}

            public static bool operator ==(Empleado empl, Empleado emp2) => empl.id == emp2.id;
            
            public static bool operator !=(Empleado empl, Empleado emp2) => empl.id != emp2.id;

            public override string ToString()
            {
                return String.Format ($"ID: {id}, Nombre Completo {nombre} {apellido}");
            }
        }

    }
}
