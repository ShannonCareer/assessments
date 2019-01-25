using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.palindrome
{
    class Program
    {
        static void Main(string[] args){
               
            string input = Prompt("Please enter a word to be checked: ");
            
            
        }//end main

        #region prompt
        static string Prompt(string msg){
            Console.WriteLine(msg + "");
            return Console.ReadLine();
        }
        #endregion

    }//end class

}//end namespace
