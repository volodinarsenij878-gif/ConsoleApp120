using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program77
{
    internal class Program
    {
        static void Main()
        {
            bool result = (100 / 10 == 10) && (100 % 30 == 10) && !(5 - 5 != 0);
            Console.WriteLine(result);  // True
        }
    }
}
