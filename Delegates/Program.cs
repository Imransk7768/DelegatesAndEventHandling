using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int operation(int x, int y);
    public class program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate POC");
            operation obj = new operation(Addition);
            Console.WriteLine("Addition is = {0}", obj(45, 55));
            EventHandling eventHandling = new EventHandling();
            EventHandling.Implementation();
        }
    }
}