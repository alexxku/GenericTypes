using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            NonGeneric();
            Generic();
        }

        static void NonGeneric()
        {
            Console.WriteLine("----Nongeneric List----");
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // list.Add("Hello!"); -----Compile time error-----
            foreach(int x in list)
            {
                Console.WriteLine(x);

            }
        }

        static void Generic()
        {
            Console.WriteLine("----Generic List----");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            // list.Add("Hello!"); -----No compile time error...Red squiggly line appears-----
            foreach (int x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}
