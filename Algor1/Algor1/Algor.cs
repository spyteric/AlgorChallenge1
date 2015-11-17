using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algor1
{
    class Algor
    {
        public static List<int> GetNumberListByList(int end, int start, int interval, int total)
        {
            List<int> OrginalLits = new List<int>();
            List<int> ResultLits = new List<int>();
            for (int i = 1; i <= end; i++)
            {
                OrginalLits.Add(i);
            }

            int next = start - 1; // array's position
            for (int i = 0; i < end; i++)
            {
                ResultLits.Add(OrginalLits[next]);

                if (ResultLits.Count >= total || ResultLits.Count == end)
                    return ResultLits;
                next = next + interval;
                if (next > OrginalLits.Count-1)  //OrginalLits.IndexOf(OrginalLits.Max()))
                {
                    next = next - OrginalLits.Count;

                    DateTime a = DateTime.Now;
                    HashSet<int> temp = new HashSet<int>(ResultLits);
                    OrginalLits.RemoveAll(e => temp.Contains(e));

                    //Console.WriteLine(DateTime.Now.Subtract(a).TotalSeconds);

                    if (next >= OrginalLits.Count)
                    {
                        next = next % OrginalLits.Count;
                    }
                    continue;
                }
            }
            throw new Exception("Error when calcuate");
            //return null;
        }

        public static int[] GetNumberListByArray(int end, int start, int interval, int total)
        {

            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            int[] OrginalLits = new int[end];
            int[] ResultLits = new int[total];
            //sw.Reset();
            //sw.Start();
            for (int i = 0; i < end; i++) 
                OrginalLits[i] = i+1;
            //sw.Stop();
            //Console.WriteLine("inited OriginalList Done: " + sw.ElapsedMilliseconds.ToString() + " ms");
            //sw.Start();
            int next = start - 1; // array's position
            int reachToLimit = 0;
            for (int i = 0; i < end; i++)
            {
                ResultLits[i] = OrginalLits[next];
                if (i + 1 >= total || i + 1 == end)
                {
                    //sw.Stop();
                    //Console.WriteLine("Algor Done: " + sw.ElapsedMilliseconds.ToString() + " ms, reachToLimit: " + reachToLimit);
                    return ResultLits;
                }

                OrginalLits[next] = -1; // take out from array 
                next = next + interval;
                if (next > OrginalLits.Length - 1)  //OrginalLits.IndexOf(OrginalLits.Max()))
                {
                    next = next - OrginalLits.Length;
                    OrginalLits = OrginalLits.Where(val => val != -1).ToArray();
                    reachToLimit++;
                    //sw.Stop();
                    //Console.WriteLine("ReachToLimit: " + reachToLimit + " - " +sw.ElapsedMilliseconds.ToString() + " ms");
                    //sw.Start();
                    if (next >= OrginalLits.Length)
                        next = next % OrginalLits.Length;
                    continue;
                }
            }
            throw new Exception("Error when calcuate");
            //return null;
        }


        public static List<int> GetNumberListByArrayWithNotRemove(int end, int start, int interval, int total)
        {
            int[] OrginalLits = new int[end];
            //int[] ResultLits = new int[total];
            List<int> ResultLits = new List<int>();
            for (int i = 0; i < end; i++)
                OrginalLits[i] = i + 1;
            int next = start - 1; // array's position
            for (int i = 0; i < end; i++)
            {
                //ResultLits[i] = OrginalLits[next];
                ResultLits.Add(OrginalLits[next]);
                OrginalLits[next] = -1; // take out from array
                

                if (i + 1 >= total || i + 1 == end)
                    return ResultLits;
                
                int index = 0;
                do
                {
                    next++;
                    if (next > OrginalLits.Length - 1)
                        next = 0;
                    if (OrginalLits[next] != -1)
                    {
                        index++;
                    }

                } while (index < interval);//interval % OrginalLits.Length);
            }
            throw new Exception("Error when calcuate");
        }
    }
}
