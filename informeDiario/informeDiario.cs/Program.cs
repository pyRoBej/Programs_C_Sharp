using System;


namespace informeDiario.cs
{
    class Program
    {
        static void Main()
        {
            //This a simple program
            Console.WriteLine("Hola, cual es tu nombre?");
            string yourName = Console.ReadLine();
            Console.WriteLine("your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("cual es tu numero favorito?");
            string FavoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(FavoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("tu numero favorito mas 5 is: " + total);
            Console.ReadLine();




        }
    }
}
