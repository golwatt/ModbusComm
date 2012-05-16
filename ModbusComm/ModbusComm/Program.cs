using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModbusComm
{
    class Test
    {
        public void method(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }
    }

    class Program
    {
        static public event EventHandler pe;
        static void Main(string[] args)
        {
            Test t = new Test();
            pe += t.method;
            Console.ReadKey();
        }
    }
} 