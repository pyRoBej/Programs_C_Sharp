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

            List<Empleados> empleados = new List<Empleados>();  // creacion de la lista empleados

            // se agregan datos a la lista recien creada.
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

            Console.WriteLine("Lista completa. \n");
            foreach (Empleados emp in empleados)
            {
                Console.WriteLine(emp);
                //Console.WriteLine("\n");
            }
            Console.ReadLine();

            //creacion de la lista  para los nombres Joe e impresion de la misma con foreach
            List<Empleados> JoeList = new List<Empleados>();

            foreach (Empleados emp2 in empleados)
            {
                if (emp2.EmplName == "Joe")
                {
                    JoeList.Add(emp2);
                }
            }
            foreach (Empleados emp in JoeList)
            {
                Console.WriteLine(emp);
            }
            Console.ReadLine();
            Console.WriteLine("\n");
            
            //creacion de la lista  para los nombres Joe e impresion de la misma con lambda
            Console.WriteLine("Lista de nombres que se llamen Joe. \n");
            List <Empleados> JoeList2 = empleados.Where(x => x.EmplName == "Joe").ToList(); //del lado izq empieza con la creacion de la lista JoeList2,
                                                                                            //despues se busca (.where) en la lista empleados y entra lambda
                                                                                            //que es [x => x.EmplName == "Joe").ToList();] x es la variable
                                                                                            //donde se va a guardar la condicion (EmplName = a Joe)
            JoeList2.ForEach(x => Console.WriteLine(x)); //del lado izq antes de lambda va la lista JoeList2 y el ciclo foreach luego entra lambda
                                                         //donde se le dice q imprima lo que se guardo en "x" de la lista JoeList2
            Console.ReadLine();

            //creacion de la lista  para los Id mayor que 5 e impresion de la misma con foreach
            //List<Empleados> idMyr = new List<Empleados>();

            //foreach (Empleados emp3 in empleados)
            //{
            //    if (emp3.EmplId > 5)
            //    {
            //        idMyr.Add(emp3);
            //        //Console.WriteLine("\nThe names with Id greater than 5 are : " + emp3.EmplName + " " + emp3.EmplLastName + " Id = "+emp3.EmplId);
            //    }
            //}
            //Console.ReadLine();

            //creacion de la lista  para los Id mayor que 5 e impresion de la misma con lambda
            Console.WriteLine("Lista de nombres que su Id sea mayor que 5 \n");
            List<Empleados> idMyr = empleados.Where(emp3 => emp3.EmplId > 5).ToList(); //del lado izq empieza con la creacion de la lista idMyr,
                                                                                       //despues se busca (.where) en la lista empleados y entra lambda
                                                                                       //que es [emp3 => emp3.EmplId > 5).ToList();] emp3 es la variable
                                                                                       //donde se va a guardar la condicion (EmplId mayor que 5)
            idMyr.ForEach(emp3 => Console.WriteLine(emp3));
            Console.ReadLine();



        }
    }

    public class Person
    {
        public int EmplId { get; set; }
        public string EmplName { get; set; }
        public string EmplLastName { get; set; }
    }

}
