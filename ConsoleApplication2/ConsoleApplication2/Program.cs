using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> Result = new List<String>();
            var nums = new NumsDivBy3and5 { iNums = 100 };  // Numbers between 1 and 100
            Result = nums.NumDivs();
            foreach (String s in Result)
                Console.WriteLine(s);
            Console.ReadKey();
        }

    }


}
