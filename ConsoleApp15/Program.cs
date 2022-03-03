using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;  
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "y");
            HT.Add(3, "k");
            HT.Add(4, "c");
            HT.Add(2, "v");
            HT.Add(5, "u");
            foreach (object i in HT.Keys)
                Console.WriteLine(i);
            foreach (object J in HT.Values)
                Console.WriteLine(J);
            foreach (DictionaryEntry di in HT)
                Console.WriteLine("keys={0} values={1}", di.Key, di.Value);
            Console.ReadKey();

        }
    }
}
