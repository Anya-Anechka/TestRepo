using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1GIT
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "a=b+c";
            string s2 = "b=1";
            string s3 = "c=2+d";
            string s4 = "e=b+c";
            string s5 = "b=2+d";
            List<string> lm = new List<string>() { s1, s2, s3, s4, s5 };
            List<char> ln = new List<char>() { 'a', 'b', 'c', 'e' };
            HashSet<string> exprs = new HashSet<string>();

            for (int i = 0; i < lm.Count; ++i)
                exprs.Add(lm[i].Split('=')[1]);

            foreach (char c in ln)
            {
                Console.Write(c + ":");
                for (int i = 0; i < lm.Count; ++i)
                {
                    if (lm[i][0] == c)
                        Console.Write("s" + (i + 1) + ",");
                }
                Console.WriteLine();
            }

           foreach (var e in exprs)
           {
                Console.Write(e + ": ");
                for (int i = 0; i < lm.Count; i++)
                {
                    var spl = lm[i].Split('=');
                    if (spl[1] == e)
                        Console.Write((i + 1) + ",");
                }
                Console.WriteLine();
            }

           Dictionary<char, List<int>> def = new Dictionary<char, List<int>>();
           foreach (char c in ln)
           {
               def.Add(c, new List<int>());
               for (int i = 0; i < lm.Count; ++i)
               {
                   if (lm[i][0] == c)
                       def[c].Add(i + 1);
               }
           }

           Dictionary<string, List<int>> expr = new Dictionary<string, List<int>>();
           foreach (string e in exprs)
           {
               expr.Add(e, new List<int>());
               for (int i = 0; i < lm.Count; ++i)
               {
                   var spl = lm[i].Split('=');
                   if (spl[1] == e)
                       expr[e].Add(i + 1);
               }
           }


            Console.ReadLine();
        }
    }
}