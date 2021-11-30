using System;

namespace Programa_Comparacion_ingresos.cs
{
    class Program
    {
        static void Main()
        {
            //Ejercicio de comparacion de ingresos
            Console.WriteLine("Programa de comparacion de ingresos anonimo.");
            Console.WriteLine("Hola primera persona, cual es tu nombre?"); //toma el valor de la cadena (nombre)
            string pna1 = Console.ReadLine(); // guarda lo que escribe como pna1
            Console.WriteLine("Cuanto es tu ingreso por hora?");
            string ingresoXhr1 = Console.ReadLine(); //lee el valor
            double iXh1 = Convert.ToInt32(ingresoXhr1); //el valor anterior lo convierte en entero
            Console.WriteLine("Cuantas horas trabajas por semana?");
            string hsXsem1 = Console.ReadLine();
            double hXs1 = Convert.ToInt32(hsXsem1); //el valor anterior lo convierte en entero

            Console.WriteLine("Hola segunda persona, cual es tu nombre?");
            string pna2 = Console.ReadLine(); // guarda lo que escribe como pna1
            Console.WriteLine("Cuanto es tu ingreso por hora?");
            string ingresoXhr2 = Console.ReadLine(); //lee el valor
            int iXh2 = Convert.ToInt32(ingresoXhr2); //el valor anterior lo convierte en entero
            Console.WriteLine("Cuantas horas trabajas por semana?");
            string hsXsem2 = Console.ReadLine();
            int hXs2 = Convert.ToInt32(hsXsem2); //el valor anterior lo convierte en entero

            double total1 = iXh1 * hXs1 * 52.143;
            double total2 = iXh2 * hXs2 * 52.143;

            Console.WriteLine("El salario anual de " + pna1 + " es = " + total1); //toma los valores recibidos y hace la multiplicacion de sueldo por hora por el numero de horas por semana por el numero de semanas del ano
            Console.WriteLine("El salario anual de " + pna2 + " es = " + total2);
            Console.ReadLine();

            Console.WriteLine(pna1 + " gana igual o mas que " + pna2 + "?");
            bool comp = total1 >= total2;
            Console.WriteLine(comp.ToString());
            Console.ReadLine();

        }
    }
}

