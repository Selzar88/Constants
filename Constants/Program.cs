using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change for the lifetime of the program.
    internal class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "30.04.1988";


        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always: {0}", myBirthday);
            Console.ReadKey();
        }
    }
}
