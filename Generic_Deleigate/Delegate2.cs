using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Deleigate
{
    internal class Delegate2:Delegate1
    {
       /* public static void Method1(string message)
        {
            Console.WriteLine("Del2: " + message);
        }*/

        public static int Method1() { return 2; }
    }
}
