using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.cs
{
    class Program //es la clase principal
    {
        static void Main(string[] args) //Main es donde comienza el flujo del programa, aqui se declaran los objetos/las instancias pertenecientes a nuestras clases
        {
            // las siguientes son las instancias
            Caballo TiroAlBlanco = new Caballo();

            Humano Manuel = new Humano();

            Gorila Donkey = new Gorila();


            //ahora vamos a usar las instancias pertenecientes a cada una de las clases anteriores (TiroAlBlanco, Manuel y Donkey), para utilizar sus metodos

            TiroAlBlanco.galopar();


        }
    }

            class Mamiferos //esta es la clase de mayor jerarquia, la que le hereda a los demas, (clase padre)
            {
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
                }

                public void cuidarCrias()
                {
                    Console.WriteLine("Cuido de mis crias hasta que se valen por si solas");
                }
            }

                    class Caballo:Mamiferos //esta seria la clase hijo xq hereda los metodos de la clase padre (respirar y cuidar crias son los metodos);
                                            //como sabemos que es clase hijo? xq dsps del nombre de la clase, la sintaxis lleva ":" y despues el nombre de la clase de la que hereda
                    {
                        public void galopar() //este metodo es exclusivo de la clase caballo, es un metodo que no hereda, es propio
                        {
                            Console.WriteLine("Soy capaz de galopar"); 
                        }
                    }

                    class Humano:Mamiferos
                    {
                        public void pensar()
                        {
                            Console.WriteLine("Soy capaz de pensar");
                        }
                    }

                    class Gorila:Mamiferos
                    {
                        public void trepar()
                        {
                            Console.WriteLine("Soy capaz de trepar");
                        }
                    }
}
