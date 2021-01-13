using System;
using System.Collections.Generic;

namespace ListSorter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> Names = new List<string>();
            Names.Add("Irma");
            Names.Add("Coreen");
            Names.Add("Marget");
            Names.Add("Bree");
            Names.Add("Eleanor");
            Names.Add("Georgia");
            Names.Add("Marisa");
            Names.Add("Clyde");
            Names.Add("Latasha");
            Names.Add("Katharine");
            Names.Add("Milissa");
            Names.Add("Timmy");
            Names.Add("Landon");
            Names.Add("Julieta");
            Names.Add("Marti");
            Names.Add("Delois");
            Names.Add("Jaquelyn");
            Names.Add("Samella");
            Names.Add("Valentina");
            Names.Add("Karine");

            Console.WriteLine("Original list of names");

            foreach(string s in Names)
            {
                Console.WriteLine(s);
            }

            List<string> NamesSorted1;
            NamesSorted1 = Names;
            NamesSorted1.Sort();

            Console.WriteLine("Names sorted using List.Sort() method");
            foreach(string s in NamesSorted1)
            {
                Console.WriteLine(s);
            }

            List<string> NamesSorted2;
            NamesSorted2 = Names;

            string temp;
            for(int a = 0; a < Names.Count; a++)
            {
                for(int b = 0; b<Names.Count-1; b++)
                {
                    if (string.Compare(Names[b], Names[b+1]) > 0)
                    {
                        temp = Names[b];
                        Names[b] = Names[b + 1];
                        Names[b + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Names sorted using Bubble Sort method");
            foreach(string s in NamesSorted2)
            {
                Console.WriteLine(s);
            }

        }
    }
}
