using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Algor2
{
    class primeNumbers
    {
        public static List<int> calPrimeNumber1(int m, int n){
            int Major = m;
            int Minor = n;
            if (n > m)
            {
                Major = n;
                Minor = m;
            }
            double sqrt = Math.Sqrt(m);

            bool[] OriginalArray = new bool[Major];

            //for (long i = 0; i < Major; i++)  // init
                //OriginalArray[i] = true;

            OriginalArray[0] = true;
            OriginalArray[1] = true;

            //從2開始, 2是質數
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
    }
}
