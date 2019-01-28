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
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", nums));
            
            BubbleSort(nums);

            Console.ReadKey();
        }//end main

         #region BubbleSort 
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++) //iterates through array
            {
              for (int j = 0; j < array.Length - i - 1; j++)
              {
                if (array[j] > array[j + 1]) //if statement (array[0] > array[1])
                {
                  int temp = array[j]; //{Exchange function}
                  array[j] = array[j + 1];
                  array[j + 1] = temp;
                }//end if

              }//end for-loop j

              // Print array after every pass
              Console.Write("After pass " + i + "  : ");

              //Printing array after pass
              Console.WriteLine(String.Join(" ", array));
            }//end for-loop i
        }//end bubble sort ()
        #endregion 

    }//end class

}//end namespace