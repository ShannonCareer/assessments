using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]nums = {1,0,1,0,0,1,1};
            
            for(int x = 0; x < nums.Length; x++){
                if(x >= ){
                    Swap(nums,);
                }//end if
            }//end for

            PrintArray(nums);

            Console.ReadKey();
        }//end main

         #region SwapFunction
        private static void Swap(int[] array,int pos1,int pos2){ 
            int holder = 0;
            holder = pos1; 
            pos1 = pos2;
            pos2 = holder;
            return;

        }//end swap function
        #endregion SwapFunction
        #region PrintArry
        static void PrintArray(int[]temp)
        {
            for (int index = 0; index < temp.Length; index++)
            {
                Console.Write(temp[index] + " "); // The " " creates a space in console display
            }
        }//end PRINTarray Function
        #endregion PrintArry

    }//end class

}//end namespace