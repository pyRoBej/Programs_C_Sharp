using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion302.cs
{
    public class Person
    {
        public Person(string firstName, string lastName)  //este es el constructor que tiene como parametros dos strings (FirsteName y LastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }




        //public string getFirstName()
        //{
        //    return FirstName;
        //}

        //public void setFirstName(string firstName)
        //{
        //    Console.WriteLine("Nombre: ");
        //}

        //public string getLastName()
        //{
        //    return LastName;
        //}

        //public void setLastName(string lastName)
        //{
        //    Console.WriteLine("Apellido: ");
        //}

        private string firstName;
        private string lastName;
    }
}
