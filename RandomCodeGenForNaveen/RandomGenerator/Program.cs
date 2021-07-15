/* Brana Balan */
/* Code for Naveen */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRandom randomClass = ClassRandom.Instance;
            // ClassRandom randomClass = new ClassRandom();

            int[] rtnVal = randomClass.RandomGenerator();
            // Generate 1000 unique,not repeating,noseq random integers from 1000 to 9999.
            Console.WriteLine("1000 random integers between 1000 and 9999:");
            for (int ctr = 0; ctr < rtnVal.Length; ctr++)
            {
                Console.WriteLine("Return value=" + rtnVal[ctr]);
            }
            Console.WriteLine();
        }
    }

    
}
