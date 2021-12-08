using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    public class Employee : Person, IQuitTable 
    {
        
        public override void sayName()
        {
            Console.WriteLine($"Nombre es: [ {firstName} {lastName}]");
        }

        public void Quit()   //para poder heredar esto, es porque no es una clase propiamente, es mas bien una interfaz
        {
            //throw new ArgumentException();
            Console.WriteLine($"Use polymorphism");
        }

    }
    
}
