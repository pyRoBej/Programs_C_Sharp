using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion324.cs
{
    enum Dias {Lunes=1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };  //asi se declaran los enum
    
    class Program
    {
        static void Main(string[] args)
        {
            //Asignacion 324

            try
            {
                Console.WriteLine("Hola, ingrese el dia actual de la semana (del 1 al 7)");
                int dia = Convert.ToInt32(Console.ReadLine());

                //Dias lun = (Dias)1;
                
                //for (int i =1; i< Dias)
                //{
                //    string result = 
                //}
                
                //Console.WriteLine("Hoy es: " + lun);
                Console.ReadKey();

            }
            catch (FormatException ex)
            {

            }


            //DiasDeLaSemana laborales = DiasDeLaSemana.Lunes;    //si quisiera representar un valor nulo de los enum la sintaxis seria
            //                                                    //la siguiente: DiasDeLaSemana? laborales = null; (se usa la interrogativa y dsps del = el null)

            //Console.WriteLine(laborales);

        }


    }
}
