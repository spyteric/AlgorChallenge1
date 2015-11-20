using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Algor2
{
    public class primeNumbers
    {
        public static List<int> calPrimeNumber1(int m, int n){
            int Major = m;
            int Minor = n;
            if (n > m)
            {
                Major = n;
                Minor = m;
            }
            if (Major < 2) return new List<int>();
            Major = Major + 1;
            double sqrt = Math.Sqrt(Major);
            bool[] OriginalArray = new bool[Major];
            OriginalArray[0] = true;
            OriginalArray[1] = true;
            for (long i = 2; i <= sqrt; i++)
                if (!OriginalArray[i])
                    for (long j = i*i; j < Major; j += i)
                        OriginalArray[j] = true;

            List<int> prime = new List<int>();
            for (int i = Minor; i < Major; i++)
                if (!OriginalArray[i])
                    prime.Add(i);

            return prime;
        }

        public static List<int> LinearSieve(int m, int n)
        {
            int Major = m;
            int Minor = n;
            int b = -1;
            if (n > m)
            {
                Major = n;
                Minor = m;
            }
            if (Major < 2) return new List<int>();
            Major = Major + 1;
            bool[] sieve = new bool[Major];
            List<int> prime = new List<int>();
            
            for (int i = 2; i < Major; i++)
            {
                if (!sieve[i])
                {
                    prime.Add(i);
                    if (b == -1  && i >= Minor)
                        b = prime.IndexOf(i);
                }
                for (int j = 0; i * prime[j] < Major; j++)
                {
                    sieve[i * prime[j]] = true;
                    if (i % prime[j] == 0) break;
                }
            }
            if (Minor < 2) return prime;
            prime.RemoveRange(0, b);
            return prime;

        }
    }
}
