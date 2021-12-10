using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Asignacion337.cs
{
    public class Program
    {

        public static void Main()
        {

            //Empleados empleado = new Empleados();

            List<Empleados> empleados = new List<Empleados>();

            empleados.Add(new Empleados() {EmplId=1, EmplName="Manuel", EmplLastName="Bejarano" });
            empleados.Add(new Empleados() { EmplId = 2, EmplName = "Engels", EmplLastName = "Reyes" });
            empleados.Add(new Empleados() { EmplId = 3, EmplName = "Joe", EmplLastName = "Bidden" });
            empleados.Add(new Empleados() { EmplId = 4, EmplName = "Fernando", EmplLastName = "Perez" });
            empleados.Add(new Empleados() { EmplId = 5, EmplName = "Cesar", EmplLastName = "Tapia" });
            empleados.Add(new Empleados() { EmplId = 6, EmplName = "Jose", EmplLastName = "Cruz" });
            empleados.Add(new Empleados() { EmplId = 7, EmplName = "Ubaldo", EmplLastName = "Cruz" });
            empleados.Add(new Empleados() { EmplId = 8, EmplName = "David", EmplLastName = "Cortes" });
            empleados.Add(new Empleados() { EmplId = 9, EmplName = "Joe", EmplLastName = "West" });
            empleados.Add(new Empleados() { EmplId = 10, EmplName = "Mayra", EmplLastName = "Martinez" });

            foreach (Empleados emp in empleados)
            {
                Console.WriteLine(emp);
                //Console.WriteLine("\n");
            }
            Console.ReadLine();

            //int index = empleados.BinarySearch(empleados=Convert.ToString ("Joe"));
            //if (index < 0) 

            //foreach (Empleados emp in empleados)
            //{
            //    if (empleados.Contains(emp))
            //    { 
            //    }

            //}
            //Console.ReadLine();

        }
    }

    public class Person
    {
        public int EmplId { get; set; }
        public string EmplName { get; set; }
        public string EmplLastName { get; set; }
    }

}
