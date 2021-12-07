using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion292.cs
{
    public class Empleado : Persona  //para heredar simplemente hay que poner ":" (dos puntos) y la clase de la que heredara
    {
        //public Empleado(string firstName, string lastName) : base(firstName, lastName)
        //{

        //}

        public int ID { get; set; }

    }
}
