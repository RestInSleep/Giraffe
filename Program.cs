using System;
using System.Buffers.Text;
using System.Collections.Generic;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
            {
             const decimal priceForSqF=20;
             
             Console.WriteLine("Enter width (m)");
             decimal a = decimal.Parse(Console.ReadLine());

             Console.WriteLine("Enter length (m)");
             decimal b = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"The price is {a*b*priceForSqF}");
            Console.WriteLine("HOORAY");
            Console.WriteLine("baby giraffe!");
            
            

           
            }







    }
}