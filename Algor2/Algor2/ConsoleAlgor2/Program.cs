using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAlgor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入 m: ");
            var m = Console.ReadLine();
            Console.WriteLine("請輸入 n: ");
            var n = Console.ReadLine();

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Reset();
            sw.Start();
            List<int> resultList=  Algor2.primeNumbers.LinearSieve(int.Parse(m), int.Parse(n));
            string a = string.Join(",", resultList.ToArray());
            Console.WriteLine(a);
            sw.Stop();
            Console.WriteLine("完了, " + "花費" + (sw.Elapsed.TotalMilliseconds.ToString() + " ms").ToString());
            Console.ReadLine();
        }
    }
}
