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
            double ingresoXhr1 = Convert.ToDouble(Console.ReadLine()); //lee el valor
            // double iXh1 = Convert.ToInt32(ingresoXhr1); //el valor anterior lo convierte en entero
            Console.WriteLine("Cuantas horas trabajas por semana?");
            double hsXsem1 = Convert.ToDouble(Console.ReadLine());
            // double hXs1 = Convert.ToInt32(hsXsem1); //el valor anterior lo convierte en entero

            Console.WriteLine("Hola segunda persona, cual es tu nombre?");
            string pna2 = Console.ReadLine(); // guarda lo que escribe como pna1
            Console.WriteLine("Cuanto es tu ingreso por hora?");
            double ingresoXhr2 = Convert.ToDouble(Console.ReadLine()); //lee el valor
            // int iXh2 = Convert.ToInt32(ingresoXhr2); //el valor anterior lo convierte en entero
            Console.WriteLine("Cuantas horas trabajas por semana?");
            int hsXsem2 = Convert.ToInt32(Console.ReadLine());
            // int hXs2 = Convert.ToInt32(hsXsem2); //el valor anterior lo convierte en entero


            //toma los valores recibidos y hace la multiplicacion de sueldo por hora por el numero de horas por semana por el numero de semanas del ano y lo guarda en la variable total1 y total 2 respectivamente
            double total1 = ingresoXhr1 * hsXsem1 * 52.143; 
            double total2 = ingresoXhr2 * hsXsem2 * 52.143;

            Console.WriteLine("El salario anual de " + pna1 + " es = " + total1); //escribe el resultado de cada persona
            Console.WriteLine("El salario anual de " + pna2 + " es = " + total2);
            Console.ReadLine();

            Console.WriteLine(pna1 + " gana igual o mas que " + pna2 + "?"); // pregunta si pna 1 gana igual o mas que pna2
            bool comp = total1 >= total2;  // hace la comparacion de sueldos anuales
            Console.WriteLine(comp.ToString()); // imprime verdadero o falso
            Console.ReadLine();

        }
    }
}

