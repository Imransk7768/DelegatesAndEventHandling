using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class MultiCastDelegate
    {
        delegate void DelOp(int x, int y);
        public static void ImplementDelegate()
        {
            //Delegate Instantiation
            DelOp obj = Operation.Add;
            obj += Operation.Square;
            obj(4, 4);
            obj(7, 4);
            Console.ReadLine();
        }
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition is = {0}", a + b);
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple is = {0}", a * b);
            }
        }
    }
}