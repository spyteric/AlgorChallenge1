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

            Console.WriteLine("m: " + m.ToString());
            Console.WriteLine("n: " + n.ToString());
            int Major = m;
            int Minor = n;
            if (n > m)
            {
                Major = n;
                Minor = m;
            }

            bool[] OriginalArray = new bool[Major];
            for (long i = 0; i < Major; i++)  // init
                OriginalArray[i] = true;

            OriginalArray[0] = false;
            OriginalArray[1] = false;

            for (long i = 2; i < Major; i++)
                if (OriginalArray[i])
                    // 刪掉質數i的倍數，從兩倍開始。保留原本質數。
                    for (long j = i * i; j < Major; j += i)
                        OriginalArray[j] = false;


            List<int> prime = new List<int>();
            for (int i = Minor; i < Major; i++)
                if (OriginalArray[i])
                    prime.Add(i);

            return prime;
        }
    }
}
