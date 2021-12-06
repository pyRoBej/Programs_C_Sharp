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
            Caballo ToyStory = new Caballo("TiroAlBlanco"); //aqui despues de que se creo un nuevo constructor hubo necesidad de pasarle un argumento en este punto

            Humano ToyStoryH = new Humano("Andy");  //para cada uno se tuvo la necesidad de pasarle argumento

            Gorila Donkey = new Gorila("DonkeyKong");


            //ahora vamos a usar las instancias pertenecientes a cada una de las clases anteriores (TiroAlBlanco, Manuel y Donkey), para utilizar sus metodos

            ToyStory.getNombre();

            ToyStoryH.getNombre();

            // veremos como se aplica el ppio de sustitucion 

            Mamiferos animal = new Caballo("Spirit"); //la sintaxis del principio es: contestando la pregunta.- un mamifero no siempre es un caballo, al reves si

            Caballo Spirit = new Caballo("Spitit");  //este es otra forma de aplicar el principio de sustitucion


            Console.ReadLine();

        }
    }

            class Mamiferos //esta es la clase de mayor jerarquia, la que le hereda a los demas, (clase padre) la super clase
            {
                
                public Mamiferos(String nombre) //aqui se creo un constructor que reemplazo al constructor por defecto,
                                                //lo que afecta a los :base() de cada clase hijo (caballo, humano y gorila):
                                                //lo que va a provocar que en cada clase creemos un constructo;
                                                //esto no es necesario, solo es para conocer que se puede sustituir
                {
                    nombreSerVivo = nombre;
                }
                //a continuacion lo que aparece son los metodos
                public void respirar()
                {
                    Console.WriteLine("Soy capaz de respirar");
                }

                public void cuidarCrias()
                {
                    Console.WriteLine("Cuido de mis crias hasta que se valen por si solas");
                }
                  
                public void getNombre()
                {
                    Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
                }
                
                private String nombreSerVivo;
            }

                    class Caballo:Mamiferos //esta seria la clase hijo xq hereda los metodos de la clase padre (respirar y cuidar crias son los metodos);
                                            //como sabemos que es clase hijo? xq dsps del nombre de la clase, la sintaxis lleva ":" y despues el nombre de la clase de la que hereda
                    {
                        public Caballo(String nombreCaballo):base(nombreCaballo)
                        {

                        }

                        public void galopar() //este metodo es exclusivo de la clase caballo, es un metodo que no hereda, es propio
                        {
                            Console.WriteLine("Soy capaz de galopar"); 
                        }
                    }

                    class Humano:Mamiferos
                    {
                        public Humano(String nombreHumano) : base(nombreHumano)
                        {

                        }
                        public void pensar()
                        {
                            Console.WriteLine("Soy capaz de pensar");
                        }
                    }

                    class Gorila:Mamiferos
                    {

                        public Gorila(String nombreGorila) : base(nombreGorila)
                        {

                        }
                        public void trepar()
                        {
                            Console.WriteLine("Soy capaz de trepar");
                        }
                    }


}
