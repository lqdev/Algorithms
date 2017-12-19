using System;
using System.IO;
using System.Net.Http;

namespace unionfind
{
    class Program
    {

        static StreamReader URLStream(string fileurl){
            return new StreamReader(new HttpClient().GetStreamAsync(fileurl).Result);
        }
        
        static string selectInput(string s)
        {
            switch (s)
            {
                case "1":
                    return "https://algs4.cs.princeton.edu/15uf/tinyUF.txt";
                default:
                    Console.WriteLine("Using Local File");
                    return "tinyUF.txt";
            }
        }

        static void Main(string[] args)
        {
            String line;
            StreamReader s;
            String fileurl = selectInput(args[1]);

            if(args[0].Equals("local"))
            {
                s = new StreamReader(fileurl);
            } 
            else 
            {
                s = URLStream(fileurl);
            }
            
            String u = s.ReadLine();

            //QuickFindUF uf = new QuickFindUF(int.Parse(u));
            //QuickUnionUF uf = new QuickUnionUF(int.Parse(u));
            WeightedQuickUnionUF uf = new WeightedQuickUnionUF(int.Parse(u));
            while((line = s.ReadLine()) != null) {
                string[] x = line.Split(" ");
                
                int p = int.Parse(x[0]);
                int q = int.Parse(x[1]);

                if(uf.connected(p,q)) continue;

                uf.union(p,q);
            }

            uf.printList();
            Console.WriteLine(uf.count);
        }
    }
}
