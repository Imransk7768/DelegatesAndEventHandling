using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void EventHandler(string str);
    public class EventHandling
    {
        public class Operations
        {
            public event EventHandler eventH;
            public void Action(string a)
            {
                if (eventH != null)
                {
                    eventH(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string strg)
        {
            Console.WriteLine("Method Calling");
        }
        public static void Implementation()
        {
            Operations obj = new Operations();
            obj.Action("Event Calling");
            Console.WriteLine();
            obj.eventH += new EventHandler(CatchEvent);
            obj.Action("Event Called");
        }
    }
}