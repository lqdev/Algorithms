using System;
using System.IO;
using System.Net.Http;

namespace unionfind
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String line;
            StreamReader s = new StreamReader(args[0]);
            String u = s.ReadLine();

            QuickFindUF uf = new QuickFindUF(int.Parse(u));

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
