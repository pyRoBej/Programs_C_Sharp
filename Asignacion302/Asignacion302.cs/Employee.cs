using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }


        public void sayName()
        {
            Console.WriteLine($"Nombre es: [ {firstName} {lastName}]");
        }

    }
    
}
