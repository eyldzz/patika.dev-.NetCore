using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace collectionQuestion1
{
    internal class Program 
    {
        

        public static bool PrimeOrNot(int param)
        {
            int control = 0;
            for(int i = 1;i<=param/2;i++)
            {
                if(param%i==0)
                    control++;
                
            }
            return (control>1) ? false : true;
        }

        public static int CalcAverage(int _num, int _count)
        {
            if (_num == 0 || _count == 0)
                return 0;
            else
                return _num / _count;
            
        }
        // Put the 20 positive numbers entered from the keyboard into two separate lists, prime and non-prime. (Write using the ArrayList class.)
        public static void Main(string[] args)
        {
            ArrayList primes = new ArrayList();
            ArrayList nonPrimes = new ArrayList();
            Console.WriteLine("****** Enter 20 integer ******");
            bool isNum;
            int sumPrimes = 0;
            int sumNonprimes = 0;
           
            for(int i=0;i<20;i++)
            {
                Console.Write($"enter number {i+1}: ");
                isNum = int.TryParse(Console.ReadLine(), out int num);
                if (isNum == true && num > 0)
                {
                    if (PrimeOrNot(num) && num!=1)
                    {
                        primes.Add(num);
                        sumPrimes += num;
                    }
                    else
                    {
                        nonPrimes.Add(num);
                        sumNonprimes += num;
                    }
                }
                else
                {
                    Console.WriteLine("value must be positive integer!");
                    i--;
                }
            }

            primes.Sort();
            primes.Reverse();
            nonPrimes.Sort();
            nonPrimes.Reverse();

            Console.WriteLine("Primes: ");
            foreach(int i in primes) 
                Console.WriteLine(i);
            Console.WriteLine("\nNon Primes: ");
            foreach (int i in nonPrimes)
                Console.WriteLine(i);

             Console.WriteLine("\nPrime numbers average: " + CalcAverage(sumPrimes,primes.Count));
             Console.WriteLine("Non Prime numbers average: " + CalcAverage(sumNonprimes,nonPrimes.Count));
    
            
            


        }
    }
}