using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeDiario.cs
{
        class Program
        {
            static void Main()
            {
                //Ejercicio del informe diario
                Console.WriteLine("The Tech Academy.\" \" Informe diario del estudiante.");
                Console.WriteLine("Hola, cual es tu nombre?");
                string yourName = Console.ReadLine();
                Console.WriteLine("En que curso estas?");
                string nameCourse = Console.ReadLine();
                Console.WriteLine("En que numero de pagina estas?");
                string pageNumber = Console.ReadLine();
                int pageNum = Convert.ToInt32(pageNumber);
                Console.WriteLine("Necesitas ayuda con algo? responda verdadero o falso.");
                string textAnswer = "True";
                bool hasAnswerTrue = Convert.ToBoolean(textAnswer);
                if (hasAnswerTrue)
                {
                    Console.ReadLine();
                    // Console.WriteLine("En breve un instructor se comunicara con ud.");
                }

                Console.WriteLine("Hubo alguna experiencia positiva que le gustaria compartir? si es asi, proporcione detalles.");
                string exp = Console.ReadLine();
                Console.WriteLine("Hay algun otro comentario que le gustaria proporcionar?");
                string comment = Console.ReadLine();
                Console.WriteLine("Gracias " + yourName + " por sus respuestas. \" Un instructor respondera a esto en breve.");
                Console.WriteLine("Que tengas un gran dia!");
                Console.ReadLine();

            }
        }
}
