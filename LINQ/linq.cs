using System;                           
using System.Collections.Generic;       
using System.Linq;                      
namespace LINQ_Demo                     
{
    class Linq                           
    {
        static void Main()               
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 }; 

            var evenNumbers = numbers   
                .Where(n => n % 2 == 0)  
                .Select(n => n * 10)   
                .ToList();               


            foreach (var num in evenNumbers)        
            {
                Console.WriteLine(num);             
            }

            var firstEven = numbers.FirstOrDefault(n => n % 2 == 0); 

            Console.WriteLine($"First even number: {firstEven}");    

            bool hasOdd = numbers.Any(n => n % 2 != 0); 

            Console.WriteLine($"Contains odd number: {hasOdd}");
        }
    }
}
