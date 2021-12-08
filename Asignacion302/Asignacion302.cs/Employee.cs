using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    public class Employee : Person
    {
        
        public override void sayName()
        {
            Console.WriteLine($"Nombre es: [ {firstName} {lastName}]");
        }

    }
    
}
