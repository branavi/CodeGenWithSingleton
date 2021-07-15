using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    public class ClassRandom
    {
        private static ClassRandom singletontestobj = null;
        private ClassRandom() { }
        public static ClassRandom Instance
        {
            get
            {
                if(singletontestobj == null)
                {
                  singletontestobj = new ClassRandom();
                }
                return singletontestobj;
            }
        }

        public int[] RandomGenerator()
        {
            int[] intRandom = new int[1000];
            var rand = new Random();
            int rndNum = 0;
            for (int loop = 0; loop < 1000; )
            {
                rndNum = rand.Next(1000, 9999);
                //First checking whether the numbers are consecutive
                if (!doesItRepeat(rndNum))
                {
                    //Then checking whether the numbers are sequential
                    if(!IsItSeq(rndNum))
                        //Finally checking whether the number is already exist, and only adding to the array if all these conditions are made to improve the performance
                    if (!doesItExist(intRandom, rndNum))
                    {
                        intRandom[loop] = rndNum;
                        loop++;
                    }
                }
 
            }
            return intRandom;
        }

        //Check whether the number is already exist
        private bool doesItExist(int[] arr,int intsearch)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]== intsearch)
                {
                    return true;
                }
            }

            return false;
        }

        //Check consecutive numbers
        private bool doesItRepeat(int intNum)
        {
            char[] NumtoChar = intNum.ToString().ToCharArray();
            if(NumtoChar[0]== NumtoChar[1])
            {
                return true;
            }
            if (NumtoChar[1] == NumtoChar[2])
            {
                return true;
            }
            if (NumtoChar[2] == NumtoChar[3])
            {
                return true;
            }

            return false;
        
        }

        //Check sequential numbers
        private bool IsItSeq(int intNum)
        {
            char[] NumtoChar = intNum.ToString().ToCharArray();
            int numOne = int.Parse((NumtoChar[0].ToString())); ;
            int numtwo = int.Parse((NumtoChar[1].ToString())); ;
            int numthree = int.Parse((NumtoChar[2].ToString())); ;
            int numfour = int.Parse((NumtoChar[3].ToString())); ;
            if(numtwo  == (numOne + 1))
            {
                return true;
            }
            if (numthree == (numtwo + 1))
            {
                return true;
            }
            if (numfour == (numthree + 1))
            {
                return true;
            }
 
            return false;

        }
    }
}

