using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting....");
            Program app = new Program();
        }

        public Program()
        {
            {
                Console.WriteLine("in constructor and out of static context");
            }
        }
    }
}