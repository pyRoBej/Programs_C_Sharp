using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion324.cs
{
    
    
    class Program
    {
        enum Dias { Lunes=1, Martes=2, Miercoles=3, Jueves=4, Viernes=5, Sabado=6, Domingo=7 };  //asi se declaran los enum

        static void Main()
        {
            //Asignacion 324
            Dias dia;
            Console.WriteLine("Hola, ingrese el dia actual de la semana");
            string value = Console.ReadLine();

            try
            {
                dia = (Dias)Enum.Parse(typeof(Dias), value);

                Console.WriteLine("Hoy es: " + dia);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Por favor ingrese un dia real de la semana.");
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Ha salido");
                Console.ReadLine();
            }



            //DiasDeLaSemana laborales = DiasDeLaSemana.Lunes;    //si quisiera representar un valor nulo de los enum la sintaxis seria
            //                                                    //la siguiente: DiasDeLaSemana? laborales = null; (se usa la interrogativa y dsps del = el null)

            //Console.WriteLine(laborales);

        }


    }
}
