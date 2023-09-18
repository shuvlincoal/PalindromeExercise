using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string testStr)
        {
            string revStr = "";
            //testStr  = new string(testStr.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            revStr   = new string(testStr.Reverse().ToArray());
            

            return testStr == revStr;

        }//method

    }//class
}//namespace
