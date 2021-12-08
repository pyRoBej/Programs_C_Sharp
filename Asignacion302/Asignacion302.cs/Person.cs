using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void sayName();

    }    
}


//otra forma de get y set a las propiedades
//public int Salario
//{
//    get => this.salario;
//    set => this.salario = evaluaSalario(value);
//}

//private int salario;