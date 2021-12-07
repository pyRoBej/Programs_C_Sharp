using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion292.cs
{
    public class Persona 
        {
        //public Persona(string firstName, string lastName)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //}
        //public List<string> Empleados { get; set; }
        
        // propiedades de la clase Persona
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void sayName()
            {
                Console.WriteLine($"Nombre es: [ {firstName} {lastName}]");
            }
         }

        
}
