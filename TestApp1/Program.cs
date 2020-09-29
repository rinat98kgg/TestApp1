using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseStringMethod("abcd");
            Console.ReadLine();
        }

        private static void ReverseStringMethod(string text)
        { 
            string resultText = "";
            int length;

            length = text.Length - 1;

            while (length >= 0)
            {
                resultText = resultText + text[length];
                length--;
            }
            Console.WriteLine(resultText);
        }
    }
}
