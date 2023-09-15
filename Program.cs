using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeTags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the tag: ");
            string tag = Console.ReadLine();
            Console.WriteLine("Enter the word: ");
            string word = Console.ReadLine();

            Console.WriteLine(makeTags(tag, word));
            Console.ReadLine();
        }

        static string makeTags(string tag, string word)
        {
            return "<" + tag + ">" + word + "</" + tag + ">";
        }
    }
}
