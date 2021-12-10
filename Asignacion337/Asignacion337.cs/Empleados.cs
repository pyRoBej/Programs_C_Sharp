using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion337.cs
{
    public class Empleados : Person
    {

        public override string ToString()
        {
            //return "ID: " + EmplId + "    Name: " + EmplName + "   Apellido: " + EmplLastName;
            return " " + EmplId + "  " + EmplName + "  " + EmplLastName;
        }
    }
}
