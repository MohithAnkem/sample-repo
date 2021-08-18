using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment_1
{
    class ex17
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word ");
            string ch = Console.ReadLine();
            Console.WriteLine("Enter the second word ");
            string s = Console.ReadLine();
            if(ch.Length!=s.Length)
            {
                Console.WriteLine("the words" + ch + "and" + s + "are not same");
            }
            else
            {
                if (String.Equals(s, ch))
                    Console.WriteLine("two words are same");
                else
                    Console.WriteLine("the words " + ch + " and " + s + " are not same");
            } 
        }
    }
}
