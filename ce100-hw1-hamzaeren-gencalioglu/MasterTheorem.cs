using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_hamzaeren_gencalioglu
{

        public class MasterTheorem
        { 
            public static string TimeComplexity(int a, int b, int fnDegree)
            {
                double logba = Math.Log(a, b);
                double logbaToFn = Math.Pow(logba, fnDegree);

                if (logbaToFn > 1)
                {
                    return $"O(n^{logbaToFn:N0})";
                }
                else if (logbaToFn == 1)
                {
                    return "O(n log n)";
                }
                else
                {
                    return "O(n)";
                }
            }
        }
}

