using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie care va determina daca un numar este sau nu
             * patrat perfect. Apelati-o si afisati-i rezultatul */
            Console.WriteLine("Add a number");
            
            int number = int.Parse(Console.ReadLine());
            
            if (GetSquareNumber(number))
            {
                Console.WriteLine("The number introduced is a perfect sqare");
            }
            else
            {
                Console.WriteLine("The number introduced is not a perfect sqare");
            }
        }
        public static bool GetSquareNumber(int number)
        {
            bool results = false;
            double sqare = (int)Math.Sqrt(number);
            results = number == sqare * sqare;
            return results;
           
        }
    }
}
