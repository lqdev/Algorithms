using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace elementarysorts
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader s = new StreamReader(@"tiny.txt");
            string[] letters = s.ReadLine().Split(" ");
            foreach(var letter in letters){
                Console.Write(letter + " ");
            }
            Shell.sort(letters);
            Console.WriteLine();
            foreach(var letter in letters){
                Console.Write(letter + " ");
            }
        }
    }
}
