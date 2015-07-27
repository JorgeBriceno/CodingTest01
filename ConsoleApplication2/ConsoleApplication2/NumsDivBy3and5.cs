using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class NumsDivBy3and5
    {
        public int iNums { get; set; }

        public List<String> NumDivs()
        {
            List<String> Result = new List<String>();
            string sOutput;
            for (int i = 1; i <= iNums; i++)
            {
                sOutput = (DivBy(i, 3) && DivBy(i, 5)) ? ": Ficc, Buzz" : DivBy(i, 3) ? ": Ficc" : DivBy(i, 5) ? ": Buzz" : "";
                Result.Add(i.ToString() + "-" + sOutput + "-");
            }
            return Result;
        }

        private bool DivBy(int iNum, int iDivBy)
        {
            return (iNum % iDivBy) == 0;
        }
    }
}
