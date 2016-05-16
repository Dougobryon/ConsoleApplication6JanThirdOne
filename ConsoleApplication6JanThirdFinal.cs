using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6JanThirdOne
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] pointvalues = { 2.2, 4.4, 6.6, 8.8, 9.9  };
            foreach (double pointvalue in pointvalues)
            {
                Console.Write("{0} ", pointvalue.ToString("N1"));
            }           
        }
    }
}
