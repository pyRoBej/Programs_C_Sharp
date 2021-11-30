using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprobacion.cs
{
    class Program
    {
        static void Main()
        {
            //Ejercicio del informe diario
            Console.WriteLine("The Tech Academy.\n Seguro de Automovil.");
            Console.WriteLine("Hola, para ser aprobada su solicitud de seguro de auto debe ser mayor de 15 años, no tener ningun DUI ni tener mas de 3 multas por exceso de velocidad");
            Console.WriteLine("Cual es tu nombre?");
            string yourName = Console.ReadLine();
            Console.WriteLine("que edad tiene?");
            string yourAge = Console.ReadLine();
            int age = Convert.ToInt32(yourAge);
            Console.WriteLine("Alguna vez ha tenido DUI? (debe responder true o false)");
            string textAnswer1 = "True";
            Console.ReadLine();
            bool hasAnswerFalse = Convert.ToBoolean(textAnswer1);

            Console.WriteLine("cuantas multas por exceso de velocidad tienes?");
            string yourStatus = Console.ReadLine();
            int status = Convert.ToInt32(yourStatus);

            bool isAuthorized = (age >= 15 && hasAnswerFalse == true && status < 3);
          
            Console.WriteLine("Gracias " + yourName + " por sus respuestas.");
            Console.WriteLine("Ha sido aprobada su solicitud? " + isAuthorized);
            Console.ReadLine();

        }
    }
}
