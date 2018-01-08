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
            //LinkedStackOfStrings ls = new LinkedStackOfStrings();
            //FixedCapacityOfStrings ls = new FixedCapacityOfStrings(5);
            //ResizingArrayStackOfStrings ls = new ResizingArrayStackOfStrings();
            //LinkedQueueOfStrings ls = new LinkedQueueOfStrings();
            GenericLinkedList<String> ls = new GenericLinkedList<String>();
            String line;
            String[] words;
            StreamReader s = new StreamReader(@"tobe.txt");
            
            
            while((line = s.ReadLine()) != null) 
            {
                words = line.Split(' ');
                foreach (var word in words)
                {
                    if(!word.Equals("-")) {
                        ls.push(word);
                        //ls.enqueue(word);
                    } else {
                        Console.Write(ls.pop() + " ");
                        //Console.Write(ls.dequeue() + " ");
                    }
                }
            }
        }
    }
}
