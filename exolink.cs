using System;
using System.Collections.Generic;
using System.Linq;

namespace EXOLINK 
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            };

            List<int> primes = (from primeNumber in numbers
                                where isPrime(primeNumber)
                                select primeNumber).ToList();
            Console.WriteLine("Liste des nombres premiers");
            foreach (int p in primes)
                Console.WriteLine(p);
        }



        private static bool isPrime(int number)
        {
            if (number == 1)
                return false;
            int max = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 2; i < max + 1; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
