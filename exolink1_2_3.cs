using System;
using System.Collections.Generic;
using System.Linq;

namespace EXOLINK 
{
    class Program
    {
        ////////////////////////////////////// EXO 1 
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
        /////////////////////////// EXO 2
        List<int> years = new List<int>
            {
                2000,2001,2002,2003,2004,2005,2006,2007,2008,2009,2010,2011,2012,2013,2014,2015,2016,2017,2018,2019,2020
            };

            var request = (from bix in years
                           where (new DateTime(bix, 12, 31).DayOfYear == 366)
                           select bix);

                List<int> bisextile = request.ToList();
                Console.WriteLine("Les années bisextiles contenues dans la liste");
                foreach (int b in bisextile)
                    Console.WriteLine(b);
            
        
        /////////////////////////// EXO 3 
        static void Main(string[] args)
        {
            List<int> numbers2 = new List<int>
            {
                2,5,7,8,10,11,13,15,22,25,26,30,42,45,55,60,128,130
            };

            List<int> byfive = numbers2.Where(n => n % 5 == 0).ToList();
            foreach (int f in byfive)
                Console.WriteLine(f);
        }
        
    }
}
