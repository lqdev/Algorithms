using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace stacksandqueues
{
    class Program
    {
        static StreamReader URLStream(String fileurl){
            return new StreamReader(new HttpClient().GetStreamAsync(fileurl).Result);
        }

        static void Main(string[] args)
        {
            LinkedStackOfStrings ls = new LinkedStackOfStrings();

            String line;
            String[] words;
            StreamReader s = new StreamReader(@"tobe.txt");
            
            while((line = s.ReadLine()) != null) 
            {
                words = line.Split(' ');
                foreach (var word in words)
                {
                    if(!word.Equals("-")) {ls.push(word);}
                }
            }

            while(!ls.isEmpty())
            {
                Console.WriteLine(ls.pop());
            }
        }
    }
}
