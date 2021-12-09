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
                int resp = Convert.ToInt32(Console.ReadLine());
                Dias dia = (Dias)resp;

                if (resp > 0 && resp <= 7)
                {
                    Console.WriteLine("Hoy es: " + dia);
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un dia real de la semana.");
                    Console.ReadKey();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Por favor ingrese un numero entero.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Ha salido del try/catch");
                Console.ReadLine();
            }


            //DiasDeLaSemana laborales = DiasDeLaSemana.Lunes;    //si quisiera representar un valor nulo de los enum la sintaxis seria
            //                                                    //la siguiente: DiasDeLaSemana? laborales = null; (se usa la interrogativa y dsps del = el null)

            //Console.WriteLine(laborales);

        }


    }
}
