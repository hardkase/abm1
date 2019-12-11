using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace abm1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:/code/abm_test/abm1/test1.txt");
            List<string> results = new List<string>();
            foreach (string line in lines)
            {
                String[] lineList = line.Split("+");
                foreach (string element in lineList)
                {
                    if (element == "LOC")
                    {
                        results.Add(lineList[1]);
                        results.Add(lineList[2]);
                    }
                }
     
            }
            //This is a little redundant, but task asks for Array...
            string[] finalResults = new string[10];
            for (var i = 0; i < results.Count; i++)
            {
                finalResults[i] = results[i];
            }
            foreach (string item in finalResults)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
    //GETTING TRIPLE VALUES IN RESULTS, DEBUG THAT
}
